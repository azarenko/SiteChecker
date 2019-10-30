using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SiteChecker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataSet.WriteXml("data.xml");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("data.xml"))
            {
                dataSet.ReadXml("data.xml");
            }
        }
    }
}
