﻿namespace eAgenda.WinApp.ModuloCompromisso
{
    partial class TelaCompromisso
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
            this.buttonVisualizarNormal = new System.Windows.Forms.Button();
            this.buttonVisualizarCargo = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.tabControlCompromissos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControlCompromissos.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonVisualizarNormal
            // 
            this.buttonVisualizarNormal.BackColor = System.Drawing.Color.White;
            this.buttonVisualizarNormal.FlatAppearance.BorderSize = 0;
            this.buttonVisualizarNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVisualizarNormal.Location = new System.Drawing.Point(12, 165);
            this.buttonVisualizarNormal.Name = "buttonVisualizarNormal";
            this.buttonVisualizarNormal.Size = new System.Drawing.Size(120, 45);
            this.buttonVisualizarNormal.TabIndex = 12;
            this.buttonVisualizarNormal.Text = "Visualizar normal";
            this.buttonVisualizarNormal.UseVisualStyleBackColor = false;
            // 
            // buttonVisualizarCargo
            // 
            this.buttonVisualizarCargo.BackColor = System.Drawing.Color.White;
            this.buttonVisualizarCargo.FlatAppearance.BorderSize = 0;
            this.buttonVisualizarCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVisualizarCargo.Location = new System.Drawing.Point(12, 216);
            this.buttonVisualizarCargo.Name = "buttonVisualizarCargo";
            this.buttonVisualizarCargo.Size = new System.Drawing.Size(120, 45);
            this.buttonVisualizarCargo.TabIndex = 11;
            this.buttonVisualizarCargo.Text = "Agrupar por cargo";
            this.buttonVisualizarCargo.UseVisualStyleBackColor = false;
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.White;
            this.buttonSair.FlatAppearance.BorderSize = 0;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Location = new System.Drawing.Point(12, 267);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(120, 45);
            this.buttonSair.TabIndex = 10;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.BackColor = System.Drawing.Color.White;
            this.buttonExcluir.FlatAppearance.BorderSize = 0;
            this.buttonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluir.Location = new System.Drawing.Point(12, 114);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(120, 45);
            this.buttonExcluir.TabIndex = 9;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = false;
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.White;
            this.buttonEditar.FlatAppearance.BorderSize = 0;
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditar.Location = new System.Drawing.Point(12, 63);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(120, 45);
            this.buttonEditar.TabIndex = 8;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            // 
            // buttonInserir
            // 
            this.buttonInserir.BackColor = System.Drawing.Color.White;
            this.buttonInserir.FlatAppearance.BorderSize = 0;
            this.buttonInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInserir.Location = new System.Drawing.Point(12, 12);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(120, 45);
            this.buttonInserir.TabIndex = 7;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = false;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // tabControlCompromissos
            // 
            this.tabControlCompromissos.Controls.Add(this.tabPage1);
            this.tabControlCompromissos.Controls.Add(this.tabPage2);
            this.tabControlCompromissos.Location = new System.Drawing.Point(138, 12);
            this.tabControlCompromissos.Name = "tabControlCompromissos";
            this.tabControlCompromissos.SelectedIndex = 0;
            this.tabControlCompromissos.Size = new System.Drawing.Size(650, 300);
            this.tabControlCompromissos.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(642, 272);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Compromissos passados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(642, 272);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Compromissos futuros";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TelaCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlCompromissos);
            this.Controls.Add(this.buttonVisualizarNormal);
            this.Controls.Add(this.buttonVisualizarCargo);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonInserir);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCompromisso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Compromisso";
            this.tabControlCompromissos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVisualizarNormal;
        private System.Windows.Forms.Button buttonVisualizarCargo;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.TabControl tabControlCompromissos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}