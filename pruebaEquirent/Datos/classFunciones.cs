using pruebaEquirent.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace pruebaEquirent.Datos
{
    public class classFunciones : classConectar
    {

        public IEnumerable<Contacto> Consultar()
        {
            Conectar();
            List<Contacto> consultas = new List<Contacto>();
            try
            {
                SqlCommand comando = new SqlCommand("spconsultar", cnn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Contacto consulta = new Contacto()
                    {
                        Id = int.Parse(lector[0].ToString()),
                        Nombre = lector[1].ToString(),
                        Telefono = lector[2].ToString(),
                        CorreoElectonico = lector[3].ToString()

                    };
                    consultas.Add(consulta);
                }

            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                Desconectar();
            }
            return consultas;
        }
        public Contacto ConsultarId(int Id)
        {
            Conectar();
            Contacto Contacto = new Contacto();
            try
            {
                SqlCommand comando = new SqlCommand("spconsultarId", cnn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Id", Id);
                SqlDataReader lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Contacto consulta = new Contacto()
                    {
                        Id = int.Parse(lector[0].ToString()),
                        Nombre = lector[1].ToString(),
                        Telefono = lector[2].ToString(),
                        CorreoElectonico = lector[3].ToString()

                    };


                    Contacto = consulta;
                }


            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                Desconectar();
            }
            return Contacto;
        }
    }
}
