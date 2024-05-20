using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace VentaAutos
{
    public class Connection
    {
        private static SqlConnection cnx = new SqlConnection();
        private static void connect()
        {
            try
            {
                cnx.ConnectionString = @"Data Source=DESKTOP-3AGDMLR\SQLEXPRESS; Initial Catalog=ventasautos;Integrated Security=True";
                cnx.Open();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al conectar a la base de datos: " + ex.Message);
            }
        }
        private static void disconect()
        {
            try
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al desconectar la base de datos" + ex.Message);
            }
        }
        public static DataTable SelectQuery(string query)
        {
            var dt = new DataTable();
            try
            {
                connect();
                var cmd = new SqlCommand(query, cnx);
                var da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al ejecutar la consulta: " + ex.Message);
            }
            finally
            {
                disconect();
            }
            return dt;
        }
        public static void Deletedata(string deleteQuery)
        {
            try
            {
                connect();
                var cmd = new SqlCommand(deleteQuery, cnx);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al ejecutar la consulta de eliminación: " + ex.Message);
            }
            finally
            {
                disconect();
            }
        }
        public static void ExecuteStoreProcedure(SqlCommand cmd, string spName)
        {
            try
            {
                connect();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = spName;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error al ejecutar el stored procedure: " + ex.Message);
            }
            finally
            {
                disconect();
            }
        }

        public static void VisibleoNo(Panel p, bool estado)
        {
            // For Each c As TextBox In
            // p.Controls.OfType(Of TextBox)
            // c.Visible = estado
            // Next

            foreach (var c in p.Controls)
            {
                if (c is TextBox || c is Button || c is Label || c is PictureBox)
                {
                    ((dynamic)c).Visible = estado;
                }
            }

            if (estado == true)
            {
                p.BringToFront();
            }
        }

    }
}