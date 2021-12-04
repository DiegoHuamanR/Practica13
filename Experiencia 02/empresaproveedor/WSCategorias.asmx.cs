using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;

namespace empresaproveedor
{
    /// <summary>
    /// Summary description for WSCategorias
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WSCategorias : System.Web.Services.WebService
    {
        private string connectionString; public WSCategorias()
        {
            //Eliminar la marca de comentario de la línea siguiente si utiliza los 
            // componentes diseñados //InitializeComponent(); 
            connectionString = "Data Source=DESKTOP-P38UK86\\sqlexpress;Initial Catalog = Northwind; Integrated Security = True";
        }
        [WebMethod]
        public DataSet GetCategorias()
        {
            string selectSQL = "SELECT CategoryID,CategoryName, Description,Picture FROM Categories";
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(selectSQL, con);
            //SqlDataReader reader; 
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dsCategorias = new DataSet();
            // Fill the same table. 
            adapter.Fill(dsCategorias, "Categories");
            return dsCategorias;
        }
    }
}
