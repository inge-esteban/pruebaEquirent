using pruebaEquirent.Variables;
using System;
using System.Data.SqlClient;

namespace pruebaEquirent.Datos
{
    public class classConectar
    {
        protected SqlConnection cnn;
        public void Conectar()
        {
            try
            {
                cnn = new SqlConnection(classVariables.stringconnection);
                cnn.Open();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
        public void Desconectar()
        {
            try
            {
              
                cnn.Close();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}
