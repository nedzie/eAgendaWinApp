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
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelLocal = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelAssunto = new System.Windows.Forms.Label();
            this.maskedTextBoxData = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxHoraFim = new System.Windows.Forms.MaskedTextBox();
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
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(12, 71);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(247, 23);
            this.textBoxEmail.TabIndex = 11;
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
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 27);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(247, 23);
            this.textBoxNome.TabIndex = 9;
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
            // TelaCadastrarCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(271, 306);
            this.Controls.Add(this.maskedTextBoxHoraFim);
            this.Controls.Add(this.maskedTextBoxHoraInicio);
            this.Controls.Add(this.maskedTextBoxData);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelHoraFim);
            this.Controls.Add(this.labelHoraInicio);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelLocal);
            this.Controls.Add(this.textBoxNome);
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
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelLocal;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelAssunto;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxData;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHoraInicio;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHoraFim;
    }
}