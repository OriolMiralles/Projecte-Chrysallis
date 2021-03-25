using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chrysallis_Eventos.MODELOS
{
    public static class CiutatsOrm
    {
        public static List<localitats> Select(ref String missatge, provincies provincia)
        {
            List<localitats> ciutats = null;

            try
            {
                ciutats = Orm.bd.localitats.Where(c => c.id_provincia == provincia.id).ToList();
            }
            catch (SqlException ex)
            {
                missatge = Orm.missatgeError(ex);
            }

            return ciutats;
        }
    }
}
