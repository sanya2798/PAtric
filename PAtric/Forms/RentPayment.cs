using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAtric
{
    public partial class RentPayment : Form
    {

        OpenFileDialog ofd = new OpenFileDialog();
        public RentPayment()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void CheckFL()
        {
            if (radioButtonСash.Checked == true)
            {
                buttonSelectFile.Enabled = true;
                textBoxPath.Enabled = true;
                buttonPrintOrder.Enabled = true;
                buttonPayment.Enabled = false;
            }
            else
            {
                buttonSelectFile.Enabled = false;
                textBoxPath.Enabled = false;
                buttonPrintOrder.Enabled = false;
                buttonPayment.Enabled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ofd.Title = "Open Text File";
            ofd.Filter = "TXT files|*.txt";
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileName = ofd.FileName;
                Console.WriteLine(fileName);
                textBoxPath.Text = fileName;
                //string filePath = System.IO.Path.GetDirectoryName(ofd.FileName);

                //Console.WriteLine(filePath);
            }
            buttonPayment.Enabled = true;
        }

        private void radioButtonFL_CheckedChanged(object sender, EventArgs e)
        {
            CheckFL();
        }

        private void radioButtonUL_CheckedChanged(object sender, EventArgs e)
        {
            CheckFL();
        }

        private void buttonPrintOrder_Click(object sender, EventArgs e)
        {
            
        }
    }
}
