using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpringBootCodeFactory.code.entity
{
    public static class fs
    {
        private static string f0(string text)//所有格式都格式化为下划线形式
        {
            if (text == null || text.Length == 0)
            {
                return "";
            }
            if (text.IndexOf("_") > 0)
            {
                return text.ToLower();
            }
            else
            {
                StringBuilder builder = new StringBuilder();
                builder.Append(char.ToLower(text[0])); ;

                for (int i = 1; i < text.Length; i++)
                {
                    char ch = text[i];
                    if (char.IsUpper(ch))
                    {
                        builder.Append("_");
                        builder.Append(char.ToLower(ch));
                    }
                    else
                    {
                        builder.Append(ch);
                    }
                }
                return builder.ToString();
            }

        }

        public static string f1(string text)//大写驼峰
        {
            text = f0(text);
            if (text == null || text.Trim() == "")
                return "";
            string[] texts = text.Split('_');
            text = "";

            for (int i = 0; i < texts.Length; i++)
            {
                text += (texts[i].Substring(0, 1).ToUpper() + texts[i].Substring(1));
            }

            return text;
        }

        public static string f2(string text)//小写驼峰
        {
            text = f0(text);
            if (text == null || text.Trim() == "")
                return "";
            string[] texts = text.Split('_');
            text = "";
            text += texts[0].ToLower();
            for (int i = 1; i < texts.Length; i++)
            {
                text += (texts[i].Substring(0, 1).ToUpper() + texts[i].Substring(1));
            }

            return text;
        }

        public static string f3(string text)//大写下划线
        {
            text = f0(text);
            if (text == null || text.Trim() == "")
                return "";
            return text.ToUpper();
        }

        public static string f4(string text)//小写下划线
        {
            text = f0(text);
            if (text == null || text.Trim() == "")
                return "";
            return text;
        }

        public static string f5(string text)//中线
        {
            text = f0(text);
            if (text == null || text.Trim() == "")
                return "";
            return text.Replace("_", "-").ToLower();
        }
    }
}
