using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SpringBootCodeFactory.code;
using SpringBootCodeFactory.code.logic;
using SpringBootCodeFactory.code.entity;
using SpringBootCodeFactory.code.common;
using SpringBootCodeFactory.code.util;
using System.Diagnostics;
using SpringBootCodeFactory.code.area;
using common.code.register;
using MetroFramework.Forms;
using MetroFramework;
using QuickCommand;

namespace SpringBootCodeFactory
{
    public partial class FormCodeTool : MetroForm
    {
        private string CurrentPath = System.AppDomain.CurrentDomain.BaseDirectory;
        private ServiceManager manager = null;

        private bool changing = false;

        public FormCodeTool()
        {
            InitializeComponent();
            metroStyleManager.Theme = MetroThemeStyle.Default;
            metroStyleManager.Style = MetroColorStyle.Teal;
            Init();
        }

        private void Init()
        {
            manager = new ServiceManager();
            ProjectConfig.Service = new Service();
        }

        private void SetCurrentDS(Service service)
        {
            ProjectConfig.Service = service;
            foreach (DataSource ds in ProjectConfig.Service.DataSourceList)
            {
                AddDataSource(service, ds);
            }
        }

        #region gloabal

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = Service.FileFilter;
            dialog.InitialDirectory = CurrentPath;
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ProjectConfig.Service = XmlHelper<Service>.Read(dialog.FileName);
                GetService(ProjectConfig.Service);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SetService(ProjectConfig.Service);
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = Service.FileFilter;
            dialog.InitialDirectory = CurrentPath;
            dialog.FileName = ProjectConfig.Service.Name;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                XmlHelper<Service>.Write(ProjectConfig.Service, dialog.FileName);
            }
        }

        private void btnLoadDB_Click(object sender, EventArgs e)
        {
            if (ProjectConfig.CurrentDataSource != null)
            {
                string tableName = txtEntity.Text.Trim();
                MySqlHelper helper = new MySqlHelper(ProjectConfig.CurrentDataSource);
                try
                {
                    string comment = helper.SearchTableInfo(tableName);
                    List<List<string>> tables = helper.select("show full columns from " + tableName);

                    Entity entity = new Entity(tableName, comment, tables);
                    AddEntity(ProjectConfig.CurrentDataSource, entity);

                    ListViewItem item = GetEntityItem(entity);
                    lvEntity.Items.Add(item);
                    item.Selected = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("表 (" + tableName + ") 不存在\n" + ex.Message, "读取数据库错误");
                }
            }
        }

        private void btnGeneration_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = dialog.SelectedPath + "\\" + ProjectConfig.Service.Name;
                manager.GenerationProject(ProjectConfig.Service, CurrentPath + "\\root", path, ckOverride.Checked);

                Command cmd = new Command("maven", path + "\\install.bat", null, QuickCommand.CommandType.Start);
                Command.Excute(cmd);

                MessageBox.Show("项目生成完成！");
            }

        }

        #endregion

        #region service

        public void SetService(Service service)
        {
            service.Name = txtName.Text.Trim();
            service.Port = txtPort.Text;
            service.Version = txtVersion.Text;
            service.DomainName = txtDomainName.Text;
        }

        public void GetService(Service service)
        {
            txtName.Text = service.Name;
            txtPort.Text = service.Port;
            txtVersion.Text = service.Version;
            txtDomainName.Text = service.DomainName;
            lvDataSource.Items.Clear();
            foreach (DataSource ds in service.DataSourceList)
            {
                AddDataSource(service, ds);
                lvDataSource.Items.Add(GetProjectItem(ds));
            }

            if (lvDataSource.Items.Count > 0)
            {
                lvDataSource.Items[0].Selected = true;
            }
        }

        private void btnChangeDS_Click(object sender, EventArgs e)
        {
            if (lvDataSource.SelectedItems.Count > 0)
            {
                ListViewItem item = lvDataSource.SelectedItems[0];
                DataSource ds = (DataSource)(item.Tag);
                ChangeProject(ProjectConfig.Service, ds);
                item.Text = ds.ID;
            }
        }



        private void btnAddDS_Click(object sender, EventArgs e)
        {
            DataSource ds = new DataSource(txtUrl.Text, txtDBName.Text, txtUser.Text, txtPass.Text,txtDBPort.Text, txtDescription.Text);
            ProjectConfig.CurrentDataSource = ds;
            AddDataSource(ProjectConfig.Service, ds);
            lvDataSource.Items.Add(GetProjectItem(ds));
        }

        private void btnRemoveDS_Click(object sender, EventArgs e)
        {
            if (lvDataSource.SelectedItems.Count > 0)
            {
                ListViewItem item = lvDataSource.SelectedItems[0];
                DataSource ds = (DataSource)(item.Tag);

                lvDataSource.Items.Remove(item);
                RemoveDataSource(ProjectConfig.Service, ds);
            }
        }

        private void getAllTTables(DataSource source)
        {
            MySqlHelper helper = new MySqlHelper(source);
            List<List<string>> tables = helper.select("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA ='" + source.DBName + "'");
            foreach (List<string> tableName in tables)
            {
                if (tableName.Count > 0)
                {
                    txtEntity.Items.Add(tableName[0]);
                }
            }

            if (txtEntity.Items.Count > 0)
            {
                txtEntity.SelectedIndex = 0;
            }
        }

        private void lvDataSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEntity.Items.Clear();
            if (lvDataSource.SelectedItems.Count > 0)
            {
                ProjectConfig.CurrentDataSource = (DataSource)lvDataSource.SelectedItems[0].Tag;
                GetProject(ProjectConfig.CurrentDataSource);
                getAllTTables(ProjectConfig.CurrentDataSource);
            }
        }

        #endregion

        #region project

        private ListViewItem GetProjectItem(DataSource project)
        {
            ListViewItem item = new ListViewItem(project.ID);
            item.Tag = project;
            return item;
        }

        private ListViewItem GetPropertyItem(Property prop)
        {
            ListViewItem item = new ListViewItem(prop.Name);
            item.Checked = prop.enable;
            item.Tag = prop;
            return item;
        }

        private void ChangeProject(Service service, DataSource ds)
        {
            if (!changing)
            {
                ds.DBUrl = txtUrl.Text;
                ds.DBName = txtDBName.Text;
                ds.UserName = txtUser.Text;
                ds.Pass = txtPass.Text;
                ds.Port = txtDBPort.Text;
                ds.Description = txtDescription.Text;
            }
        }

        private void AddDataSource(Service service, DataSource source)
        {
            if (source == null)
            {
                return;
            }

            bool contains = false;
            foreach (DataSource ds in service.DataSourceList)
            {
                if (source.ID == ds.ID)
                {
                    contains = true;
                    break;
                }
            }
            if (!contains)
            {
                service.DataSourceList.Add(source);
            }
        }

        private void RemoveDataSource(Service service, DataSource source)
        {
            if (source == null)
            {
                return;
            }

            bool contains = false;
            foreach (DataSource ds in service.DataSourceList)
            {
                if (ds.ID == source.ID)
                {
                    contains = true;
                }
            }

            if (contains)
            {
                service.DataSourceList.Remove(source);
            }
        }

        public void SetProject(DataSource project)
        {
            project.DBUrl = txtUrl.Text;
            project.DBName = txtDBName.Text;
            project.UserName = txtUser.Text;
            project.Pass = txtPass.Text;
            project.Port = txtDBPort.Text;
            project.Description = txtDescription.Text;
        }

        public void GetProject(DataSource ds)
        {
            changing = true;
            txtUrl.Text = ds.DBUrl;
            txtDBName.Text = ds.DBName;
            txtUser.Text = ds.UserName;
            txtPass.Text = ds.Pass;
            txtDBPort.Text = ds.Port;
            txtDescription.Text = ds.Description;
            changing = false;

            foreach (Entity entity in ds.EntityList)
            {
                AddEntity(ds, entity);
            }

            lvEntity.Items.Clear();
            foreach (Entity entity in ProjectConfig.CurrentDataSource.EntityList)
            {
                ListViewItem item = GetEntityItem(entity);
                lvEntity.Items.Add(item);
            }

            if (lvEntity.Items.Count > 0)
            {
                lvEntity.Items[0].Selected = true;
            }
        }

        #endregion

        #region entity

        private void btnRemoveEntity_Click(object sender, EventArgs e)
        {
            if (ProjectConfig.CurrentDataSource != null && lvEntity.SelectedItems.Count > 0)
            {
                Entity entity = (Entity)lvEntity.SelectedItems[0].Tag;
                lvEntity.Items.Remove(lvEntity.SelectedItems[0]);
                ProjectConfig.CurrentDataSource.EntityList.Remove(entity);
            }
        }

        private void lvEntity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvEntity.SelectedItems.Count > 0)
            {
                codeControl.Enable = true;
                Entity entity = (Entity)lvEntity.SelectedItems[0].Tag;
                txtEntity.Text = entity.Name;
                SetEntitySub(entity);
                ProjectConfig.CurrentEntity = entity;
            }
            else
            {
                codeControl.Enable = false;
            }
        }

        private void AddEntity(DataSource project, Entity entity)
        {
            if (entity == null)
            {
                return;
            }
            bool contains = false;
            foreach (Entity en in project.EntityList)
            {
                if (en.Name == entity.Name)
                {
                    contains = true;
                    break;
                }
            }

            if (!contains)
            {
                project.EntityList.Add(entity);
            }
        }

        private void SetEntitySub(Entity entity)
        {
            lvProperty.Items.Clear();
            lvMethod.Items.Clear();

            for (int i = 0; i < entity.PropertyList.Count; i++)
            {
                lvProperty.Items.Add(GetPropertyItem(entity.PropertyList[i]));
            }

            for (int i = 0; i < entity.MethodList.Count; i++)
            {
                lvMethod.Items.Add(GetMethodItem(entity.MethodList[i]));
            }
        }

        private void btnAddEntity_Click(object sender, EventArgs e)
        {
            Entity entity = new Entity(txtEntity.Text.Trim(), null);

            AddEntity(ProjectConfig.CurrentDataSource, entity);

            ListViewItem item = GetEntityItem(entity);
            lvEntity.Items.Add(item);
            item.Selected = true;
        }

        private ListViewItem GetEntityItem(Entity entity)
        {
            ListViewItem item = new ListViewItem(entity.Name);
            item.Tag = entity;
            return item;
        }

        #endregion

        #region method

        private void btnAddMethod_Click(object sender, EventArgs e)
        {
            if (ProjectConfig.CurrentEntity != null)
            {
                Method method = new Method();
                method.Name = txtMethodName.Text;
                method.RequestMethod = RequestMethod.GET;
                method.DBAction = DBAction.select;
                if (rbSelelct.Checked)
                {
                    method.DBAction = DBAction.select;
                }
                else if (rbInsert.Checked)
                {
                    method.DBAction = DBAction.insert;

                }
                else if (rbUpdate.Checked)
                {
                    method.DBAction = DBAction.update;
                }
                else if (rbDelete.Checked)
                {
                    method.DBAction = DBAction.delete;
                }


                bool isList = cbList.Checked;

                method.Return = new Param("", fs.f1(ProjectConfig.CurrentEntity.Name), fs.f1(ProjectConfig.CurrentEntity.Comment), isList, Modify.NULL);

                List<Param> pList = Param.CreateParam(txtParamOut.Text);

                method.ParamList.AddRange(pList);

                method.Sql = "select * from " + fs.f4(ProjectConfig.CurrentEntity.Name);

                ProjectConfig.CurrentEntity.MethodList.Add(method);
                lvMethod.Items.Add(GetMethodItem(method));
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (ProjectConfig.CurrentEntity != null)
            {
                ProjectConfig.CurrentEntity.MethodList.Clear();
                lvMethod.Items.Clear();
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            btnSelelctAll_Click(null, null);
            btnSelelctID_Click(null, null);
            btnInsert_Click(null, null);
            btnUpdate_Click(null, null);
            btnDelete_Click(null, null);
        }

        private void btnRemoveMethod_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvMethod.SelectedItems[0];

            if (item != null)
            {
                Method currentMethod = item.Tag as Method;
                ProjectConfig.CurrentEntity.MethodList.Remove(currentMethod);
                lvMethod.Items.Remove(item);

            }
        }

        private void btnSelelctAll_Click(object sender, EventArgs e)
        {
            if (ProjectConfig.CurrentEntity != null)
            {
                Method method = ProjectConfig.CurrentEntity.SelectAllText;
                ProjectConfig.CurrentEntity.MethodList.Add(method);
                lvMethod.Items.Add(GetMethodItem(method));
            }
        }

        private void btnSelelctID_Click(object sender, EventArgs e)
        {
            if (ProjectConfig.CurrentEntity != null)
            {
                Method method = ProjectConfig.CurrentEntity.SelectIDText;
                ProjectConfig.CurrentEntity.MethodList.Add(method);
                lvMethod.Items.Add(GetMethodItem(method));
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (ProjectConfig.CurrentEntity != null)
            {
                Method method = ProjectConfig.CurrentEntity.InsertText;
                ProjectConfig.CurrentEntity.MethodList.Add(method);
                lvMethod.Items.Add(GetMethodItem(method));
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ProjectConfig.CurrentEntity != null)
            {
                Method method = ProjectConfig.CurrentEntity.DeleteText;
                ProjectConfig.CurrentEntity.MethodList.Add(method);
                lvMethod.Items.Add(GetMethodItem(method));
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ProjectConfig.CurrentEntity != null)
            {
                Method method = ProjectConfig.CurrentEntity.UpdateText;
                ProjectConfig.CurrentEntity.MethodList.Add(method);
                lvMethod.Items.Add(GetMethodItem(method));
            }
        }

        private ListViewItem GetMethodItem(Method method)
        {
            ListViewItem item = new ListViewItem(method.Name);
            item.Tag = method;
            return item;
        }

        #endregion

        #region property

        private void lvProperty_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            Property pro = (Property)e.Item.Tag;
            pro.enable = e.Item.Checked;
        }

        private void chEnable_CheckedChanged(object sender, EventArgs e)
        {
            bool enable = chEnable.Checked;

            foreach (ListViewItem item in lvProperty.Items)
            {
                item.Checked = enable;
            }
        }

        #endregion

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            ProjectConfig.Service.Name = txtName.Text;
        }

        private void txtPort_TextChanged(object sender, EventArgs e)
        {
            ProjectConfig.Service.Port = txtPort.Text;
        }

        private void txtVersion_TextChanged(object sender, EventArgs e)
        {
            ProjectConfig.Service.Version = txtVersion.Text;
        }

        private void txtDomainName_TextChanged(object sender, EventArgs e)
        {
            ProjectConfig.Service.DomainName = txtDomainName.Text;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            if (lvDataSource.SelectedItems.Count > 0)
            {
                ListViewItem item = lvDataSource.SelectedItems[0];
                DataSource ds = (DataSource)(item.Tag);
                ChangeProject(ProjectConfig.Service, ds);
                item.Text = ds.ID;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
