using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Diagnostics;
using SpringBootCodeFactory.code.util;
using System.IO;

namespace QuickCommand
{
    public class CommandComparer : IComparer<Command>
    {
        public int Compare(Command x, Command y)
        {
            if (x == null || y == null)
            {
                return 0;
            }
            return x.CompareTo(y);
        }
    }

    public enum CommandType
    {
        Start,
        Kill,
    }

    [Serializable]
    public class Command : IComparable, ICloneable
    {
        private static CommandComparer comparer;

        public static IComparer<Command> Comparer
        {
            get
            {
                return comparer;
            }
        }

        static Command()
        {
            comparer = new CommandComparer();
        }

        [XmlAttribute]
        public string Name;

        [XmlAttribute]
        public string FullPath { get; set; }

        [XmlAttribute]
        public string ParamText { get; set; }

        [XmlAttribute]
        public CommandType RunType { get; set; }

        [XmlAttribute]
        public string WorkPath { get; set; }

        public Command()
        {

        }

        public Command(string name, string path, string param, CommandType type)
        {
            this.Name = name;
            this.FullPath = path;
            this.ParamText = param;
            this.RunType = type;
            this.WorkPath = Path.GetDirectoryName(path);
        }

        public Command(string name,string workPath, string path, string param, CommandType type)
        {
            this.Name = name;
            this.FullPath = path;
            this.ParamText = param;
            this.RunType = type;
            this.WorkPath = workPath;
        }

        public override string ToString()
        {
            return Name;
        }

        private const string CommandFilePath = "qcmd.xml";
        private const string SerialListCommandFileName = "command_serial.xml";

        public static void Save(List<Command> list)
        {
            XmlHelper<List<Command>>.Write(list, CommandFilePath);
        }

        public static bool Excute(List<Command> allCommand, List<string> commandNameList)
        {
            List<string> errList = new List<string>();
            bool success = false;
            for (int i = 0; i < commandNameList.Count; i++)
            {
                try
                {
                    success = Excute(allCommand, commandNameList[i]);
                }
                catch
                {
                    success = false;
                }
                if (!success)
                {
                    errList.Add(commandNameList[i]);
                }
            }

            if (errList.Count == 0)
            {
                return true;
            }
            else
            {
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < errList.Count; i++)
                {
                    builder.Append("[" + (i + 1).ToString() + "." + errList[i] + "]");
                }
                throw new Exception("命令：" + builder.ToString() + "执行失败，请检查命令是否存在！");
            }
        }

        public static bool Excute(List<Command> commandList, string cmdName)
        {
            foreach (Command cmd in commandList)
            {
                if (cmd.Name == cmdName)
                {
                    return Excute(cmd);
                }
            }

            throw new ArgumentException("没有找到，命令:" + cmdName);
        }

        public static bool Excute(Command cmd)
        {
            if (cmd.RunType == CommandType.Start)
            {
                Process myProcess = new Process();
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = cmd.FullPath;
                myProcess.StartInfo.Arguments = cmd.ParamText;
                myProcess.StartInfo.WorkingDirectory = cmd.WorkPath;
                return myProcess.Start();
            }
            else if (cmd.RunType == CommandType.Kill)
            {
                Process[] processes = Process.GetProcessesByName(cmd.FullPath);

                if (processes != null)
                {
                    for (int i = 0; i < processes.Length; i++)
                    {
                        processes[i].Kill();
                    }
                }

                return true;
            }
            else
            {
                return true;
            }
        }

        public static List<string> LoadSerialList()
        {
            return XmlHelper<List<string>>.Read(SerialListCommandFileName);
        }

        public static void SaveSerialList(List<string> list)
        {
            XmlHelper<List<string>>.Write(list, SerialListCommandFileName);
        }

        public static List<Command> Load()
        {
            return XmlHelper<List<Command>>.Read(CommandFilePath);
        }

        public static List<Command> GetCommandByName(List<Command> commandList, string param)
        {
            List<Command> list = new List<Command>();
            if (param.Trim() != "" && commandList != null)
            {
                for (int i = 0; i < commandList.Count; i++)
                {
                    if (commandList[i].Name.Trim().ToLower().StartsWith(param.Trim().ToLower()))
                    {
                        list.Add(commandList[i]);
                    }
                }
            }

            return list;
        }

        public int CompareTo(object obj)
        {
            Command cmd = obj as Command;

            return Name.CompareTo(cmd.Name);
        }

        public object Clone()
        {
            return new Command(Name, FullPath, ParamText, RunType);
        }
    }
}
