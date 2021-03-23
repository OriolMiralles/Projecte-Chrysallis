﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chrysallis_Eventos.MODELOS;

namespace Chrysallis_Eventos.MODELOS
{
    public static class AdminOrm
    {
        public static String Insert(usuaris usuari)
        {
            String missatge = "";
            Orm.bd.usuaris.Add(usuari);
            missatge = Orm.mySaveChanges();
            return missatge;
        }

        public static List<usuaris> Select(ref String missatge, String userName)
        {
            List<usuaris> _usuari = Orm.bd.usuaris
                                    .Where(u => u.username.Equals(userName)).ToList();
            return _usuari;
        }

<<<<<<< HEAD
        public static List<usuaris> Select(ref String missatge)
        {
            List<usuaris> usuaris = new List<usuaris>();
            try
            {
                usuaris = Orm.bd.usuaris.ToList();

            }
            catch (SqlException ex)
            {
                missatge = Orm.missatgeError(ex);
            }


            return usuaris;
        }

=======
>>>>>>> de205f61424069c788f49a9fe4d94e4ef9f7aa7c
        public static List<usuaris> Select(ref String missatge, int id_usuari)
        {
            List<usuaris> usuaris = new List<usuaris>();
            try
            {
                usuaris = Orm.bd.usuaris.Where(u => u.id == id_usuari).ToList();

            }
            catch (SqlException ex)
            {
                missatge = Orm.missatgeError(ex);
            }


            return usuaris;
        }
    }

}
