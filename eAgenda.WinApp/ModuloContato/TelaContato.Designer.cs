namespace eAgenda.WinApp.ModuloContato
{
    partial class TelaContato
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
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.listBoxContato = new System.Windows.Forms.ListBox();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonVisualizarCargo = new System.Windows.Forms.Button();
            this.buttonVisualizarNormal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonInserir
            // 
            this.buttonInserir.BackColor = System.Drawing.Color.White;
            this.buttonInserir.FlatAppearance.BorderSize = 0;
            this.buttonInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInserir.Location = new System.Drawing.Point(12, 12);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(120, 45);
            this.buttonInserir.TabIndex = 0;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = false;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.White;
            this.buttonEditar.FlatAppearance.BorderSize = 0;
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditar.Location = new System.Drawing.Point(12, 63);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(120, 45);
            this.buttonEditar.TabIndex = 1;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.BackColor = System.Drawing.Color.White;
            this.buttonExcluir.FlatAppearance.BorderSize = 0;
            this.buttonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExcluir.Location = new System.Drawing.Point(12, 114);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(120, 45);
            this.buttonExcluir.TabIndex = 2;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = false;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // listBoxContato
            // 
            this.listBoxContato.FormattingEnabled = true;
            this.listBoxContato.ItemHeight = 15;
            this.listBoxContato.Location = new System.Drawing.Point(149, 14);
            this.listBoxContato.Name = "listBoxContato";
            this.listBoxContato.Size = new System.Drawing.Size(759, 334);
            this.listBoxContato.TabIndex = 3;
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.White;
            this.buttonSair.FlatAppearance.BorderSize = 0;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Location = new System.Drawing.Point(12, 267);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(120, 45);
            this.buttonSair.TabIndex = 4;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonVisualizarCargo
            // 
            this.buttonVisualizarCargo.BackColor = System.Drawing.Color.White;
            this.buttonVisualizarCargo.FlatAppearance.BorderSize = 0;
            this.buttonVisualizarCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVisualizarCargo.Location = new System.Drawing.Point(12, 216);
            this.buttonVisualizarCargo.Name = "buttonVisualizarCargo";
            this.buttonVisualizarCargo.Size = new System.Drawing.Size(120, 45);
            this.buttonVisualizarCargo.TabIndex = 5;
            this.buttonVisualizarCargo.Text = "Agrupar por cargo";
            this.buttonVisualizarCargo.UseVisualStyleBackColor = false;
            this.buttonVisualizarCargo.Click += new System.EventHandler(this.buttonVisualizarCargo_Click);
            // 
            // buttonVisualizarNormal
            // 
            this.buttonVisualizarNormal.BackColor = System.Drawing.Color.White;
            this.buttonVisualizarNormal.FlatAppearance.BorderSize = 0;
            this.buttonVisualizarNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVisualizarNormal.Location = new System.Drawing.Point(12, 165);
            this.buttonVisualizarNormal.Name = "buttonVisualizarNormal";
            this.buttonVisualizarNormal.Size = new System.Drawing.Size(120, 45);
            this.buttonVisualizarNormal.TabIndex = 6;
            this.buttonVisualizarNormal.Text = "Visualizar normal";
            this.buttonVisualizarNormal.UseVisualStyleBackColor = false;
            this.buttonVisualizarNormal.Click += new System.EventHandler(this.buttonVisualizarNormal_Click);
            // 
            // TelaContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(920, 360);
            this.Controls.Add(this.buttonVisualizarNormal);
            this.Controls.Add(this.buttonVisualizarCargo);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.listBoxContato);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonInserir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaContato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Contatos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.ListBox listBoxContato;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonVisualizarCargo;
        private System.Windows.Forms.Button buttonVisualizarNormal;
    }
}