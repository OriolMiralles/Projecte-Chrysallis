using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chrysallis_Eventos.MODELOS
{
    public static class MenorOrm
    {
        public static String Insert(menors menor)
        {
            String missatge = "";
            Orm.bd.menors.Add(menor);
            missatge = Orm.mySaveChanges();
            return missatge;
        }

        public static String Insert(menors_socis menor_soci)
        {
            String missatge = "";
            Orm.bd.menors_socis.Add(menor_soci);
            missatge = Orm.mySaveChanges();
            return missatge;
        }
        public static List<menors> Select(ref String missatge, String nombreMenor)
        {
            List<menors> _menor = null;
            try
            {
                _menor = Orm.bd.menors
                                   .Where(m => m.nom.Equals(nombreMenor)).ToList();

            }
            catch (SqlException ex)
            {
                missatge = Orm.missatgeError(ex);
            }
            return _menor;
        }
        public static List<menors_socis> Select(ref String missatge, socis soci)
        {
            List<menors_socis> _menors = null;
            try
            {
                _menors = Orm.bd.menors_socis
                                   .Where(m => m.id_soci == soci.id).ToList();

            }
            catch (SqlException ex)
            {
                missatge = Orm.missatgeError(ex);
            }
            return _menors;
        }

        public static String Delete(menors_socis menorSoci)
        {
            String missatge = "";

            Orm.bd.menors_socis.Remove(menorSoci);
            missatge = Orm.mySaveChanges();
            return missatge;
        }
    }
}
