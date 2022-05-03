namespace eAgenda.WinApp
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCompromisso = new System.Windows.Forms.Button();
            this.buttonContato = new System.Windows.Forms.Button();
            this.buttonTarefa = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCompromisso
            // 
            this.buttonCompromisso.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCompromisso.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCompromisso.FlatAppearance.BorderSize = 0;
            this.buttonCompromisso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonCompromisso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCompromisso.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCompromisso.Location = new System.Drawing.Point(12, 12);
            this.buttonCompromisso.Name = "buttonCompromisso";
            this.buttonCompromisso.Size = new System.Drawing.Size(180, 90);
            this.buttonCompromisso.TabIndex = 0;
            this.buttonCompromisso.Text = "Compromisso";
            this.buttonCompromisso.UseVisualStyleBackColor = false;
            this.buttonCompromisso.Click += new System.EventHandler(this.buttonCompromisso_Click);
            // 
            // buttonContato
            // 
            this.buttonContato.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonContato.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonContato.FlatAppearance.BorderSize = 0;
            this.buttonContato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.buttonContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContato.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonContato.Location = new System.Drawing.Point(252, 12);
            this.buttonContato.Name = "buttonContato";
            this.buttonContato.Size = new System.Drawing.Size(180, 90);
            this.buttonContato.TabIndex = 1;
            this.buttonContato.Text = "Contato";
            this.buttonContato.UseVisualStyleBackColor = false;
            this.buttonContato.Click += new System.EventHandler(this.buttonContato_Click);
            // 
            // buttonTarefa
            // 
            this.buttonTarefa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonTarefa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonTarefa.FlatAppearance.BorderSize = 0;
            this.buttonTarefa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.buttonTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTarefa.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTarefa.Location = new System.Drawing.Point(492, 12);
            this.buttonTarefa.Name = "buttonTarefa";
            this.buttonTarefa.Size = new System.Drawing.Size(180, 90);
            this.buttonTarefa.TabIndex = 2;
            this.buttonTarefa.Text = "Tarefa";
            this.buttonTarefa.UseVisualStyleBackColor = false;
            this.buttonTarefa.Click += new System.EventHandler(this.buttonTarefa_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSair.FlatAppearance.BorderSize = 0;
            this.buttonSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSair.Location = new System.Drawing.Point(252, 132);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(180, 90);
            this.buttonSair.TabIndex = 3;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(682, 237);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonTarefa);
            this.Controls.Add(this.buttonContato);
            this.Controls.Add(this.buttonCompromisso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Início - eAgenda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCompromisso;
        private System.Windows.Forms.Button buttonContato;
        private System.Windows.Forms.Button buttonTarefa;
        private System.Windows.Forms.Button buttonSair;
    }
}
