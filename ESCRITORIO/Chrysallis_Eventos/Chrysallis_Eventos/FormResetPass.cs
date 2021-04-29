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
        socis _soci;
        Boolean modificarUser;
        public FormResetPass(usuaris _user)
        {
            InitializeComponent();
            this._user = _user;
            modificarUser = true;
        }
        public FormResetPass(socis soci)
        {
            InitializeComponent();
            this._soci = soci;
            modificarUser = false;
        }

        private void FormResetPass_Load(object sender, EventArgs e)
        {
            if (modificarUser)
            {
                labelNombre.Text = _user.username.ToString();
            }
            else
            {
                labelNombre.Text = _soci.nom.ToString();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (textBoxNew.Text.Equals(""))
            {
                MessageBox.Show("Introducir una contraseña", "Advertencia",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNew.Focus();
            }
            else
            {
                if (textBoxConfirm.Text.Equals(""))
                {
                    MessageBox.Show("Confirmar la contraseña", "Advertencia",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxNew.Focus();
                }
                else
                {
                    if (comprobarContrasenya())
                    {
                        String password = textBoxNew.Text;

                        String missatge = "";
                        if (modificarUser)
                        {
                            String passCryp = BCrypt.Net.BCrypt.EnhancedHashPassword(password, BCrypt.Net.HashType.SHA512);
                            _user.contrasenya = passCryp;
                            missatge = AdminOrm.Update(_user);
                            if (missatge.Equals(""))
                            {
                                MessageBox.Show("Contraseña modificada correctamente", "Información",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            String passCryp = BCrypt.Net.BCrypt.HashPassword(password);
                            _soci.contrasenya = passCryp;
                            missatge = UsuarioOrm.Update(ref missatge, _soci);
                            if (missatge.Equals(""))
                            {
                                MessageBox.Show("Contraseña modificada correctamente", "Información",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        public bool comprobarContrasenya()
        {
            bool correcte = false;
            if (textBoxNew.Text.Length < 8 || textBoxConfirm.Text.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener almenos 8 caracteres", "Advertencia",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (textBoxNew.Text.Equals(textBoxConfirm.Text))
                {
                    correcte = true;
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Advertencia",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            return correcte;
        }
    }
}
