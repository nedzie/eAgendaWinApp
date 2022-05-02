namespace eAgenda.WinApp.ModuloCompromisso
{
    partial class TelaCadastrarCompromisso
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.labelData = new System.Windows.Forms.Label();
            this.labelHoraFim = new System.Windows.Forms.Label();
            this.labelHoraInicio = new System.Windows.Forms.Label();
            this.textBoxLocal = new System.Windows.Forms.TextBox();
            this.labelLocal = new System.Windows.Forms.Label();
            this.textBoxAssunto = new System.Windows.Forms.TextBox();
            this.labelAssunto = new System.Windows.Forms.Label();
            this.maskedTextBoxData = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxHoraFim = new System.Windows.Forms.MaskedTextBox();
            this.listBoxContatos = new System.Windows.Forms.ListBox();
            this.labelContatoAtual = new System.Windows.Forms.Label();
            this.labelContato = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.White;
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Location = new System.Drawing.Point(139, 244);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(120, 45);
            this.buttonCancelar.TabIndex = 18;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonInserir
            // 
            this.buttonInserir.BackColor = System.Drawing.Color.White;
            this.buttonInserir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonInserir.FlatAppearance.BorderSize = 0;
            this.buttonInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInserir.Location = new System.Drawing.Point(13, 244);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(120, 45);
            this.buttonInserir.TabIndex = 17;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = false;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.ForeColor = System.Drawing.Color.White;
            this.labelData.Location = new System.Drawing.Point(13, 97);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(34, 15);
            this.labelData.TabIndex = 20;
            this.labelData.Text = "Data:";
            // 
            // labelHoraFim
            // 
            this.labelHoraFim.AutoSize = true;
            this.labelHoraFim.ForeColor = System.Drawing.Color.White;
            this.labelHoraFim.Location = new System.Drawing.Point(12, 186);
            this.labelHoraFim.Name = "labelHoraFim";
            this.labelHoraFim.Size = new System.Drawing.Size(57, 15);
            this.labelHoraFim.TabIndex = 19;
            this.labelHoraFim.Text = "Hora fim:";
            // 
            // labelHoraInicio
            // 
            this.labelHoraInicio.AutoSize = true;
            this.labelHoraInicio.ForeColor = System.Drawing.Color.White;
            this.labelHoraInicio.Location = new System.Drawing.Point(13, 142);
            this.labelHoraInicio.Name = "labelHoraInicio";
            this.labelHoraInicio.Size = new System.Drawing.Size(68, 15);
            this.labelHoraInicio.TabIndex = 16;
            this.labelHoraInicio.Text = "Hora início:";
            // 
            // textBoxLocal
            // 
            this.textBoxLocal.Location = new System.Drawing.Point(12, 71);
            this.textBoxLocal.Name = "textBoxLocal";
            this.textBoxLocal.Size = new System.Drawing.Size(247, 23);
            this.textBoxLocal.TabIndex = 11;
            // 
            // labelLocal
            // 
            this.labelLocal.AutoSize = true;
            this.labelLocal.ForeColor = System.Drawing.Color.White;
            this.labelLocal.Location = new System.Drawing.Point(12, 53);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(38, 15);
            this.labelLocal.TabIndex = 13;
            this.labelLocal.Text = "Local:";
            // 
            // textBoxAssunto
            // 
            this.textBoxAssunto.Location = new System.Drawing.Point(12, 27);
            this.textBoxAssunto.Name = "textBoxAssunto";
            this.textBoxAssunto.Size = new System.Drawing.Size(247, 23);
            this.textBoxAssunto.TabIndex = 9;
            // 
            // labelAssunto
            // 
            this.labelAssunto.AutoSize = true;
            this.labelAssunto.ForeColor = System.Drawing.Color.White;
            this.labelAssunto.Location = new System.Drawing.Point(12, 9);
            this.labelAssunto.Name = "labelAssunto";
            this.labelAssunto.Size = new System.Drawing.Size(53, 15);
            this.labelAssunto.TabIndex = 10;
            this.labelAssunto.Text = "Assunto:";
            // 
            // maskedTextBoxData
            // 
            this.maskedTextBoxData.Location = new System.Drawing.Point(13, 116);
            this.maskedTextBoxData.Mask = "00/00/0000";
            this.maskedTextBoxData.Name = "maskedTextBoxData";
            this.maskedTextBoxData.Size = new System.Drawing.Size(246, 23);
            this.maskedTextBoxData.TabIndex = 21;
            this.maskedTextBoxData.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxHoraInicio
            // 
            this.maskedTextBoxHoraInicio.Location = new System.Drawing.Point(13, 160);
            this.maskedTextBoxHoraInicio.Mask = "00:00";
            this.maskedTextBoxHoraInicio.Name = "maskedTextBoxHoraInicio";
            this.maskedTextBoxHoraInicio.Size = new System.Drawing.Size(246, 23);
            this.maskedTextBoxHoraInicio.TabIndex = 22;
            this.maskedTextBoxHoraInicio.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxHoraFim
            // 
            this.maskedTextBoxHoraFim.Location = new System.Drawing.Point(12, 204);
            this.maskedTextBoxHoraFim.Mask = "00:00";
            this.maskedTextBoxHoraFim.Name = "maskedTextBoxHoraFim";
            this.maskedTextBoxHoraFim.Size = new System.Drawing.Size(246, 23);
            this.maskedTextBoxHoraFim.TabIndex = 23;
            this.maskedTextBoxHoraFim.ValidatingType = typeof(System.DateTime);
            // 
            // listBoxContatos
            // 
            this.listBoxContatos.FormattingEnabled = true;
            this.listBoxContatos.ItemHeight = 15;
            this.listBoxContatos.Location = new System.Drawing.Point(274, 72);
            this.listBoxContatos.Name = "listBoxContatos";
            this.listBoxContatos.Size = new System.Drawing.Size(690, 214);
            this.listBoxContatos.TabIndex = 24;
            // 
            // labelContatoAtual
            // 
            this.labelContatoAtual.AutoSize = true;
            this.labelContatoAtual.Location = new System.Drawing.Point(274, 27);
            this.labelContatoAtual.Name = "labelContatoAtual";
            this.labelContatoAtual.Size = new System.Drawing.Size(82, 15);
            this.labelContatoAtual.TabIndex = 25;
            this.labelContatoAtual.Text = "Contato atual:";
            // 
            // labelContato
            // 
            this.labelContato.AutoSize = true;
            this.labelContato.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelContato.Location = new System.Drawing.Point(362, 27);
            this.labelContato.Name = "labelContato";
            this.labelContato.Size = new System.Drawing.Size(55, 15);
            this.labelContato.TabIndex = 26;
            this.labelContato.Text = "Nenhum";
            // 
            // TelaCadastrarCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(976, 306);
            this.Controls.Add(this.labelContato);
            this.Controls.Add(this.labelContatoAtual);
            this.Controls.Add(this.listBoxContatos);
            this.Controls.Add(this.maskedTextBoxHoraFim);
            this.Controls.Add(this.maskedTextBoxHoraInicio);
            this.Controls.Add(this.maskedTextBoxData);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelHoraFim);
            this.Controls.Add(this.labelHoraInicio);
            this.Controls.Add(this.textBoxLocal);
            this.Controls.Add(this.labelLocal);
            this.Controls.Add(this.textBoxAssunto);
            this.Controls.Add(this.labelAssunto);
            this.Name = "TelaCadastrarCompromisso";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajustar Compromisso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelHoraFim;
        private System.Windows.Forms.Label labelHoraInicio;
        private System.Windows.Forms.TextBox textBoxLocal;
        private System.Windows.Forms.Label labelLocal;
        private System.Windows.Forms.TextBox textBoxAssunto;
        private System.Windows.Forms.Label labelAssunto;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxData;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHoraInicio;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHoraFim;
        private System.Windows.Forms.ListBox listBoxContatos;
        private System.Windows.Forms.Label labelContatoAtual;
        private System.Windows.Forms.Label labelContato;
    }
}