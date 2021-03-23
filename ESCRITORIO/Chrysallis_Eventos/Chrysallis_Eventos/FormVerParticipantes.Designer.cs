
namespace Chrysallis_Eventos
{
    partial class FormVerParticipantes
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
            this.labelTotalParticipantes = new System.Windows.Forms.Label();
            this.labelNumParticipants = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTotalParticipantes
            // 
            this.labelTotalParticipantes.AutoSize = true;
            this.labelTotalParticipantes.Location = new System.Drawing.Point(13, 13);
            this.labelTotalParticipantes.Name = "labelTotalParticipantes";
            this.labelTotalParticipantes.Size = new System.Drawing.Size(200, 17);
            this.labelTotalParticipantes.TabIndex = 0;
            this.labelTotalParticipantes.Text = "Total participantes apuntados:";
            // 
            // labelNumParticipants
            // 
            this.labelNumParticipants.AutoSize = true;
            this.labelNumParticipants.Location = new System.Drawing.Point(226, 13);
            this.labelNumParticipants.Name = "labelNumParticipants";
            this.labelNumParticipants.Size = new System.Drawing.Size(37, 17);
            this.labelNumParticipants.TabIndex = 1;
            this.labelNumParticipants.Text = "Num";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(648, 191);
            this.dataGridView1.TabIndex = 2;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonExit.FlatAppearance.BorderSize = 2;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(317, 245);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(172, 42);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Cerrar";
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // FormVerParticipantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 299);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelNumParticipants);
            this.Controls.Add(this.labelTotalParticipantes);
            this.Name = "FormVerParticipantes";
            this.Text = "FormVerParticipantes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTotalParticipantes;
        private System.Windows.Forms.Label labelNumParticipants;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonExit;
    }
}