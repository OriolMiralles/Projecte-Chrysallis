
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTotalParticipantes = new System.Windows.Forms.Label();
            this.labelNumParticipants = new System.Windows.Forms.Label();
            this.dataGridViewParticipantes = new System.Windows.Forms.DataGridView();
            this.buttonExit = new System.Windows.Forms.Button();
            this.bindingSourceParticipantes = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceParticipantes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTotalParticipantes
            // 
            this.labelTotalParticipantes.AutoSize = true;
            this.labelTotalParticipantes.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalParticipantes.Location = new System.Drawing.Point(13, 13);
            this.labelTotalParticipantes.Name = "labelTotalParticipantes";
            this.labelTotalParticipantes.Size = new System.Drawing.Size(201, 18);
            this.labelTotalParticipantes.TabIndex = 0;
            this.labelTotalParticipantes.Text = "Total participantes apuntados:";
            // 
            // labelNumParticipants
            // 
            this.labelNumParticipants.AutoSize = true;
            this.labelNumParticipants.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumParticipants.Location = new System.Drawing.Point(226, 13);
            this.labelNumParticipants.Name = "labelNumParticipants";
            this.labelNumParticipants.Size = new System.Drawing.Size(36, 18);
            this.labelNumParticipants.TabIndex = 1;
            this.labelNumParticipants.Text = "Num";
            // 
            // dataGridViewParticipantes
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewParticipantes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewParticipantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewParticipantes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewParticipantes.Location = new System.Drawing.Point(13, 34);
            this.dataGridViewParticipantes.Name = "dataGridViewParticipantes";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewParticipantes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewParticipantes.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewParticipantes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewParticipantes.RowTemplate.Height = 24;
            this.dataGridViewParticipantes.Size = new System.Drawing.Size(539, 191);
            this.dataGridViewParticipantes.TabIndex = 2;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonExit.FlatAppearance.BorderSize = 2;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(380, 245);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(172, 42);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Cerrar";
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // bindingSourceParticipantes
            // 
            this.bindingSourceParticipantes.DataSource = typeof(Chrysallis_Eventos.MODELOS.socis);
            // 
            // FormVerParticipantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(564, 299);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.dataGridViewParticipantes);
            this.Controls.Add(this.labelNumParticipants);
            this.Controls.Add(this.labelTotalParticipantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormVerParticipantes";
            this.Text = "Participantes";
            this.Load += new System.EventHandler(this.FormVerParticipantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceParticipantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTotalParticipantes;
        private System.Windows.Forms.Label labelNumParticipants;
        private System.Windows.Forms.DataGridView dataGridViewParticipantes;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.BindingSource bindingSourceParticipantes;
    }
}