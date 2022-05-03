namespace eAgenda.WinApp.ModuloCompromisso
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
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.tabControlCompromissos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBoxCompromissosPassados = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.labelFim = new System.Windows.Forms.Label();
            this.labelInicio = new System.Windows.Forms.Label();
            this.maskedTextBoxFim = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxInicio = new System.Windows.Forms.MaskedTextBox();
            this.listBoxCompromissosFuturos = new System.Windows.Forms.ListBox();
            this.buttonVisualizarNormal = new System.Windows.Forms.Button();
            this.tabControlCompromissos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.White;
            this.buttonSair.FlatAppearance.BorderSize = 0;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Location = new System.Drawing.Point(12, 216);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(120, 45);
            this.buttonSair.TabIndex = 10;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.BackColor = System.Drawing.Color.White;
            this.buttonExcluir.FlatAppearance.BorderSize = 0;
            this.buttonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluir.Location = new System.Drawing.Point(12, 165);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(120, 45);
            this.buttonExcluir.TabIndex = 9;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = false;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
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
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
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
            this.tabControlCompromissos.Size = new System.Drawing.Size(967, 393);
            this.tabControlCompromissos.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBoxCompromissosPassados);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(959, 365);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Compromissos passados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBoxCompromissosPassados
            // 
            this.listBoxCompromissosPassados.FormattingEnabled = true;
            this.listBoxCompromissosPassados.ItemHeight = 15;
            this.listBoxCompromissosPassados.Location = new System.Drawing.Point(3, 6);
            this.listBoxCompromissosPassados.Name = "listBoxCompromissosPassados";
            this.listBoxCompromissosPassados.Size = new System.Drawing.Size(950, 259);
            this.listBoxCompromissosPassados.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonFiltrar);
            this.tabPage2.Controls.Add(this.labelFim);
            this.tabPage2.Controls.Add(this.labelInicio);
            this.tabPage2.Controls.Add(this.maskedTextBoxFim);
            this.tabPage2.Controls.Add(this.maskedTextBoxInicio);
            this.tabPage2.Controls.Add(this.listBoxCompromissosFuturos);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(959, 365);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Compromissos futuros";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.BackColor = System.Drawing.Color.DimGray;
            this.buttonFiltrar.FlatAppearance.BorderSize = 0;
            this.buttonFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFiltrar.ForeColor = System.Drawing.Color.White;
            this.buttonFiltrar.Location = new System.Drawing.Point(797, 109);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(145, 23);
            this.buttonFiltrar.TabIndex = 14;
            this.buttonFiltrar.Text = "Filtrar por período";
            this.buttonFiltrar.UseVisualStyleBackColor = false;
            this.buttonFiltrar.Click += new System.EventHandler(this.buttonFiltrar_Click);
            // 
            // labelFim
            // 
            this.labelFim.AutoSize = true;
            this.labelFim.Location = new System.Drawing.Point(797, 68);
            this.labelFim.Name = "labelFim";
            this.labelFim.Size = new System.Drawing.Size(30, 15);
            this.labelFim.TabIndex = 15;
            this.labelFim.Text = "Fim:";
            // 
            // labelInicio
            // 
            this.labelInicio.AutoSize = true;
            this.labelInicio.Location = new System.Drawing.Point(797, 27);
            this.labelInicio.Name = "labelInicio";
            this.labelInicio.Size = new System.Drawing.Size(39, 15);
            this.labelInicio.TabIndex = 14;
            this.labelInicio.Text = "Início:";
            // 
            // maskedTextBoxFim
            // 
            this.maskedTextBoxFim.Location = new System.Drawing.Point(842, 65);
            this.maskedTextBoxFim.Mask = "00/00/0000";
            this.maskedTextBoxFim.Name = "maskedTextBoxFim";
            this.maskedTextBoxFim.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxFim.TabIndex = 3;
            this.maskedTextBoxFim.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxInicio
            // 
            this.maskedTextBoxInicio.Location = new System.Drawing.Point(842, 27);
            this.maskedTextBoxInicio.Mask = "00/00/0000";
            this.maskedTextBoxInicio.Name = "maskedTextBoxInicio";
            this.maskedTextBoxInicio.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxInicio.TabIndex = 2;
            this.maskedTextBoxInicio.ValidatingType = typeof(System.DateTime);
            // 
            // listBoxCompromissosFuturos
            // 
            this.listBoxCompromissosFuturos.FormattingEnabled = true;
            this.listBoxCompromissosFuturos.ItemHeight = 15;
            this.listBoxCompromissosFuturos.Location = new System.Drawing.Point(5, 7);
            this.listBoxCompromissosFuturos.Name = "listBoxCompromissosFuturos";
            this.listBoxCompromissosFuturos.Size = new System.Drawing.Size(948, 349);
            this.listBoxCompromissosFuturos.TabIndex = 1;
            // 
            // buttonVisualizarNormal
            // 
            this.buttonVisualizarNormal.BackColor = System.Drawing.Color.White;
            this.buttonVisualizarNormal.FlatAppearance.BorderSize = 0;
            this.buttonVisualizarNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVisualizarNormal.Location = new System.Drawing.Point(12, 114);
            this.buttonVisualizarNormal.Name = "buttonVisualizarNormal";
            this.buttonVisualizarNormal.Size = new System.Drawing.Size(120, 45);
            this.buttonVisualizarNormal.TabIndex = 14;
            this.buttonVisualizarNormal.Text = "Visualizar normal";
            this.buttonVisualizarNormal.UseVisualStyleBackColor = false;
            this.buttonVisualizarNormal.Click += new System.EventHandler(this.buttonVisualizarNormal_Click);
            // 
            // TelaCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1117, 417);
            this.Controls.Add(this.buttonVisualizarNormal);
            this.Controls.Add(this.tabControlCompromissos);
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.TabControl tabControlCompromissos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBoxCompromissosPassados;
        private System.Windows.Forms.ListBox listBoxCompromissosFuturos;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.Label labelFim;
        private System.Windows.Forms.Label labelInicio;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxFim;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxInicio;
        private System.Windows.Forms.Button buttonVisualizarNormal;
    }
}