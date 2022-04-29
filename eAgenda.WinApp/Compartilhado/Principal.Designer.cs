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
            this.SuspendLayout();
            // 
            // buttonCompromisso
            // 
            this.buttonCompromisso.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCompromisso.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCompromisso.FlatAppearance.BorderSize = 0;
            this.buttonCompromisso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCompromisso.Location = new System.Drawing.Point(91, 64);
            this.buttonCompromisso.Name = "buttonCompromisso";
            this.buttonCompromisso.Size = new System.Drawing.Size(120, 45);
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
            this.buttonContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContato.Location = new System.Drawing.Point(233, 64);
            this.buttonContato.Name = "buttonContato";
            this.buttonContato.Size = new System.Drawing.Size(120, 45);
            this.buttonContato.TabIndex = 1;
            this.buttonContato.Text = "Contato";
            this.buttonContato.UseVisualStyleBackColor = false;
            // 
            // buttonTarefa
            // 
            this.buttonTarefa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonTarefa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonTarefa.FlatAppearance.BorderSize = 0;
            this.buttonTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTarefa.Location = new System.Drawing.Point(373, 64);
            this.buttonTarefa.Name = "buttonTarefa";
            this.buttonTarefa.Size = new System.Drawing.Size(120, 45);
            this.buttonTarefa.TabIndex = 2;
            this.buttonTarefa.Text = "Tarefa";
            this.buttonTarefa.UseVisualStyleBackColor = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonTarefa);
            this.Controls.Add(this.buttonContato);
            this.Controls.Add(this.buttonCompromisso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
    }
}
