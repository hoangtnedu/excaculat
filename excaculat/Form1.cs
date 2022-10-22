using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace excaculat
{
    public partial class Form1 : Form
    {
        string ketqua = "0";
        public Form1()
        {
            InitializeComponent();
            Display();
        }

        void Display()
        {
            txtKetqua.Text = ketqua;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (ketqua=="0")
            {
                ketqua = "1";               
            }
            else
            ketqua += "1";
            Display();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (ketqua == "0")
            {
                ketqua = "2";               
            }
            else
            ketqua += "2";
            Display();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (ketqua == "0")
            {
  
            }
            else
            ketqua += "0";
            Display();
        }
    }
}
