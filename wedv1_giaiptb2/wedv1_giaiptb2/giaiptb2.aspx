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
