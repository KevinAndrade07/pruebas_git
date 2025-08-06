using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectUni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarEstudiantes();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tblPanelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=TS-WSI-013\\SQLEXPRESS;Database=universidad;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_gestiones_estudiante", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                string nombre = txtNombre.Text.Trim();
                string documento = txtNumIdentificacion.Text.Trim();
                string correo = txtCorreo.Text.Trim();

                cmd.Parameters.AddWithValue("@opcion", "R");
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@documento_identidad", documento);
                cmd.Parameters.AddWithValue("@email_estudiante", correo);

                SqlParameter paramError = new SqlParameter("@error", SqlDbType.VarChar, 100)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(paramError);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    string mensaje = paramError.Value?.ToString();
                    MessageBox.Show(mensaje ?? "Registro completado", "Resultado");

                    //Limpiar campos después del registro
                    txtNombre.Clear();
                    txtNumIdentificacion.Clear();
                    txtCorreo.Clear();

                    //Recargar el DataGridView
                    CargarEstudiantes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error");
                }
            }
        }
        private void CargarEstudiantes()
        {
            string connectionString = "Server=TS-WSI-013\\SQLEXPRESS;Database=universidad;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_gestiones_estudiante", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@opcion", "C");
                cmd.Parameters.AddWithValue("@nombre", DBNull.Value);
                cmd.Parameters.AddWithValue("@documento_identidad", DBNull.Value);
                cmd.Parameters.AddWithValue("@email_estudiante", DBNull.Value);

                SqlParameter paramError = new SqlParameter("@error", SqlDbType.VarChar, 100)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(paramError);

                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);

                    //Mostrar datos 
                    dataGridView.DataSource = tabla;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar estudiantes: " + ex.Message);
                }
            }
        }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
