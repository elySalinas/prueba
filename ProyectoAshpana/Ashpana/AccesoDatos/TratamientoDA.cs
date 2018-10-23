﻿using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class TratamientoDA
    {
        public BindingList<Tratamiento> listarTratamientos()
        {
            BindingList<Tratamiento> tratamientos = new BindingList<Tratamiento>();
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g4;" + "password=GvZf6p;" + "database=inf282g4;" + "port=3306;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);


            con.Open();


            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "LISTAR_TRATAMIENTOS";
            comando.Connection = con;

            MySqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                Tratamiento trat = new Tratamiento();
                trat.IdTrat = lector.GetInt32("ID_TRATAMIENTO");
                trat.NombreTrat = lector.GetString("NOMBRE");
                trat.DuracionTrat = lector.GetDouble("DURACION");
                trat.PrecioTrat = lector.GetDouble("PRECIO");
                trat.TipoTrat = lector.GetInt32("TIPO_TRATAMIENTO");
                trat.EstadoTrat = lector.GetInt32("ESTADO");
                if (trat.TipoTrat == 1)
                    trat.TipoString = "Facial";
                else
                    trat.TipoString = "Corporal";

                MySqlConnection con2 = new MySqlConnection(cadena);
                con2.Open();
                MySqlCommand comando2 = new MySqlCommand();
                comando2.CommandType = System.Data.CommandType.StoredProcedure;
                comando2.CommandText = "LISTAR_ZONAS_X_TRATAMIENTO";
                comando2.Connection = con2;
                comando2.Parameters.Add("_ID_TRATAMIENTO", MySqlDbType.Int32).Value = trat.IdTrat;

                MySqlDataReader lector2 = comando2.ExecuteReader();

                while (lector2.Read())
                {
                    Zona zona = new Zona();
                    zona.IdZona = lector2.GetInt32("ID_ZONA");
                    zona.NombreZona = lector2.GetString("NOMBRE");
                    zona.DescripicionZona = lector2.GetString("DESCRIPCION");
                    trat.ZonasTratar.Add(zona);
                }
                con2.Close();
                String cad = "";
                foreach (Zona z in trat.ZonasTratar)
                {
                    cad = cad + z.NombreZona + "/ ";

                }

                trat.ZonasTratarString = cad;

                MySqlConnection con3 = new MySqlConnection(cadena);
                con3.Open();
                MySqlCommand comando3 = new MySqlCommand();
                comando3.CommandType = System.Data.CommandType.StoredProcedure;
                comando3.CommandText = "LISTAR_CONDICIONES_MEDICAS_X_TRATAMIENTO";
                comando3.Connection = con3;
                comando3.Parameters.Add("_ID_TRATAMIENTO", MySqlDbType.Int32).Value = trat.IdTrat;

                MySqlDataReader lector3 = comando3.ExecuteReader();

                while (lector3.Read())
                {
                    CondicionMedica condMed = new CondicionMedica();
                    condMed.IdCondMed = lector3.GetInt32("ID_CONDICION_MEDICA");
                    condMed.Nombre = lector3.GetString("NOMBRE");
                    condMed.Descripcion = lector3.GetString("DESCRIPCION");
                    trat.CondicionesMedicas.Add(condMed);
                }
                con3.Close();
                String cad2 = "";
                foreach (CondicionMedica c in trat.CondicionesMedicas)
                {
                    cad2 = cad2 + c.Nombre + "/ ";

                }
                trat.CondicionesMedicasString = cad2;
                tratamientos.Add(trat);
            }



            con.Close();



            return tratamientos;
        }

        public int registrarTratamiento(Tratamiento tratamiento)
        {
            try
            {
                String cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g4;" + "password=GvZf6p;" + "database=inf282g4;" + "port=3306;" + "SslMode=none;";
                MySqlConnection con = new MySqlConnection(cadena);
                con.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.CommandText = "INSERTAR_TRATAMIENTO";
                comando.Connection = con;

                comando.Parameters.Add("_NOMBRE", MySqlDbType.VarChar).Value = tratamiento.NombreTrat;
                comando.Parameters.Add("_DURACION", MySqlDbType.Double).Value = tratamiento.DuracionTrat;
                comando.Parameters.Add("_PRECIO", MySqlDbType.Double).Value = tratamiento.PrecioTrat;
                comando.Parameters.Add("_TIPO_TRATAMIENTO", MySqlDbType.Int32).Value = tratamiento.TipoTrat;

                comando.Parameters.Add("_ID", MySqlDbType.Int32).Direction = System.Data.ParameterDirection.Output;

                comando.ExecuteNonQuery();
                con.Close();

                return Int32.Parse(comando.Parameters["_ID"].Value.ToString());

            }
            catch
            {
                return 0;
            }
        }

        public void modificarTratamiento(Tratamiento tratamiento)
        {
            String cadena = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g4;" + "password=GvZf6p;" + "database=inf282g4;" + "port=3306;" + "SslMode=none;";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT ID_TRATAMIENTO FROM TRATAMIENTO WHERE NOMBRE = '" + tratamiento.NombreTrat + "';", con);
            MySqlDataReader reader = null;
            reader = cmd.ExecuteReader();

            reader.Read();
            int id = reader.GetInt32(0);
            reader.Dispose();

            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = "MODIFICAR_TRATAMIENTO";
            comando.Connection = con;

            comando.Parameters.Add("_ID", MySqlDbType.Int32).Value = id;
            comando.Parameters.Add("_NOMBRE", MySqlDbType.VarChar).Value = tratamiento.NombreTrat;
            comando.Parameters.Add("_DURACION", MySqlDbType.Double).Value = tratamiento.DuracionTrat;
            comando.Parameters.Add("_PRECIO", MySqlDbType.Double).Value = tratamiento.PrecioTrat;
            comando.Parameters.Add("_TIPO", MySqlDbType.Int32).Value = tratamiento.TipoTrat;


            comando.ExecuteNonQuery();
            con.Close();


        }
    }
}
