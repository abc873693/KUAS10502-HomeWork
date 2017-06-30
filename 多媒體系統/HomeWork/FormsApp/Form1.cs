using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RV.API;
using RV;
using RV.Databases;
using System.IO;

namespace FormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setDBFilePath();
            var db = new PostalDbContext();
            var postals = db.PostalTable.ToList();
            foreach (var potal in postals)
            {

                richTextBox1.AppendText(potal.Section + "\n");
            }
        }

        static void setDBFilePath()
        {
            var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string relative = @"..\..\App_Data\";
            //string relative = @"..\..\..\Web\App_Data\";
            string absolute = Path.GetFullPath(Path.Combine(baseDirectory, relative));
            AppDomain.CurrentDomain.SetData("DataDirectory", absolute);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
