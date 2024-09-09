<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wed_v2.aspx.cs" Inherits="wed_v2_giaiptb2.wed_v2" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Chương trình giải ptb2_v2</title>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="apple-mobile-web-app-capable" content="yes" />
    <meta name="mobile-web-app-capable" content="yes" />
    <script src="jquery.js"></script>
    <script src="wed_vs.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <h2 style="color:green">CHƯƠNG TRÌNH GIẢI PHƯƠNG TRÌNH BẬC 2_V2</h2>
        <h3>ax² + bx + c = 0</h3>

        <label for="tb_nhapa">Nhập hệ số a:</label>
        <input type="text" id="tb_nhapa" />
        <br /><br />

        <label for="tb_nhapb">Nhập hệ số b:</label>
        <input type="text" id="tb_nhapb" />
        <br /><br />

        <label for="tb_nhapc">Nhập hệ số c:</label>
        <input type="text" id="tb_nhapc" />
        <br /><br />

        <button type="button" id="btn_tinh">Tính</button>
        <br /><br />

        <label id="kq" style="font-weight:bold; color:blue;"></label>
    </form>
</body>
</html>
