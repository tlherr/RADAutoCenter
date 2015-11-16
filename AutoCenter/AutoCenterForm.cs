using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCenter
{
    public partial class AutoCenterForm : Form
    {
        PackageFactory pkgFactory = new PackageFactory();

        public AutoCenterForm()
        {
            InitializeComponent();
        }

        private void packageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            packageTextBox.Text = String.Empty;
            ComboBox comboBox = (ComboBox)sender;

            string[][] data = this.pkgFactory.getPackage(comboBox.SelectedItem.ToString(), null);

            //Consume the arrays provided

            for(int x = 0; x < data[0].Length; x++)
            {
                if(x==0 && x!=data[0].Length-1)
                {
                    packageTextBox.Text += data[0][x] + ",";
                } else if(x == data[0].Length-1)
                {
                    packageTextBox.Text += " " + data[0][x];
                }
                else
                {
                    packageTextBox.Text += " " + data[0][x] + ",";
                }
            }

        }
    }
}
