namespace eAgenda.WinApp.ModuloContato
{
    partial class TelaCadastrarContato
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
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxCargo = new System.Windows.Forms.TextBox();
            this.labelCargo = new System.Windows.Forms.Label();
            this.textBoxEmpresa = new System.Windows.Forms.TextBox();
            this.labelEmpresa = new System.Windows.Forms.Label();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.ForeColor = System.Drawing.Color.White;
            this.labelNome.Location = new System.Drawing.Point(52, 33);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(43, 15);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(52, 51);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(247, 23);
            this.textBoxNome.TabIndex = 0;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmail.Location = new System.Drawing.Point(52, 77);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(44, 15);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "E-mail:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(52, 95);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(247, 23);
            this.textBoxEmail.TabIndex = 1;
            // 
            // textBoxCargo
            // 
            this.textBoxCargo.Location = new System.Drawing.Point(52, 228);
            this.textBoxCargo.Name = "textBoxCargo";
            this.textBoxCargo.Size = new System.Drawing.Size(247, 23);
            this.textBoxCargo.TabIndex = 4;
            // 
            // labelCargo
            // 
            this.labelCargo.AutoSize = true;
            this.labelCargo.ForeColor = System.Drawing.Color.White;
            this.labelCargo.Location = new System.Drawing.Point(52, 210);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(42, 15);
            this.labelCargo.TabIndex = 6;
            this.labelCargo.Text = "Cargo:";
            // 
            // textBoxEmpresa
            // 
            this.textBoxEmpresa.Location = new System.Drawing.Point(53, 184);
            this.textBoxEmpresa.Name = "textBoxEmpresa";
            this.textBoxEmpresa.Size = new System.Drawing.Size(247, 23);
            this.textBoxEmpresa.TabIndex = 3;
            // 
            // labelEmpresa
            // 
            this.labelEmpresa.AutoSize = true;
            this.labelEmpresa.ForeColor = System.Drawing.Color.White;
            this.labelEmpresa.Location = new System.Drawing.Point(53, 166);
            this.labelEmpresa.Name = "labelEmpresa";
            this.labelEmpresa.Size = new System.Drawing.Size(55, 15);
            this.labelEmpresa.TabIndex = 4;
            this.labelEmpresa.Text = "Empresa:";
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(53, 139);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(247, 23);
            this.textBoxTelefone.TabIndex = 2;
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.ForeColor = System.Drawing.Color.White;
            this.labelTelefone.Location = new System.Drawing.Point(53, 121);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(54, 15);
            this.labelTelefone.TabIndex = 8;
            this.labelTelefone.Text = "Telefone:";
            // 
            // buttonInserir
            // 
            this.buttonInserir.BackColor = System.Drawing.Color.White;
            this.buttonInserir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonInserir.FlatAppearance.BorderSize = 0;
            this.buttonInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInserir.Location = new System.Drawing.Point(53, 268);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(120, 45);
            this.buttonInserir.TabIndex = 5;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = false;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.White;
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Location = new System.Drawing.Point(179, 268);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(120, 45);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // TelaCadastrarContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(368, 353);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.textBoxTelefone);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.textBoxCargo);
            this.Controls.Add(this.labelCargo);
            this.Controls.Add(this.textBoxEmpresa);
            this.Controls.Add(this.labelEmpresa);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastrarContato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar contato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxCargo;
        private System.Windows.Forms.Label labelCargo;
        private System.Windows.Forms.TextBox textBoxEmpresa;
        private System.Windows.Forms.Label labelEmpresa;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonCancelar;
    }
}