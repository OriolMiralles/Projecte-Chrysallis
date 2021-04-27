
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTotalParticipantes = new System.Windows.Forms.Label();
            this.labelNumParticipants = new System.Windows.Forms.Label();
            this.dataGridViewParticipantes = new System.Windows.Forms.DataGridView();
            this.buttonExit = new System.Windows.Forms.Button();
            this.ColumnNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNomSoci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAsistentes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTextValoracio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPuntuacio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipantes)).BeginInit();
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
            this.dataGridViewParticipantes.AllowUserToAddRows = false;
            this.dataGridViewParticipantes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewParticipantes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewParticipantes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewParticipantes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewParticipantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParticipantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNum,
            this.ColumnNomSoci,
            this.ColumnApellidos,
            this.ColumnAsistentes,
            this.ColumnTextValoracio,
            this.ColumnPuntuacio,
            this.ColumnId});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewParticipantes.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewParticipantes.Location = new System.Drawing.Point(13, 34);
            this.dataGridViewParticipantes.MultiSelect = false;
            this.dataGridViewParticipantes.Name = "dataGridViewParticipantes";
            this.dataGridViewParticipantes.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewParticipantes.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewParticipantes.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewParticipantes.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewParticipantes.RowTemplate.Height = 24;
            this.dataGridViewParticipantes.Size = new System.Drawing.Size(1024, 372);
            this.dataGridViewParticipantes.TabIndex = 2;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonExit.FlatAppearance.BorderSize = 2;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(865, 427);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(172, 42);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Cerrar";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // ColumnNum
            // 
            this.ColumnNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnNum.DataPropertyName = "numSoci";
            this.ColumnNum.HeaderText = "Número Socio";
            this.ColumnNum.MinimumWidth = 6;
            this.ColumnNum.Name = "ColumnNum";
            this.ColumnNum.ReadOnly = true;
            this.ColumnNum.Width = 124;
            // 
            // ColumnNomSoci
            // 
            this.ColumnNomSoci.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnNomSoci.DataPropertyName = "nomSoci";
            this.ColumnNomSoci.HeaderText = "Nombre";
            this.ColumnNomSoci.MinimumWidth = 6;
            this.ColumnNomSoci.Name = "ColumnNomSoci";
            this.ColumnNomSoci.ReadOnly = true;
            this.ColumnNomSoci.Width = 86;
            // 
            // ColumnApellidos
            // 
            this.ColumnApellidos.DataPropertyName = "cognoms";
            this.ColumnApellidos.HeaderText = "Apellidos";
            this.ColumnApellidos.MinimumWidth = 6;
            this.ColumnApellidos.Name = "ColumnApellidos";
            this.ColumnApellidos.ReadOnly = true;
            this.ColumnApellidos.Width = 125;
            // 
            // ColumnAsistentes
            // 
            this.ColumnAsistentes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnAsistentes.DataPropertyName = "asistents";
            this.ColumnAsistentes.HeaderText = "Asistentes";
            this.ColumnAsistentes.MinimumWidth = 6;
            this.ColumnAsistentes.Name = "ColumnAsistentes";
            this.ColumnAsistentes.ReadOnly = true;
            this.ColumnAsistentes.Width = 104;
            // 
            // ColumnTextValoracio
            // 
            this.ColumnTextValoracio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTextValoracio.DataPropertyName = "text";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnTextValoracio.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnTextValoracio.HeaderText = "Valoración";
            this.ColumnTextValoracio.MinimumWidth = 6;
            this.ColumnTextValoracio.Name = "ColumnTextValoracio";
            this.ColumnTextValoracio.ReadOnly = true;
            this.ColumnTextValoracio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnPuntuacio
            // 
            this.ColumnPuntuacio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnPuntuacio.DataPropertyName = "puntuacio";
            this.ColumnPuntuacio.HeaderText = "Puntuación";
            this.ColumnPuntuacio.MinimumWidth = 6;
            this.ColumnPuntuacio.Name = "ColumnPuntuacio";
            this.ColumnPuntuacio.ReadOnly = true;
            this.ColumnPuntuacio.Width = 109;
            // 
            // ColumnId
            // 
            this.ColumnId.DataPropertyName = "id";
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            this.ColumnId.Width = 125;
            // 
            // FormVerParticipantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1049, 481);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.dataGridViewParticipantes);
            this.Controls.Add(this.labelNumParticipants);
            this.Controls.Add(this.labelTotalParticipantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormVerParticipantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Participantes";
            this.Load += new System.EventHandler(this.FormVerParticipantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParticipantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTotalParticipantes;
        private System.Windows.Forms.Label labelNumParticipants;
        private System.Windows.Forms.DataGridView dataGridViewParticipantes;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomSoci;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAsistentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTextValoracio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPuntuacio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
    }
}