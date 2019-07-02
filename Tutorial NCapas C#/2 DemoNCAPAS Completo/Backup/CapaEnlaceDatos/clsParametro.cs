﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaEnlaceDatos
{
    public class clsParametro
    {
        //Atributos
        private String m_Nombre;
        private Object m_Valor;
        private SqlDbType m_TipoDato;
        private ParameterDirection m_Direccion;
        private int m_Tamaño;

        //Propiedades
        public String Nombre {
            get { return m_Nombre; }
            set { m_Nombre = value; }
        }

        public Object Valor {
            get { return m_Valor; }
            set { m_Valor = value; }
        }

        public SqlDbType TipoDato {
            get { return m_TipoDato; }
            set { m_TipoDato = value; }
        }

        public ParameterDirection Direccion {
            get { return m_Direccion; }
            set { m_Direccion = value; }
        }

        public int Tamaño {
            get { return m_Tamaño; }
            set { m_Tamaño = value; }
        }

        //Constructor para parámetros de Entrada
        public clsParametro(String ObjNombre,Object objValor) {
            m_Nombre = ObjNombre;
            m_Valor = objValor;
            m_Direccion = ParameterDirection.Input;
        }
        //Constructor para parámetros de Salida
        public clsParametro(String objNombre, Object objValor,SqlDbType objTipoDato,ParameterDirection objDireccion,int objTamaño) {
            m_Nombre = objNombre;
            m_Valor = objValor;
            m_TipoDato = objTipoDato;
            m_Direccion = objDireccion;
            m_Tamaño = objTamaño;
        }
    }
}