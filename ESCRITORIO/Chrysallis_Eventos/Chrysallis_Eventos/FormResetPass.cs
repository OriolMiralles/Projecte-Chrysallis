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
    public partial class FormResetPass : Form
    {
        usuaris _user;
        public FormResetPass(usuaris _user)
        {
            InitializeComponent();
            this._user = _user;
        }

        private void FormResetPass_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (textBoxNew.Text.Equals(""))
            {
                MessageBox.Show("Introducir una contraseña");
                textBoxNew.Focus();
            }
            else
            {
                if (textBoxConfirm.Text.Equals(""))
                {
                    MessageBox.Show("Confirmar la contraseña");
                    textBoxNew.Focus();
                }
                else
                {
                    if (comprobarContrasenya())
                    {
                        String password = textBoxNew.Text;
                        String passCryp = BCrypt.Net.BCrypt.EnhancedHashPassword(password, BCrypt.Net.HashType.SHA512);
                        _user.contrasenya = passCryp;
                        String missatge = AdminOrm.Update(_user);
                        if (missatge.Equals(""))
                        {
                            MessageBox.Show("Contraseña modificada correctamente");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        public bool comprobarContrasenya()
        {
            bool correcte = false;
            if(textBoxNew.Text.Length < 8 || textBoxConfirm.Text.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener almenos 8 caracteres");
            }
            else
            {
                if (textBoxNew.Text.Equals(textBoxConfirm.Text))
                {
                    correcte = true;
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
            }
            return correcte;
        }
    }
}
