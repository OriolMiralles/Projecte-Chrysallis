using System;
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
    public partial class FormInsertarEventos : Form
    {
        public comunitats comunitat;
        public esdeveniments esdeveniment;
        public Boolean modificar = false;

        public FormInsertarEventos(comunitats comunitat)
        {
            InitializeComponent();
            this.comunitat = comunitat;
        }

        public FormInsertarEventos(esdeveniments esdeveniment)
        {
            InitializeComponent();
            this.esdeveniment = esdeveniment;
            this.modificar = true;
        }

        private void FormInsertarEventos_Load(object sender, EventArgs e)
        {
            if (!modificar)
            {
                textBoxComunidadEvento.Text = comunitat.nom;

            }
            else{
                textBoxTituloEvento.Text = esdeveniment.titol;

            }
        }
    }
}
