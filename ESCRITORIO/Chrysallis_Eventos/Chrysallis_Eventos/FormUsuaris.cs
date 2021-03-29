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
    public partial class FormUsuaris : Form
    {
        public const int COMUNIDAD_POR_DEFECTO = 7;
        public FormUsuaris()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FormUsuaris_Load(object sender, EventArgs e)
        {
            String missatge = "";

           

            if (User.SuperAdmin)
            {            
                comboBoxComunidades.DataSource = ComunitatsOrm.Select(ref missatge);
                comboBoxComunidades.SelectedIndex = COMUNIDAD_POR_DEFECTO;
            }
            else
            {
                List<usuaris> _usuaris = AdminOrm.Select(ref missatge, User.id);

                comboBoxComunidades.DataSource = _usuaris[0].comunitats.ToList();
            }
           

            if (!missatge.Equals(""))
            {
                MessageBox.Show(missatge,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void toolStripButtonAddUser_Click(object sender, EventArgs e)
        {
            FormInsertarUsuario fiu = new FormInsertarUsuario();
            fiu.ShowDialog();
        }
    }
}
