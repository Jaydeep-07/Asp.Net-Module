<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 49%;
            height: 104px;
            background-color: #CCFF99;
        }
        .auto-style3 {
            height: 51px;
            width: 428px;
        }
        .auto-style4 {
            width: 692px;
            height: 51px;
        }
        .auto-style5 {
            height: 56px;
            width: 428px;
        }
        .auto-style6 {
            width: 692px;
            height: 56px;
        }
        .auto-style7 {
            width: 8%;
            height: 139px;
            margin-right: 0px;
            background-color: #66FF99;
        }
        .auto-style8 {
            width: 106px;
        }
        .auto-style9 {
            width: 21px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Movie Ticket Booking Website Demo"></asp:Label>
        <br />
        <br />
        Live Concert : Arjit Singh - 20 th may 2020<br />
        Free Of Cost: Only 12 seats are available (first come first serve)<br />
        <table border="1" class="auto-style1">
            <tr>
                <td class="auto-style3">Your Name</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox1" runat="server" Width="238px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Mobile Number</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox2" runat="server" Width="238px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Select Your Seat Here Only One Seat Book At Time"></asp:Label>
        <br />
        <br />
        <table border="2" class="auto-style7">
            <tr>
                <td class="auto-style8">
                    <asp:Button ID="Button1" runat="server" BorderStyle="Double" Height="50px" OnClick="Button1_Click" Text="1" Width="50px" />
                </td>
                <td>
                    <asp:Button ID="Button2" runat="server" BorderStyle="Double" Height="50px" OnClick="Button2_Click" Text="2" Width="50px" />
                </td>
                <td>
                    <asp:Button ID="Button3" runat="server" BorderStyle="Double" Height="50px" OnClick="Button3_Click" Text="3" Width="50px" />
                </td>
                <td class="auto-style9">
                    <asp:Button ID="Button4" runat="server" BorderStyle="Double" Height="50px" OnClick="Button4_Click" Text="4" Width="50px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:Button ID="Button5" runat="server" BorderStyle="Double" Height="50px" OnClick="Button5_Click" Text="5" Width="50px" />
                </td>
                <td>
                    <asp:Button ID="Button6" runat="server" BorderStyle="Double" Height="50px" OnClick="Button6_Click" Text="6" Width="50px" />
                </td>
                <td>
                    <asp:Button ID="Button7" runat="server" BorderStyle="Double" Height="50px" OnClick="Button7_Click" Text="7" Width="50px" />
                </td>
                <td class="auto-style9">
                    <asp:Button ID="Button8" runat="server" BorderStyle="Double" Height="47px" OnClick="Button8_Click" Text="8" Width="50px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:Button ID="Button9" runat="server" BorderStyle="Double" Height="50px" OnClick="Button9_Click" Text="9" Width="50px" />
                </td>
                <td>
                    <asp:Button ID="Button10" runat="server" BorderStyle="Double" Height="50px" OnClick="Button10_Click" Text="10" Width="50px" />
                </td>
                <td>
                    <asp:Button ID="Button11" runat="server" BorderStyle="Double" Height="50px" OnClick="Button11_Click" Text="11" Width="50px" />
                </td>
                <td class="auto-style9">
                    <asp:Button ID="Button12" runat="server" BorderStyle="Double" Height="50px" OnClick="Button12_Click" Text="12" Width="50px" />
                </td>
            </tr>
        </table>
        <br />
        <asp:Button ID="Button13" runat="server" OnClick="Button13_Click" style="background-color: #66FF33" Text="Book Now" />
        <br />
        
    </div>
    </form>
</body>
</html>
