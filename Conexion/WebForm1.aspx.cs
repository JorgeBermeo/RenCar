using ProgramacionIII.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Conexion
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Connection conx = new Connection();
            //string ab = ConexionMySQL().ToString();

            if (conx.ConexionMySQL().ToString().Equals(""))
            {
                Label1.Text = "Error"; 
            }
            else
            {
                Label1.Text = conx.ConexionMySQL().ToString();
            }
            
            
             
            
        }
    }
}