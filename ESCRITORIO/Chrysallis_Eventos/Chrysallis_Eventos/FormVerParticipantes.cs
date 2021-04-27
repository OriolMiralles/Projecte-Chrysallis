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
            labelNumParticipants.Text = esdeveniment.cont_assitents.ToString();
            var participants = AsistirOrm.Select(esdeveniment);
            dataGridViewParticipantes.DataSource = participants;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
