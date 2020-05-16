<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 57%;
            height: 390px;
        }
        .auto-style2 {
            width: 360px;
        }
        .auto-style3 {
            width: 100%;
            height: 307px;
            margin-top: 0px;
            background-color: #FFFF66;
        }
        .auto-style4 {
            height: 53px;
        }
        .auto-style5 {
            height: 53px;
            width: 130px;
        }
        .auto-style7 {
            width: 130px;
            height: 57px;
        }
        .auto-style8 {
            height: 57px;
        }
        .auto-style9 {
            width: 100%;
            height: 379px;
            margin-top: 0px;
            background-color: #99FF33;
        }
        .auto-style10 {
            height: 237px;
            text-align: center;
        }
        .auto-style11 {
            height: 132px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Reistration Page"></asp:Label>
        <br />
        <br />
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <table border="1" class="auto-style3">
                        <tr>
                            <td class="auto-style5">Roll No</td>
                            <td class="auto-style4">
                                <asp:TextBox ID="TextBox1" runat="server" Height="36px" Width="188px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style7">Student Name</td>
                            <td class="auto-style8">
                                <asp:TextBox ID="TextBox2" runat="server" Height="36px" Width="188px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style7">Father Name</td>
                            <td class="auto-style8" style="background-color: #FFFF66">
                                <asp:TextBox ID="TextBox3" runat="server" Height="36px" Width="188px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style7">Mother Name</td>
                            <td class="auto-style8">
                                <asp:TextBox ID="TextBox4" runat="server" Height="36px" Width="188px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style11" colspan="2">
                                <asp:Button ID="Button1" runat="server" BackColor="#66FF33" Height="28px" OnClick="Button1_Click" style="text-align: center" Text="Save" Width="85px" />
                                <br />
                                <br />
                                <asp:Label ID="Label2" runat="server"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </td>
                <td>
                    <table border="1" class="auto-style9">
                        <tr>
                            <td class="auto-style10">
                                <asp:Image ID="Image1" runat="server" style="text-align: center" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:FileUpload ID="FileUpload1" runat="server" />
                                <br />
                                Image Should Be JPEG200*200<br />
                                max size 50 kb</td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
