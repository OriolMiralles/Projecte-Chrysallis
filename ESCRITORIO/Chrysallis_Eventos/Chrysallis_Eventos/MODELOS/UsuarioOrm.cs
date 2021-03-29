using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chrysallis_Eventos.MODELOS
{
    public static class UsuarioOrm
    {
        public static List<socis> Select(ref String missatge, comunitats comunitat)
        {
            List<socis> _socis = new List<socis>();
            try
            {
                _socis = Orm.bd.socis.Where(s => s.localitats.provincies.id_comunitat==comunitat.id).OrderBy(s => s.dni).ToList();
            }
            catch (SqlException ex)
            {
                missatge = Orm.missatgeError(ex);
            }


            return _socis;
        }
        public static List<socis> Select(ref String missatge, String dni)
        {
            List<socis> _socis = null;
            try
            {
                _socis = Orm.bd.socis.Where(s => s.dni.Equals(dni)).ToList();
            }
            catch (SqlException ex)
            {
                missatge = Orm.missatgeError(ex);
            }


            return _socis;
        }

        public static String Insert(ref String missatge, socis nouSocis)
        {
            Orm.bd.socis.Add(nouSocis);

            missatge = Orm.mySaveChanges();

            return missatge;
        }

        public static String Update(ref String missatge, socis soci)
        {
            try
            {
                Orm.bd.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                SqlException sqlException = (SqlException)ex.InnerException.InnerException;
                missatge = Orm.missatgeError(sqlException);
            }

            return missatge;
        }

        public static String Delete(ref String missatge, socis soci)
        {
            Orm.bd.socis.Remove(soci);

            missatge = Orm.mySaveChanges();

            return missatge;
        }

    }
}
