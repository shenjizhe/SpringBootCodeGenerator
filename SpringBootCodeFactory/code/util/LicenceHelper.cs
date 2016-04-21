using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Reflection;
using System.IO;
using SpringBootCodeFactory.code.util;

namespace common.code.register
{
    public static class LicenceHelper
    {
        public const string LicenceFile = "licence";

        public static string ReadLicenceFile()
        {
            StreamReader sr = new StreamReader(System.AppDomain.CurrentDomain.BaseDirectory + LicenceFile);
            String line;
            string text = "";
            while ((line = sr.ReadLine()) != null)
            {
                text += line;
            }
            return text;
        }

        public static void WriteLicenceFile(string text)
        {
            FileStream fs = new FileStream(System.AppDomain.CurrentDomain.BaseDirectory + LicenceFile, FileMode.Create);
            byte[] data = System.Text.Encoding.UTF8.GetBytes(text);
            fs.Write(data, 0, data.Length);
            fs.Flush();
            fs.Close();
        }



        private static string GetResource(string resourceName)
        {
            return SpringBootCodeFactory.resource.StringResouce.ResourceManager.GetString(resourceName);
        }

        /// <summary>
        /// 生成计算机码
        /// </summary>
        /// <returns></returns>
        public static string GenerationCode()
        {
            string text = PCUtil.GetCPUID();
            text += PCUtil.GetMacAddress();
            text += PCUtil.GetSystemType();

            byte[] b = Encoding.UTF8.GetBytes(text);

            SHA256 sh = SHA256.Create();
            byte[] bytes = sh.ComputeHash(b);

            string base64string = Convert.ToBase64String(bytes);
            return base64string;
        }

        /// <summary>
        /// 用计算机码生成证书
        /// </summary>
        /// <param name="privatekey"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public static string GenerationCertificate(string code)
        {
            string privatekey = GetResource("privatekey");
            byte[] messagebytes = Encoding.UTF8.GetBytes(code);
            //私钥签名  
            RSACryptoServiceProvider oRSA3 = new RSACryptoServiceProvider();
            oRSA3.FromXmlString(privatekey);
            byte[] AOutput = oRSA3.SignData(messagebytes, "SHA1");
            return Convert.ToBase64String(AOutput);
        }

        /// <summary>
        /// 校验证书
        /// </summary>
        /// <param name="publickey"></param>
        /// <param name="code"></param>
        /// <param name="certificate"></param>
        /// <returns></returns>
        public static bool VerifyCertificate(string certificate)
        {
            string code = GenerationCode();
            string publickey = GetResource("publickey");
            byte[] messagebytes = Encoding.UTF8.GetBytes(code);

            //公钥验证  
            RSACryptoServiceProvider oRSA4 = new RSACryptoServiceProvider();
            oRSA4.FromXmlString(publickey);

            byte[] bt = Convert.FromBase64String(certificate);

            bool bVerify = oRSA4.VerifyData(messagebytes, "SHA1", bt);
            return bVerify;
        }
    }
}
