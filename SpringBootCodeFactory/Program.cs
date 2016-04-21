using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using common.code.register;
using SpringBootCodeFactory.code.view;

namespace SpringBootCodeFactory
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool success = false;
            try
            {
                string certification = LicenceHelper.ReadLicenceFile();
                success = LicenceHelper.VerifyCertificate(certification);
                if (success)
                {
                    run();
                }
            }
            catch (Exception ex)
            {

            }
            if (!success)
            {
                MessageDialog dialog = new MessageDialog();
                string code = LicenceHelper.GenerationCode();
                dialog.ShowDialog("请申请注册文件(thirdlucky@126.com)", code);
            }
        }

        private static void run()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormCodeTool());
        }
    }
}
