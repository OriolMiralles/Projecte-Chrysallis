using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chrysallis_Eventos.MODELOS
{
    public static class EventosOrm
    {
        public static List<esdeveniments> Select(ref String missatge, comunitats comunitat)
        {
            List<esdeveniments> _esdeveniments = new List<esdeveniments>();
            try
            {
                _esdeveniments = Orm.bd.esdeveniments.Where(e => e.id_comunitat == comunitat.id).OrderBy(e => e.data).ThenBy(e => e).ToList();
            }
            catch (SqlException ex)
            {
                missatge = Orm.missatgeError(ex);
            }


            return _esdeveniments;
        }
    }
}
