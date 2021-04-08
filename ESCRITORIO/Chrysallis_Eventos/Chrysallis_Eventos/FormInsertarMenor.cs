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
    public partial class FormInsertarMenor : Form
    {
        public socis _soci;
        public FormInsertarMenor(socis _soci)
        {
            InitializeComponent();
            this._soci = _soci;
        }

        private void buttonInsertarMenor_Click(object sender, EventArgs e)
        {
            if (comprobacion())
            {
                String missatge = "";
                menors menor = new menors();
                menor.nom = textBoxNombreMenorUsuario.Text;
                MenorOrm.Insert(menor);
                List<menors> _menors = MenorOrm.Select(ref missatge, menor.nom);
                menors _men = _menors[_menors.Count - 1];
                menors_socis menor_soci = new menors_socis();
                menor_soci.id_menor = _men.id;
                menor_soci.id_soci = _soci.id;
                menor_soci.relacio = textBoxRelacionMenorUsuario.Text;
                missatge = MenorOrm.Insert(menor_soci);
                if (missatge.Equals(""))
                {
                    MessageBox.Show("Menor insertado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxNombreMenorUsuario.Text="";
                    textBoxRelacionMenorUsuario.Text = "";
                }
            }

        }

        private bool comprobacion()
        {
            bool correcto = true;
            if (textBoxNombreMenorUsuario.Equals(""))
            {
                MessageBox.Show("Hay que escribir un nombre de menor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNombreMenorUsuario.Focus();
                correcto = false;
            }
            else if (textBoxRelacionMenorUsuario.Equals(""))
            {
                MessageBox.Show("Hay que escribir una relación del menor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxRelacionMenorUsuario.Focus();
                correcto = false;
            }
            return correcto;
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            String missatge = "";
            List<menors_socis> menors = MenorOrm.Select(ref missatge, _soci);
            if (menors.Count == 0)
            {
                MessageBox.Show("Hay que introducir al menos 1 menor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Close();
            }
            
        }
    }
}
