# Xây dựng Chương Trình Giải Phương Trình Bậc 2
1. Dùng ngôn ngữ C# xây dựng chương trình console
![image](https://github.com/user-attachments/assets/f09daf2b-8e51-41c6-a238-1898023d6d9a)

2. Xây dựng thư viện lib_giaiptb2
```C#
using System;

namespace lib_giaiptb2
{
    public class giaiptb2
    {
        public static string GiaiPTB2(float a, float b, float c)
        {
            float delta = b * b - 4 * a * c;
            if (a == 0) { return "day khong phai ptb2"; }
            if (delta < 0)
            {
                return "Phuong trinh vo nghiem";
            }
            else if (delta == 0)
            {
                float nghiemKep = -b / (2 * a);
                nghiemKep = (float)((int)(nghiemKep * 100)) / 100;
                return $"Phuong trinh co mot nghiem khep: x1 = x2 = {nghiemKep}";
            }
            else
            {
                float x1 = (float)((int)((-b + Math.Sqrt(delta)) / (2 * a) * 100)) / 100;
                float x2 = (float)((int)((-b - Math.Sqrt(delta)) / (2 * a) * 100)) / 100;
                return $"Phuong trinh co 2 nghiem phan biet: x1 = {x1}, x2 = {x2}";
            }
        }
    }
}

```
3. Chương trình console sử dụng thư viện lib_giaiptb2
![image](https://github.com/user-attachments/assets/fddf95ff-df46-4d8a-99b9-212b32218543)

![image](https://github.com/user-attachments/assets/402d42ff-7f79-470e-9720-86018bc983cc)

4. Chương trình winform sử dụng lin_giaiptb2
```C#
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
```
![image](https://github.com/user-attachments/assets/4a4c039f-e637-4b5b-8370-1dea770f10aa)

5. Xây dựng wed_v1 sử dụng thư viện lib_giaiptb2
```html
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="giaiptb2.aspx.cs" Inherits="wedv1_giaiptb2.giaiptb2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Chương trình giải ptb2</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2 style ="color:red">CHƯƠNG TRÌNH GIẢI PHƯƠNG TRÌNH BẬC 2</h2>
        <h3>ax2+bx+c=0</h3>
        <h4 style ="color:deeppink">___Tác Giả: Nguyễn Tuấn Anh___</h4>
        <asp:Label ID="label" runat="server" Text="Nhập hệ số a:"></asp:Label>
        <asp:TextBox ID="tb_nhapa" runat="server"></asp:TextBox>
        <br />  <br />
        <asp:Label ID="label1" runat="server" Text="Nhập hệ số b:"></asp:Label>
        <asp:TextBox ID="tb_nhapb" runat="server"></asp:TextBox>
        <br />  <br />
        <asp:Label ID="label2" runat="server" Text="Nhập hệ số c:"></asp:Label>
        <asp:TextBox ID="tb_nhapc" runat="server"></asp:TextBox>
        <br />  <br />
        <asp:Button ID="btn_tinh" runat="server" Text="Tính" OnClick="btn_tinh_Click" />
        <br />  <br />
        <asp:Label ID="kq" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
```
Xử lý nút bấm
```C#
using System;

namespace BaiToanGiaiPTB2
{
    internal class Program
    {
        static void giaiPTb2(float a, float b, float c)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
                else
                {
                    Console.WriteLine("Phuong trinh co 1 nghiem: x = {0}", (-c / 2*a));
                }
                return;
            }
            float delta = b * b - 4 * a * c;
            float x1, x2;
            if (delta > 0)
            {
                x1 = (float)(-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (float)(-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Phuong trinh co 2 nghiem la: x1 = {0}, x2 = {1}", x1, x2);
            }
            else if (delta == 0)
            {
                x1 = (-b / (2 * a));
                Console.WriteLine("Phuong trinh co 1 nghiem kep x1 = x2 = {0}", x1);
            }
            else
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Nhap he so a: ");
                float a = float.Parse(Console.ReadLine());
                Console.Write("Nhap he so b: ");
                float b = float.Parse(Console.ReadLine());
                Console.Write("Nhap he so c: ");
                float c = float.Parse(Console.ReadLine());

                giaiPTb2(a, b, c);
            }
            catch (FormatException)
            {
                Console.WriteLine("Gia tri nhap khong hop le. Vui long nhap so thuc.");
            }
            Console.ReadLine();
        }
    }
}
```
Kết quả:
![image](https://github.com/user-attachments/assets/0d1fbf4f-b7d6-4e43-b408-165b3bc4c7b0)
-------------------
Khi a=0, đây không phải ptb2
![image](https://github.com/user-attachments/assets/9b1a6c4c-4e13-4593-93fd-78d86f51e211)
-------------------
Khi nhập thiếu hoặc sai dữ liệu:
![image](https://github.com/user-attachments/assets/9c6654e7-97b6-4324-9025-a70be38f74dd)
-------------------
6. Xây dựng wed_v2 sử dụng js

   
