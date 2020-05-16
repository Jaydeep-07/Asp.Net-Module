using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        SmtpClient smtp = new SmtpClient();
        smtp.Host = "smtp.gmail.com";
        smtp.Port = 587;
        smtp.Credentials = new System.Net.NetworkCredential("jaydeepvpatil225@gmail.com", "pwd");
        smtp.EnableSsl = true;
        MailMessage msg = new MailMessage();
        msg.Subject = "Hello " + TextBox1.Text + "  Thanks for Register";
        msg.Body = "Hi, Thanks For Your Using These Module. Thanks";
        string toaddress = TextBox2.Text;
        msg.To.Add(toaddress);
        string fromaddress = "Jaydeep JD <jaydeepvpatil225@gmail.com>";
        msg.From = new MailAddress(fromaddress);
        try
        {
            smtp.Send(msg);
            Label2.Text = "Your Email Has Been Registered with Us";
            TextBox1.Text = "";
            TextBox2.Text = "";

        }
        catch(Exception)
        {
            Console.WriteLine(e);
        }
    }
}