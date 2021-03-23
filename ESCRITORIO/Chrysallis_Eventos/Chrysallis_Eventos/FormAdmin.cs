﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chrysallis_Eventos.MODELOS;
namespace Chrysallis_Eventos
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            List<usuaris> usuaris;
            if (User.SuperAdmin)
            {
                String missatge = "";
                usuaris = AdminOrm.Select(ref missatge);
            }
            else
            {
                String missatge = "";
                usuaris = AdminOrm.Select(ref missatge, User.id);
            }
        }
    }
}