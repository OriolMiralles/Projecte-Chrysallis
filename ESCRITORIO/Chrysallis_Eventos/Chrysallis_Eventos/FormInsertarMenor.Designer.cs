namespace Chrysallis_Eventos
{
    partial class FormInsertarMenor
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
            this.components = new System.ComponentModel.Container();
            this.buttonInsertarMenor = new System.Windows.Forms.Button();
            this.labelRelacionMenorUsuario = new System.Windows.Forms.Label();
            this.labelNombreMenorUsuario = new System.Windows.Forms.Label();
            this.textBoxRelacionMenorUsuario = new System.Windows.Forms.TextBox();
            this.textBoxNombreMenorUsuario = new System.Windows.Forms.TextBox();
            this.buttonFinalizar = new System.Windows.Forms.Button();
            this.bindingSourceMenors = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMenors)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonInsertarMenor
            // 
            this.buttonInsertarMenor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonInsertarMenor.FlatAppearance.BorderSize = 2;
            this.buttonInsertarMenor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsertarMenor.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertarMenor.Location = new System.Drawing.Point(372, 139);
            this.buttonInsertarMenor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInsertarMenor.Name = "buttonInsertarMenor";
            this.buttonInsertarMenor.Size = new System.Drawing.Size(172, 42);
            this.buttonInsertarMenor.TabIndex = 42;
            this.buttonInsertarMenor.Text = "Añadir menor";
            this.buttonInsertarMenor.UseVisualStyleBackColor = false;
            this.buttonInsertarMenor.Click += new System.EventHandler(this.buttonInsertarMenor_Click);
            // 
            // labelRelacionMenorUsuario
            // 
            this.labelRelacionMenorUsuario.AutoSize = true;
            this.labelRelacionMenorUsuario.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRelacionMenorUsuario.Location = new System.Drawing.Point(56, 90);
            this.labelRelacionMenorUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRelacionMenorUsuario.Name = "labelRelacionMenorUsuario";
            this.labelRelacionMenorUsuario.Size = new System.Drawing.Size(189, 23);
            this.labelRelacionMenorUsuario.TabIndex = 41;
            this.labelRelacionMenorUsuario.Text = "Realacion con el Menor:";
            // 
            // labelNombreMenorUsuario
            // 
            this.labelNombreMenorUsuario.AutoSize = true;
            this.labelNombreMenorUsuario.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreMenorUsuario.Location = new System.Drawing.Point(56, 52);
            this.labelNombreMenorUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombreMenorUsuario.Name = "labelNombreMenorUsuario";
            this.labelNombreMenorUsuario.Size = new System.Drawing.Size(154, 23);
            this.labelNombreMenorUsuario.TabIndex = 40;
            this.labelNombreMenorUsuario.Text = "Nombre del Menor:";
            // 
            // textBoxRelacionMenorUsuario
            // 
            this.textBoxRelacionMenorUsuario.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRelacionMenorUsuario.Location = new System.Drawing.Point(274, 90);
            this.textBoxRelacionMenorUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRelacionMenorUsuario.Name = "textBoxRelacionMenorUsuario";
            this.textBoxRelacionMenorUsuario.Size = new System.Drawing.Size(469, 23);
            this.textBoxRelacionMenorUsuario.TabIndex = 39;
            // 
            // textBoxNombreMenorUsuario
            // 
            this.textBoxNombreMenorUsuario.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreMenorUsuario.Location = new System.Drawing.Point(274, 47);
            this.textBoxNombreMenorUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombreMenorUsuario.Name = "textBoxNombreMenorUsuario";
            this.textBoxNombreMenorUsuario.Size = new System.Drawing.Size(469, 23);
            this.textBoxNombreMenorUsuario.TabIndex = 38;
            // 
            // buttonFinalizar
            // 
            this.buttonFinalizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonFinalizar.FlatAppearance.BorderSize = 2;
            this.buttonFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFinalizar.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinalizar.Location = new System.Drawing.Point(571, 139);
            this.buttonFinalizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFinalizar.Name = "buttonFinalizar";
            this.buttonFinalizar.Size = new System.Drawing.Size(172, 42);
            this.buttonFinalizar.TabIndex = 43;
            this.buttonFinalizar.Text = "Finalizar";
            this.buttonFinalizar.UseVisualStyleBackColor = false;
            this.buttonFinalizar.Click += new System.EventHandler(this.buttonFinalizar_Click);
            // 
            // bindingSourceMenors
            // 
            this.bindingSourceMenors.DataSource = typeof(Chrysallis_Eventos.MODELOS.menors_socis);
            // 
            // FormInsertarMenor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 242);
            this.Controls.Add(this.buttonFinalizar);
            this.Controls.Add(this.buttonInsertarMenor);
            this.Controls.Add(this.labelRelacionMenorUsuario);
            this.Controls.Add(this.labelNombreMenorUsuario);
            this.Controls.Add(this.textBoxRelacionMenorUsuario);
            this.Controls.Add(this.textBoxNombreMenorUsuario);
            this.Name = "FormInsertarMenor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Insertar menor";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMenors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonInsertarMenor;
        private System.Windows.Forms.Label labelRelacionMenorUsuario;
        private System.Windows.Forms.Label labelNombreMenorUsuario;
        private System.Windows.Forms.TextBox textBoxRelacionMenorUsuario;
        private System.Windows.Forms.TextBox textBoxNombreMenorUsuario;
        private System.Windows.Forms.BindingSource bindingSourceMenors;
        private System.Windows.Forms.Button buttonFinalizar;
    }
}