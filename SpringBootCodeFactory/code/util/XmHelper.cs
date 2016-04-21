
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
namespace SpringBootCodeFactory.code.util
{
    public class XmlHelper<T>
    {
        private static Encoding encoding = Encoding.UTF8;

        public static void CancleReadOnly(string fileName)
        {
            if (File.Exists(fileName))
            {
                FileInfo info = new FileInfo(fileName);
                if (info.Attributes.ToString().IndexOf("ReadOnly") != -1)
                {
                    info.Attributes = FileAttributes.Normal;
                }
            }
        }

        public static T SetXmlText(string xmlText)
        {
            Stream stream = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));

                stream = new MemoryStream(encoding.GetBytes(xmlText));
                return (T)serializer.Deserialize(stream);
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }
            }
        }

        public static string GetXmlText(T o)
        {
            MemoryStream stream = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                stream = new MemoryStream();
                serializer.Serialize(stream, o);
                return encoding.GetString(stream.ToArray());
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }
            }
        }

        public static T Read(Stream stream)
        {
            StreamReader textReader = null;
            object obj3;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                textReader = new StreamReader(stream, Encoding.Unicode);
                obj3 = serializer.Deserialize(textReader);
            }
            catch (Exception)
            {
                obj3 = null;
            }
            finally
            {
                if (textReader != null)
                {
                    textReader.Close();
                }
            }
            return (T)obj3;
        }

        public static T Read(string fileName)
        {
            StreamReader textReader = null;
            object obj3;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                textReader = new StreamReader(fileName, Encoding.Unicode);
                obj3 = serializer.Deserialize(textReader);
            }
            catch (Exception ex)
            {
                obj3 = ex;
            }
            finally
            {
                if (textReader != null)
                {
                    textReader.Close();
                }
            }
            return (T)obj3;
        }

        public static void Write(T o, string fileName)
        {
            CancleReadOnly(fileName);
            XmlSerializer serializer = null;
            try
            {
                serializer = new XmlSerializer(typeof(T));
            }
            catch (Exception exception)
            {
                string message = exception.Message;
            }
            using (FileStream stream = new FileStream(fileName, FileMode.Create))
            {
                XmlTextWriter writer = null;
                try
                {
                    writer = new XmlTextWriter(stream, Encoding.Unicode);
                    serializer.Serialize((XmlWriter)writer, o);
                }
                finally
                {
                    if (writer != null)
                    {
                        writer.Close();
                    }
                }
            }
        }
    }
}
