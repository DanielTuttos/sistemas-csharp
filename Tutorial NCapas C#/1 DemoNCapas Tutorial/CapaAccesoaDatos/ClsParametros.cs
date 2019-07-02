using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CapaAccesoaDatos
{
   public class ClsParametros
    {
        //Parámetros
        public String m_Nombre { get; set; }
        public Object m_Valor  { get; set; }
        public SqlDbType m_TipoDato { get; set; }
        public Int32 m_Tamaño { get; set; }
        public ParameterDirection m_Direccion { get; set; }

        //CONSTRUCTORES
            //Parámetros de Entrada
        public ClsParametros(String objNombre, Object objValor)
        {
            m_Nombre = objNombre;
            m_Valor = objValor;
            m_Direccion = ParameterDirection.Input;
        }

            //Parámetros de Salida
        public ClsParametros(String objNombre, SqlDbType objTipoDato, Int32 objTamaño)
        {
            m_Nombre = objNombre;
            m_TipoDato = objTipoDato;
            m_Tamaño = objTamaño;
            m_Direccion = ParameterDirection.Output;
        }
    }
}
