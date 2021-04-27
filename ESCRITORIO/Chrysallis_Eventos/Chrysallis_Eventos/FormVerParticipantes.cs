using Chrysallis_Eventos.MODELOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chrysallis_Eventos
{
    public partial class FormVerParticipantes : Form
    {
        esdeveniments esdeveniment;
        public FormVerParticipantes(esdeveniments esdeveniment)
        {
            InitializeComponent();
            this.esdeveniment = esdeveniment;
        }

        private void FormVerParticipantes_Load(object sender, EventArgs e)
        {
            String missatge = "";

            labelNumParticipants.Text = esdeveniment.cont_assitents.ToString();
            bindingSourceParticipantes.DataSource = UsuarioOrm.SelectParticipants(ref missatge, esdeveniment.id);
        }
    }
}
