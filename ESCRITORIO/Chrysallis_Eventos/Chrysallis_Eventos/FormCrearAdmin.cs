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
    public partial class FormCrearAdmin : Form
    {
        public FormCrearAdmin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormCrearAdmin_Load(object sender, EventArgs e)
        {
            String missatge = "";
            List<rols> rols = RolsOrm.Select(ref missatge);
            if (missatge.Equals(""))
            {
                bindingSourceRols.DataSource = rols;
                comboBoxRol.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show(missatge, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void comboBoxRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxRol.SelectedIndex != -1)
            {
                rols rol = (rols)comboBoxRol.SelectedItem;
                String tipo = rol.nom.ToString();
                if (tipo.Equals("Administrador"))
                {
                    String missatge = "";
                    List<comunitats> comunitats = ComunitatsOrm.Select(ref missatge);
                    if (missatge.Equals(""))
                    {
                        bindingSourceComunitats.DataSource = comunitats;
                        comboBoxComunidades.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show(missatge, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            

        }
    }
}
