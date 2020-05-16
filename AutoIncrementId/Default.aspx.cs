using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
namespace AutoIncrementId
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            getidno();
            Button2.Visible = true;
            Button1.Visible = false;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            Button1.Visible = true;
            Button2.Visible = false;
            String updatepass = "insert into AutoIncrement(idno,rollno,sname,fathername,contact) values(" + Label2.Text + ",'" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')";
            String mycon1 = "Data Source=DESKTOP-ND746LH;Initial Catalog=ASP.NET;Integrated Security=True";
            SqlConnection s = new SqlConnection(mycon1);
            s.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandText = updatepass;
            cmd1.Connection = s;
            cmd1.ExecuteNonQuery();
            Label3.Text = "Data Has Been Saved Successfully";
            Label2.Text = "";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }
        public void getidno()
        {
            String mycon = "Data Source=DESKTOP-ND746LH;Initial Catalog=ASP.NET;Integrated Security=True";
            SqlConnection scon = new SqlConnection(mycon);
            String myquery = "select idno from AutoIncrement";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = scon;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            scon.Close();
            if (ds.Tables[0].Rows.Count < 1)
            {
                Label2.Text = "1";

            }
            else
            {



                String mycon1 = "Data Source=DESKTOP-ND746LH;Initial Catalog=ASP.NET;Integrated Security=True";
                SqlConnection scon1 = new SqlConnection(mycon1);
                String myquery1 = "select max(idno) from AutoIncrement";
                SqlCommand cmd1 = new SqlCommand();
                cmd1.CommandText = myquery1;
                cmd1.Connection = scon1;
                SqlDataAdapter da1 = new SqlDataAdapter();
                da1.SelectCommand = cmd1;
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                Label2.Text = ds1.Tables[0].Rows[0][0].ToString();
                int a;
                a = Convert.ToInt16(Label2.Text);
                a = a + 1;
                Label2.Text = a.ToString();
                scon1.Close();
            }

        }

    }
}