using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpringBootCodeFactory.code.entity;
using System.IO;

namespace SpringBootCodeFactory.code.logic
{
    public class ServiceManager
    {
        private const string RootPath = "root";
        private const string ProjectPath = "club";
        private JavaPackageFactory factory;
        private Service service;
        private string source;
        private string destination;
        private bool overrided;

        public void GenerationProject(Service service, string source, string destination, bool overrided)
        {
            this.service = service;
            this.source = source;
            this.destination = destination;
            this.overrided = overrided;

            factory = new JavaPackageFactory(service);

            WriteAllFolder(source, destination, overrided);

            WriteTemple(destination, overrided);

            WriteMarkDown(destination, overrided);
        }

        private void WriteMarkDown(string destination, bool overrided)
        {
            string destResource = destination + "\\books\\";

            // summery
            IFactory<Entity> efac = null;
            IFactory<Service> fac = new MarkdownSummaryFactory();
            string fileLine = fac.Create(service);
            string name = destResource + "SUMMARY.md";
            WriteFile(name, fileLine.Split('\n'), overrided);

            for (int i = 0; i < service.DataSourceList.Count; i++)
            {
                DataSource ds = service.DataSourceList[i];
                for (int j = 0; j < ds.EntityList.Count; j++)
                {
                    Entity entity = ds.EntityList[j];

                    // markdownEntity
                    efac = new MarkdownFactory();
                    fileLine = efac.Create(entity);
                    name = destResource + "\\" + ds.DBName + "\\" + entity.Name + ".md";
                    WriteFile(name, fileLine.Split('\n'), true);
                }
            }
        }

        private void WriteTemple(string destination, bool overrided)
        {
            string dest = destination + "\\src\\main\\java\\com\\ninehcom\\" + service.Name;
            string destResource = destination + "\\src\\main\\resources\\sqlxml\\";

            // properties
            IFactory<Service> fac = new YmlFactory();
            string fileLine = fac.Create(service);
            string name = destination + "\\src\\main\\resources\\application.yml";
            WriteFile(name, fileLine.Split('\n'), overrided);

            // config
            fac = new ConfigFactory();
            fileLine = fac.Create(service);
            name = dest + "\\conf\\DataBaseConfiguration.java";
            WriteFile(name, fileLine.Split('\n'), true);

            // sql map
            fac = new SqlMapFactory();
            fileLine = fac.Create(service);
            name = dest + "\\conf\\SqlMap.java";
            name = dest + "\\service\\SqlMap.java";
            WriteFile(name, fileLine.Split('\n'), true);

            // mabatis
            fac = new MyBatisFactory();
            fileLine = fac.Create(service);
            name = dest + "\\conf\\MyBatisConfiguration.java";
            WriteFile(name, fileLine.Split('\n'), true);

            foreach (DataSource source in service.DataSourceList)
            {
                for (int i = 0; i < source.EntityList.Count; i++)
                {
                    Entity entity = source.EntityList[i];
                    // controllers
                    IFactory<Entity> factory = new ControllerFactory();
                    IFactory<DataSource, Entity> factory2 = null;

                    fileLine = factory.Create(entity);
                    name = dest + "\\controller\\" + fs.f1(entity.Name) + "Controller.java";
                    WriteFile(name, fileLine.Split('\n'), overrided);

                    // service
                    factory = new ServiceFactory();
                    fileLine = factory.Create(entity);
                    name = dest + "\\service\\" + fs.f1(entity.Name) + "Service.java";
                    WriteFile(name, fileLine.Split('\n'), overrided);

                    // mapper
                    factory2 = new MapperFactory();
                    fileLine = factory2.Create(source, entity);
                    name = dest + "\\mapper\\" + fs.f1(entity.Name) + "Mapper.java";
                    WriteFile(name, fileLine.Split('\n'), overrided);

                    // entity
                    factory = new EntityFactory();
                    fileLine = factory.Create(entity);
                    name = dest + "\\entity\\" + fs.f1(entity.Name) + ".java";
                    WriteFile(name, fileLine.Split('\n'), overrided);

                    // xml
                    factory = new XmlFactory();
                    fileLine = factory.Create(entity);
                    name = destResource + fs.f1(entity.Name) + "Mapper.xml";
                    WriteFile(name, fileLine.Split('\n'), overrided);
                }
            }
        }

        private void WriteFile(string des, string[] lines)
        {
            DirectoryInfo info = Directory.GetParent(des);
            Directory.CreateDirectory(info.FullName);

            if (!File.Exists(des) || overrided)
            {
                File.WriteAllLines(des, lines);
            }
        }

        private void WriteFile(string des, string[] lines, bool override_sub)
        {
            DirectoryInfo info = Directory.GetParent(des);
            Directory.CreateDirectory(info.FullName);

            if (!File.Exists(des) || overrided || override_sub)
            {
                File.WriteAllLines(des, lines);
            }
        }

        private void WriteAllFolder(string source, string destination, bool overrided)
        {
            string[] files = Directory.GetFiles(source, "*.*", SearchOption.AllDirectories);
            if (files != null)
            {
                for (int i = 0; i < files.Length; i++)
                {
                    String[] lines = factory.Format(File.ReadAllLines(files[i], Encoding.UTF8), "authority");
                    string des = files[i].Replace(source, destination).Replace("authority", service.Name);
                    WriteFile(des, lines, overrided);
                }
            }
        }
    }
}
