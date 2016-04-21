using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace SpringBootCodeFactory.code.view
{
    public partial class MessageDialog : MetroForm
    {
        public MessageDialog()
        {
            InitializeComponent();
        }

        public void ShowDialog(string title, string content)
        {
            this.Text = title;
            txtContent.Text = content;
            this.ShowDialog();
        }
    }
}
