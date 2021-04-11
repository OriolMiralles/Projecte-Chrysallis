using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace API_CHRYSALLIS.CLASES
{
    public class Utilitat
    {
        public static String missatgeError(SqlException sqlException)
        {
            String missatge = "";

            switch (sqlException.Number)
            {
                case 2:
                    missatge = "El servidor no está operatiu";
                    break;
                case 547:
                    missatge = "El registre té dades relacionades";
                    break;
                case 2601:
                    missatge = "Registre duplicat";
                    break;
                case 2627:
                    missatge = "Registre duplicat";
                    break;
                case 4060:
                    missatge = "No es pot obrir la base de dades";
                    break;
                default:
                    missatge = sqlException.Number + ": " + sqlException.Message;
                    break;
            }

            return missatge;
        }
    }
}