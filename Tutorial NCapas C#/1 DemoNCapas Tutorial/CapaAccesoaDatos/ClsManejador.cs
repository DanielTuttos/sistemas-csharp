using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CapaAccesoaDatos
{
   public class ClsManejador
    {
        SqlConnection conexion = new SqlConnection("Server=.;DataBase=DemoNCapas;Integrated Security=Yes");

        //Método para abrir Conexión BD
        public void abrir_conexion()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
        }

        //Método para cerrar Conexión BD
        public void cerrar_conexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }
       

        //Método para ejecutar sp (Insert, Delete, Update)
        public void Ejecutar_Sp(String NombreSp, List<ClsParametros> lst)
        {
            SqlCommand cmd;
            try
            {
                abrir_conexion();
                cmd = new SqlCommand(NombreSp, conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (lst[i].m_Direccion == ParameterDirection.Input)
                        {
                            cmd.Parameters.AddWithValue(lst[i].m_Nombre, lst[i].m_Valor);
                        }

                        if (lst[i].m_Direccion == ParameterDirection.Output)
                        {
                            cmd.Parameters.Add(lst[i].m_Nombre, lst[i].m_TipoDato, lst[i].m_Tamaño).Direction = ParameterDirection.Output;
                            //cmd.Parameters.Add(lst[i].Nombre, lst[i].TipoDato, lst[i].Tamaño).Direction = ParameterDirection.Output;
                        }
                    }
                    cmd.ExecuteNonQuery();

                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (cmd.Parameters[i].Direction == ParameterDirection.Output)
                            lst[i].m_Valor = cmd.Parameters[i].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            cerrar_conexion();
        }

        //Método para los listados o Consultas (Select)
        public DataTable Listado(String NombreSP, List<ClsParametros> lst)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            try
            {
                abrir_conexion();
                da = new SqlDataAdapter(NombreSP, conexion);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        da.SelectCommand.Parameters.AddWithValue(lst[i].m_Nombre, lst[i].m_Valor);
                    }
                }
                da.Fill(dt); //Llenamos el dt con los datos del da
            }
            catch (Exception ex)
            {

                throw ex;
            }
            cerrar_conexion();
            return dt;
        }

    }
}
