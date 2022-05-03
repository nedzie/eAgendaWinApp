namespace eAgenda.WinApp.ModuloTarefa
{
    partial class TelaCadastrarTarefa
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
            this.labelTituloTarefa = new System.Windows.Forms.Label();
            this.textBoxTituloTarefa = new System.Windows.Forms.TextBox();
            this.comboBoxPrioridades = new System.Windows.Forms.ComboBox();
            this.labelPrioridade = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTituloTarefa
            // 
            this.labelTituloTarefa.AutoSize = true;
            this.labelTituloTarefa.Location = new System.Drawing.Point(12, 9);
            this.labelTituloTarefa.Name = "labelTituloTarefa";
            this.labelTituloTarefa.Size = new System.Drawing.Size(40, 15);
            this.labelTituloTarefa.TabIndex = 0;
            this.labelTituloTarefa.Text = "Título:";
            // 
            // textBoxTituloTarefa
            // 
            this.textBoxTituloTarefa.Location = new System.Drawing.Point(12, 27);
            this.textBoxTituloTarefa.Name = "textBoxTituloTarefa";
            this.textBoxTituloTarefa.Size = new System.Drawing.Size(246, 23);
            this.textBoxTituloTarefa.TabIndex = 1;
            // 
            // comboBoxPrioridades
            // 
            this.comboBoxPrioridades.FormattingEnabled = true;
            this.comboBoxPrioridades.Items.AddRange(new object[] {
            "Alta",
            "Média",
            "Baixa"});
            this.comboBoxPrioridades.Location = new System.Drawing.Point(12, 78);
            this.comboBoxPrioridades.Name = "comboBoxPrioridades";
            this.comboBoxPrioridades.Size = new System.Drawing.Size(121, 23);
            this.comboBoxPrioridades.TabIndex = 2;
            // 
            // labelPrioridade
            // 
            this.labelPrioridade.AutoSize = true;
            this.labelPrioridade.Location = new System.Drawing.Point(12, 60);
            this.labelPrioridade.Name = "labelPrioridade";
            this.labelPrioridade.Size = new System.Drawing.Size(64, 15);
            this.labelPrioridade.TabIndex = 3;
            this.labelPrioridade.Text = "Prioridade:";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.White;
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Location = new System.Drawing.Point(138, 107);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(120, 45);
            this.buttonCancelar.TabIndex = 20;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // buttonInserir
            // 
            this.buttonInserir.BackColor = System.Drawing.Color.White;
            this.buttonInserir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonInserir.FlatAppearance.BorderSize = 0;
            this.buttonInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInserir.Location = new System.Drawing.Point(12, 107);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(120, 45);
            this.buttonInserir.TabIndex = 19;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = false;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // TelaCadastrarTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(277, 165);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.labelPrioridade);
            this.Controls.Add(this.comboBoxPrioridades);
            this.Controls.Add(this.textBoxTituloTarefa);
            this.Controls.Add(this.labelTituloTarefa);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastrarTarefa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCadastrarTarefa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTituloTarefa;
        private System.Windows.Forms.TextBox textBoxTituloTarefa;
        private System.Windows.Forms.ComboBox comboBoxPrioridades;
        private System.Windows.Forms.Label labelPrioridade;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonInserir;
    }
}