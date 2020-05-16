<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 44%;
            height: 214px;
            background-color: #CCFF66;
        }
        .auto-style2 {
            text-align: center;
            background-color: #FFFF99;
        }
        .auto-style3 {
            width: 321px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Send Mail Demo By JD"></asp:Label>
        <br />
        <br />
        <table border="1" class="auto-style1">
            <tr>
                <td class="auto-style2">Your Name</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox1" runat="server" Height="29px" Width="199px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Email Address</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox2" runat="server" Height="29px" Width="199px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="2">
                    <asp:Button ID="Button1" runat="server" Height="33px" OnClick="Button1_Click" style="background-color: #CCFF66" Text="Submit" Width="88px" />
                    <br />
                    <br />
                    <asp:Label ID="Label2" runat="server"></asp:Label>
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
