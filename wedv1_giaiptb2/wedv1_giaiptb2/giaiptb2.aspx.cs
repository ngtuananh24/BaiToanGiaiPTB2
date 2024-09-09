using System;
using lib_giaiptb2; 

namespace wedv1_giaiptb2
{
    public partial class giaiptb2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void btn_tinh_Click(object sender, EventArgs e)
        {
            float a, b, c;

            string vala = tb_nhapa.Text;
            string valb = tb_nhapb.Text;
            string valc = tb_nhapc.Text;

            if (!float.TryParse(vala, out a))
            {
                kq.Text = "Tu tu, Xem lai he so a!";
                return;
            }
            if (!float.TryParse(valb, out b))
            {
                kq.Text = "Tu tu, Xem lai he so b!";
                return;
            }
            if (!float.TryParse(valc, out c))
            {
                kq.Text = "Tu tu, Xem lai he so c!";
                return;
            }

            string ketqua = lib_giaiptb2.giaiptb2.GiaiPTB2(a, b, c);
            kq.Text = ketqua;
        }
    }
}
