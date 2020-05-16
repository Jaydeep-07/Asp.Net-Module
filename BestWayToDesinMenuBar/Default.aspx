<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
ul {
    list-style-type: none;
    margin: 0;
    padding: 0;
    overflow: hidden;
    background-color: #333;
}

li {
    float: left;
}

li a {
    display: block;
    color: white;
    text-align: center;
    padding: 14px 16px;
    text-decoration: none;
}

li a:hover {
    background-color: yellow;
    color:black
}
</style>

</head>
<body>
    <form id="form1" runat="server">
    <div>
            <ul>
                <li><a class="active" href="#home">Home</a></li>
                <li><a href="Aboutus.aspx">About</a></li>
                <li><a href="Services.aspx">Services</a></li>
                <li><a href="ContactUs.aspx">Contact us</a></li>
            </ul>
    </div>
    </form>
</body>
</html>
