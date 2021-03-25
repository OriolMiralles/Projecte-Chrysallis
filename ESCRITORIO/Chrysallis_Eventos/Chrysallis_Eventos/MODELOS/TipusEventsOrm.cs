using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chrysallis_Eventos.MODELOS
{
    public static class TipusEventsOrm
    {
        public static List<tipus_events> Select(ref String missatge)
        {
            List<tipus_events> _tipus_events = null;
            try
            {
                _tipus_events = Orm.bd.tipus_events.ToList();
            }
            catch (SqlException ex)
            {
                missatge = Orm.missatgeError(ex);
            }

            return _tipus_events;
        }
    }
}
