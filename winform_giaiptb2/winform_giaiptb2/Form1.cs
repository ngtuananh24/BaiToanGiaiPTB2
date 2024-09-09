using lib_giaiptb2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace winform_giaiptb2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_tim_Click(object sender, EventArgs e)
        {
            float a, b, c;
            string vala = tb_nhapa.Text;
            string valb = tb_nhapb.Text;
            string valc = tb_nhapc.Text;

            if (!float.TryParse(vala, out a))
            {
                MessageBox.Show("Giá trị của a không hợp lệ.");
                return;
            }
            if (!float.TryParse(valb, out b))
            {
                MessageBox.Show("Giá trị của b không hợp lệ.");
                return;
            }
            if (!float.TryParse(valc, out c))
            {
                MessageBox.Show("Giá trị của c không hợp lệ.");
                return;
            }

            string ketqua = giaiptb2.GiaiPTB2(a, b, c);
            kq.Text = ketqua; 
        }
    }
}
