using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int a, b, ketQua;
            a = int.Parse(txtSo1.Text);
            b = int.Parse(txtSo2.Text);
            Calculator1 c = new Calculator1(a,b);
            ketQua = c.Exectute("+");
            txtKQ.Text = ketQua.ToString();
        }
    }
}
