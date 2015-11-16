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


            //Simulate a click on the fragrance box to make it update
            if(fragranceComboBox.SelectedItem!=null)
            {
                fragranceComboBox_SelectedIndexChanged(fragranceComboBox, e);
            }
        }

        private void fragranceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fragranceTextBox.Text = String.Empty;
            ComboBox comboBox = (ComboBox)sender;

            string[][] data = this.pkgFactory.getPackage(packageComboBox.SelectedItem.ToString(), comboBox.SelectedItem.ToString());

            //Consume the arrays provided

            for (int x = 0; x < data[1].Length; x++)
            {
                if (x == 0 && x != data[1].Length - 1)
                {
                    fragranceTextBox.Text += data[1][x] + ",";
                }
                else if (x == data[1].Length - 1)
                {
                    fragranceTextBox.Text += " " + data[1][x];
                }
                else
                {
                    fragranceTextBox.Text += " " + data[1][x] + ",";
                }
            }
        }
    }
}
