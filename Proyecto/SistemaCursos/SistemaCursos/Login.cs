using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaCursos
{
    public partial class Login : Form
    {
        //Para obtener el string de conexion ir a Ver->Explorador de Servidores->SeleccionarBD->ClickDerecho->Propiedades->ConectionString
        public static string connectionString = @"Data Source=DESKTOP-GL238MR\SQLEXPRESS;Initial Catalog=sistemaCursos;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectionString);

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        //METODO INICIAR SESIÓN
        public void iniciarSesion()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM sisemaCursos";
        }
    }
}
