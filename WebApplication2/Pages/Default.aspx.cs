using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication2.Pages
{
    public partial class Default : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt;
        DataSet ds = new DataSet();
        int SN_ATIVO;

        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=ROOM_PC;Initial Catalog=WEBFORM;Persist Security Info=True;User ID=sa;Password=n1kgodscoberta";
            con.Open();
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            dt = new DataTable();

            if (TBAtivo.Text.ToUpper() == "SIM")
            {
                SN_ATIVO = 1;
            }
            else
            {
                SN_ATIVO = 0;
            }

            cmd.CommandText = "INSERT INTO Clientes (Cli_Nome, Cli_DataNascimento, Cli_Ativo) VALUES('" + TBNome.Text + "','" + Calendar.SelectedDate + "','" + SN_ATIVO + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();

            
        }

        protected void BtnList_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            cmd.CommandText = "SELECT * FROM Clientes";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            ViewRows.DataSource = ds;
            ViewRows.DataBind();
            con.Close();
        }

        protected void BtnDel_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "DELETE FROM Clientes WHERE Cli_Nome ='" + TBNome.Text + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('Deletado com sucesso!')</script>");
            con.Close();
        }

        protected void BtnUpdt_Click(object sender, EventArgs e)
        {
            dt = new DataTable();

            if (TBAtivo.Text.ToUpper() == "SIM")
            {
                SN_ATIVO = 1;
            }
            else
            {
                SN_ATIVO = 0;
            }


            cmd.CommandText = "UPDATE Clientes set Cli_Nome ='" + TBNome.Text + "', Cli_DataNascimento='" + Calendar.SelectedDate + "', Cli_Ativo='" + SN_ATIVO + "' WHERE Cli_Nome = '" + TBNome.Text + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void BtnNext_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/Update.aspx");
        }
    }
}