using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SpringBootCodeFactory.code.entity;
using SpringBootCodeFactory.code.logic;
using MetroFramework.Controls;

namespace SpringBootCodeFactory.code.view
{
    public partial class CodeControl : MetroUserControl
    {
        private bool enable;
        public bool Enable
        {
            get
            {
                return enable;
            }
            set
            {
                enable = value;
                btnConfig.Enabled = enable;
                btnControl.Enabled = enable;
                btnEntity.Enabled = enable;
                btnMapper.Enabled = enable;
                btnMarkDown.Enabled = enable;
                btnMybatis.Enabled = enable;
                btnProperty.Enabled = enable;
                btnService.Enabled = enable;
                btnSummary.Enabled = enable;
                btnXml.Enabled = enable;
            }
        }
        public CodeControl()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            btnEntity.Tag = new EntityFactory();
            btnMapper.Tag = new MapperFactory();
            btnService.Tag = new ServiceFactory();
            btnXml.Tag = new XmlFactory();
            btnControl.Tag = new ControllerFactory();
            btnProperty.Tag = new YmlFactory();
            btnConfig.Tag = new ConfigFactory();
            btnMybatis.Tag = new MyBatisFactory();
            btnMarkDown.Tag = new MarkdownFactory();
            btnSummary.Tag = new MarkdownSummaryFactory();
        }

        private void factory_click(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (ProjectConfig.CurrentEntity == null)
            {
                return;
            }

            if (control.Tag is IFactory<Entity>)
            {
                IFactory<Entity> factory = control.Tag as IFactory<Entity>;
                if (ProjectConfig.CurrentEntity != null)
                {
                    txtFactory.Text = factory.Create(ProjectConfig.CurrentEntity);
                }
            }
            else if (control.Tag is IFactory<DataSource, Entity>)
            {
                IFactory<DataSource, Entity> factory = control.Tag as IFactory<DataSource, Entity>;
                txtFactory.Text = factory.Create(ProjectConfig.CurrentDataSource, ProjectConfig.CurrentEntity);
            }
            else
            {
                IFactory<Service> factory = control.Tag as IFactory<Service>;
                txtFactory.Text = factory.Create(ProjectConfig.Service);
            }
        }
    }
}
