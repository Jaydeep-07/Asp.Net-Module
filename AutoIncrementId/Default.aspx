<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AutoIncrementId.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 58%;
            height: 547px;
            background-color: #FFFF66;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style3 {
            width: 278px;
            height: 111px;
        }
        .auto-style4 {
            height: 111px;
        }
        .auto-style5 {
            height: 72px;
        }
        .auto-style6 {
            height: 86px;
        }
        .auto-style7 {
            height: 102px;
        }
        .auto-style8 {
            height: 95px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Auto Increment Demo"></asp:Label>
        <br />
        <table border="1" class="auto-style1">
            <tr>
                <td class="auto-style6">ID No</td>
                <td class="auto-style6">
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Roll No</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox1" runat="server" Height="30px" Width="201px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">Student Name</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TextBox2" runat="server" Height="30px" Width="201px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">Father Name</td>
                <td class="auto-style7">
                    <asp:TextBox ID="TextBox3" runat="server" Height="30px" Width="201px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Contact</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox4" runat="server" Height="30px" Width="201px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="2">
                    <asp:Button ID="Button1" runat="server" Height="31px" OnClick="Button1_Click" style="background-color: #99FF33" Text="Add New" Width="92px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Height="31px" OnClick="Button2_Click" style="background-color: #99FF33" Text="Save" Width="92px" />
                    <br />
                    <br />
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
