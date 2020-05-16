using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class _Default : System.Web.UI.Page
{

    static int[] bookedseat;
    static int[] tempbookseat;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bookedseat = new int[13];
            tempbookseat = new int[13];
            tempbookseat[0] = 0;
            tempbookseat[1] = 0;
            tempbookseat[2] = 0;
            tempbookseat[3] = 0;
            tempbookseat[4] = 0;
            tempbookseat[5] = 0;
            tempbookseat[6] = 0;
            tempbookseat[7] = 0;
            tempbookseat[8] = 0;
            tempbookseat[9] = 0;
            tempbookseat[10] = 0;
            tempbookseat[11] = 0;
            tempbookseat[12] = 0;
       

            alreadybooked();
        }

    }
    protected void Button13_Click(object sender, EventArgs e)
    {
      
 int i = 0;
        for(i=0;i<13;i++)
        {
            if(tempbookseat[i]==1)
            {
                String mycon = "Data Source=DESKTOP-ND746LH;Initial Catalog=ASP.NET;Integrated Security=True";
                String updatedata = "Update SeatStatus set status='B' where seatno=" + (i+1);
                SqlConnection con = new SqlConnection(mycon);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = updatedata;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            
        }
        
        Session["tempbooking"] = tempbookseat;

        Response.Redirect("Thanks.aspx");

    }
    private void alreadybooked()
    {
        String mycon = "Data Source=DESKTOP-ND746LH;Initial Catalog=ASP.NET;Integrated Security=True";
        String myquery = "Select * from SeatStatus";
        SqlConnection con = new SqlConnection(mycon);
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = myquery;
        cmd.Connection = con;
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        DataSet ds = new DataSet();
        da.Fill(ds);
        int rows = ds.Tables[0].Rows.Count;
        int i = 0;
        while (i < rows)
        {
            String status;
            status = ds.Tables[0].Rows[i]["status"].ToString();
            if (status == "B")
            {
                bookedseat[i] = 1;
                if (i == 0)
                {
                    Button1.BackColor = System.Drawing.Color.Red;
                    Button1.Enabled = false;
                }
                if (i == 1)
                {
                    Button2.BackColor = System.Drawing.Color.Red;
                    Button2.Enabled = false;
                }
                if (i == 2)
                {
                    Button3.BackColor = System.Drawing.Color.Red;
                    Button3.Enabled = false;
                }
                if (i == 3)
                {
                    Button4.BackColor = System.Drawing.Color.Red;
                    Button4.Enabled = false;
                }
                if (i == 4)
                {
                    Button5.BackColor = System.Drawing.Color.Red;
                    Button5.Enabled = false;
                }
                if (i == 5)
                {
                    Button6.BackColor = System.Drawing.Color.Red;
                    Button6.Enabled = false;
                }
                if (i == 6)
                {
                    Button7.BackColor = System.Drawing.Color.Red;
                    Button7.Enabled = false;
                }
                if (i == 7)
                {
                    Button8.BackColor = System.Drawing.Color.Red;
                    Button8.Enabled = false;
                }
                if (i == 8)
                {
                    Button9.BackColor = System.Drawing.Color.Red;
                    Button9.Enabled = false;
                }
                if (i == 9)
                {
                    Button10.BackColor = System.Drawing.Color.Red;
                    Button10.Enabled = false;
                }
                if (i == 10)
                {
                    Button11.BackColor = System.Drawing.Color.Red;
                    Button11.Enabled = false;
                }
                if (i == 11)
                {
                    Button12.BackColor = System.Drawing.Color.Red;
                    Button12.Enabled = false;
                }
                if (i == 12)
                {
                    Button13.BackColor = System.Drawing.Color.Red;
                    Button13.Enabled = false;
                }
             
            }
            if (status == "A")
            {
                bookedseat[i] = 0;
                if (i == 0)
                {
                    Button1.BackColor = System.Drawing.Color.Gray;
                }
                if (i == 1)
                {
                    Button2.BackColor = System.Drawing.Color.Gray;
                }
                if (i == 2)
                {
                    Button3.BackColor = System.Drawing.Color.Gray;
                }
                if (i == 3)
                {
                    Button4.BackColor = System.Drawing.Color.Gray;
                }
                if (i == 4)
                {
                    Button5.BackColor = System.Drawing.Color.Gray;
                }
                if (i == 5)
                {
                    Button6.BackColor = System.Drawing.Color.Gray;
                }
                if (i == 6)
                {
                    Button7.BackColor = System.Drawing.Color.Gray;
                }
                if (i == 7)
                {
                    Button8.BackColor = System.Drawing.Color.Gray;
                }
                if (i == 8)
                {
                    Button9.BackColor = System.Drawing.Color.Gray;
                }
                if (i == 9)
                {
                    Button10.BackColor = System.Drawing.Color.Gray;
                }
                if (i == 10)
                {
                    Button11.BackColor = System.Drawing.Color.Gray;
                }
                if (i == 11)
                {
                    Button12.BackColor = System.Drawing.Color.Gray;
                }
                if (i == 12)
                {
                    Button13.BackColor = System.Drawing.Color.Gray;
                }
               
            }
            i++;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        if (tempbookseat[0] == 0)
        {
            Button1.BackColor = System.Drawing.Color.Green;
            tempbookseat[0] = 1;

        }
        else
        {
            Button1.BackColor = System.Drawing.Color.Gray;
            tempbookseat[0] = 0;
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

        if (tempbookseat[1] == 0)
        {
            Button2.BackColor = System.Drawing.Color.Green;
            tempbookseat[1] = 1;

        }
        else
        {
            Button2.BackColor = System.Drawing.Color.Gray;
            tempbookseat[1] = 0;
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {

        if (tempbookseat[2] == 0)
        {
            Button3.BackColor = System.Drawing.Color.Green;
            tempbookseat[2] = 1;

        }
        else
        {
            Button3.BackColor = System.Drawing.Color.Gray;
            tempbookseat[2] = 0;
        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {

        if (tempbookseat[3] == 0)
        {
            Button4.BackColor = System.Drawing.Color.Green;
            tempbookseat[3] = 1;

        }
        else
        {
            Button4.BackColor = System.Drawing.Color.Gray;
            tempbookseat[3] = 0;
        }
    }
    protected void Button5_Click(object sender, EventArgs e)
    {

        if (tempbookseat[4] == 0)
        {
            Button5.BackColor = System.Drawing.Color.Green;
            tempbookseat[4] = 1;

        }
        else
        {
            Button5.BackColor = System.Drawing.Color.Gray;
            tempbookseat[4] = 0;
        }
    }
    protected void Button6_Click(object sender, EventArgs e)
    {

        if (tempbookseat[5] == 0)
        {
            Button6.BackColor = System.Drawing.Color.Green;
            tempbookseat[5] = 1;

        }
        else
        {
            Button6.BackColor = System.Drawing.Color.Gray;
            tempbookseat[5] = 0;
        }
    }
    protected void Button7_Click(object sender, EventArgs e)
    {

        if (tempbookseat[6] == 0)
        {
            Button7.BackColor = System.Drawing.Color.Green;
            tempbookseat[6] = 1;

        }
        else
        {
            Button7.BackColor = System.Drawing.Color.Gray;
            tempbookseat[6] = 0;
        }
    }
    protected void Button8_Click(object sender, EventArgs e)
    {

        if (tempbookseat[7] == 0)
        {
            Button8.BackColor = System.Drawing.Color.Green;
            tempbookseat[7] = 1;

        }
        else
        {
            Button8.BackColor = System.Drawing.Color.Gray;
            tempbookseat[7] = 0;
        }
    }
    protected void Button9_Click(object sender, EventArgs e)
    {

        if (tempbookseat[8] == 0)
        {
            Button9.BackColor = System.Drawing.Color.Green;
            tempbookseat[8] = 1;

        }
        else
        {
            Button9.BackColor = System.Drawing.Color.Gray;
            tempbookseat[8] = 0;
        }
    }
    protected void Button10_Click(object sender, EventArgs e)
    {

        if (tempbookseat[9] == 0)
        {
            Button10.BackColor = System.Drawing.Color.Green;
            tempbookseat[9] = 1;

        }
        else
        {
            Button10.BackColor = System.Drawing.Color.Gray;
            tempbookseat[9] = 0;
        }
    }
    protected void Button11_Click(object sender, EventArgs e)
    {

        if (tempbookseat[10] == 0)
        {
            Button11.BackColor = System.Drawing.Color.Green;
            tempbookseat[10] = 1;

        }
        else
        {
            Button11.BackColor = System.Drawing.Color.Gray;
            tempbookseat[10] = 0;
        }
    }
    protected void Button12_Click(object sender, EventArgs e)
    {

        if (tempbookseat[11] == 0)
        {
            Button12.BackColor = System.Drawing.Color.Green;
            tempbookseat[11] = 1;

        }
        else
        {
            Button12.BackColor = System.Drawing.Color.Gray;
            tempbookseat[11] = 0;
        }
    }
}