﻿
namespace Chrysallis_Eventos
{
    partial class FormUsuaris
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBoxBuscar = new System.Windows.Forms.GroupBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscarUser = new System.Windows.Forms.TextBox();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.groupBoxBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddUser,
            this.toolStripButtonEditUser,
            this.toolStripButtonDelUser,
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAddUser
            // 
            this.toolStripButtonAddUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddUser.Image = global::Chrysallis_Eventos.Properties.Resources.add_32px;
            this.toolStripButtonAddUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddUser.Name = "toolStripButtonAddUser";
            this.toolStripButtonAddUser.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonAddUser.Text = "toolStripButton1";
            // 
            // toolStripButtonEditUser
            // 
            this.toolStripButtonEditUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditUser.Image = global::Chrysallis_Eventos.Properties.Resources.edit_file_32px;
            this.toolStripButtonEditUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditUser.Name = "toolStripButtonEditUser";
            this.toolStripButtonEditUser.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonEditUser.Text = "toolStripButton2";
            // 
            // toolStripButtonDelUser
            // 
            this.toolStripButtonDelUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelUser.Image = global::Chrysallis_Eventos.Properties.Resources.delete_bin_32px;
            this.toolStripButtonDelUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelUser.Name = "toolStripButtonDelUser";
            this.toolStripButtonDelUser.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonDelUser.Text = "toolStripButton3";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Chrysallis_Eventos.Properties.Resources.exit_32px;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // groupBoxBuscar
            // 
            this.groupBoxBuscar.Controls.Add(this.buttonBuscar);
            this.groupBoxBuscar.Controls.Add(this.textBoxBuscarUser);
            this.groupBoxBuscar.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBuscar.Location = new System.Drawing.Point(12, 30);
            this.groupBoxBuscar.Name = "groupBoxBuscar";
            this.groupBoxBuscar.Size = new System.Drawing.Size(776, 65);
            this.groupBoxBuscar.TabIndex = 1;
            this.groupBoxBuscar.TabStop = false;
            this.groupBoxBuscar.Text = "Buscar";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonBuscar.FlatAppearance.BorderSize = 2;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.Location = new System.Drawing.Point(643, 15);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(109, 41);
            this.buttonBuscar.TabIndex = 1;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            // 
            // textBoxBuscarUser
            // 
            this.textBoxBuscarUser.Location = new System.Drawing.Point(16, 24);
            this.textBoxBuscarUser.Name = "textBoxBuscarUser";
            this.textBoxBuscarUser.Size = new System.Drawing.Size(602, 23);
            this.textBoxBuscarUser.TabIndex = 0;
            // 
            // dataGridViewUsers
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewUsers.Location = new System.Drawing.Point(13, 102);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewUsers.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewUsers.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewUsers.RowTemplate.Height = 24;
            this.dataGridViewUsers.Size = new System.Drawing.Size(775, 336);
            this.dataGridViewUsers.TabIndex = 2;
            // 
            // FormUsuaris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.groupBoxBuscar);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormUsuaris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Usuarios Chrysallis";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBoxBuscar.ResumeLayout(false);
            this.groupBoxBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddUser;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditUser;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.GroupBox groupBoxBuscar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscarUser;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
    }
}