
namespace Chrysallis_Eventos
{
    partial class FormInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicial));
            this.buttonUsuarios = new System.Windows.Forms.Button();
            this.buttonEventos = new System.Windows.Forms.Button();
            this.buttonSocies = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUsuarios
            // 
            this.buttonUsuarios.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonUsuarios.FlatAppearance.BorderSize = 2;
            this.buttonUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsuarios.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsuarios.Location = new System.Drawing.Point(58, 261);
            this.buttonUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUsuarios.Name = "buttonUsuarios";
            this.buttonUsuarios.Size = new System.Drawing.Size(240, 46);
            this.buttonUsuarios.TabIndex = 1;
            this.buttonUsuarios.Text = "Socies";
            this.buttonUsuarios.UseVisualStyleBackColor = false;
            this.buttonUsuarios.Click += new System.EventHandler(this.buttonUsuarios_Click);
            // 
            // buttonEventos
            // 
            this.buttonEventos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEventos.FlatAppearance.BorderSize = 2;
            this.buttonEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEventos.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEventos.Location = new System.Drawing.Point(334, 261);
            this.buttonEventos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEventos.Name = "buttonEventos";
            this.buttonEventos.Size = new System.Drawing.Size(240, 46);
            this.buttonEventos.TabIndex = 2;
            this.buttonEventos.Text = "Eventos";
            this.buttonEventos.UseVisualStyleBackColor = false;
            this.buttonEventos.Click += new System.EventHandler(this.buttonEventos_Click);
            // 
            // buttonSocies
            // 
            this.buttonSocies.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSocies.FlatAppearance.BorderSize = 2;
            this.buttonSocies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSocies.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSocies.Location = new System.Drawing.Point(188, 361);
            this.buttonSocies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSocies.Name = "buttonSocies";
            this.buttonSocies.Size = new System.Drawing.Size(240, 46);
            this.buttonSocies.TabIndex = 3;
            this.buttonSocies.Text = "Usuaries";
            this.buttonSocies.UseVisualStyleBackColor = false;
            this.buttonSocies.Click += new System.EventHandler(this.buttonSocies_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(194)))), ((int)(((byte)(205)))));
            this.buttonLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLogout.FlatAppearance.BorderSize = 2;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(510, 11);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(106, 43);
            this.buttonLogout.TabIndex = 4;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Chrysallis_Eventos.Properties.Resources.NOU_LOGO_SIN_FONDO;
            this.pictureBox1.Location = new System.Drawing.Point(212, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FormInicial
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(639, 455);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonSocies);
            this.Controls.Add(this.buttonEventos);
            this.Controls.Add(this.buttonUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chrysallis";
            this.Load += new System.EventHandler(this.FormInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonUsuarios;
        private System.Windows.Forms.Button buttonEventos;
        private System.Windows.Forms.Button buttonSocies;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}