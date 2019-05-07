using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EjemploConexionBBDD
{
    class ConexionBBDD
    {
        public MySqlConnection conecta()
        {
            /*Se necesitan 5 parametros para iniciar la conexion
             * 1º Server: IP o nombre del servidor
             * 2º Database: Nombre de la BBDD
             * 3º UID: User ID (not null)
             * 4º Password: contraseña
             * 5º Port: puerto, por defecto es el 3306*/
            MySqlConnection conexion = new MySqlConnection(
                "Server = 127.0.0.1;" +
                "Database= videoclub;" +
                "Uid=root1234;" +
                "Pwd=;" +
                "Port=3306");
            conexion.Open();
            return conexion;

        }
    }
}
