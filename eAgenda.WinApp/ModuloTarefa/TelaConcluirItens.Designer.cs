namespace eAgenda.WinApp.ModuloTarefa
{
    partial class TelaConcluirItens
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
            this.labelTarefaSelecionada = new System.Windows.Forms.Label();
            this.labelTarefa = new System.Windows.Forms.Label();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.labelTituloItem = new System.Windows.Forms.Label();
            this.checkedListBoxItensTarefa = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.White;
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Location = new System.Drawing.Point(180, 365);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(120, 45);
            this.buttonCancelar.TabIndex = 30;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // buttonInserir
            // 
            this.buttonInserir.BackColor = System.Drawing.Color.White;
            this.buttonInserir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonInserir.FlatAppearance.BorderSize = 0;
            this.buttonInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInserir.Location = new System.Drawing.Point(54, 365);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(120, 45);
            this.buttonInserir.TabIndex = 29;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = false;
            // 
            // labelTarefaSelecionada
            // 
            this.labelTarefaSelecionada.AutoSize = true;
            this.labelTarefaSelecionada.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTarefaSelecionada.Location = new System.Drawing.Point(69, 9);
            this.labelTarefaSelecionada.Name = "labelTarefaSelecionada";
            this.labelTarefaSelecionada.Size = new System.Drawing.Size(111, 15);
            this.labelTarefaSelecionada.TabIndex = 27;
            this.labelTarefaSelecionada.Text = "Tarefa Selecionada";
            // 
            // labelTarefa
            // 
            this.labelTarefa.AutoSize = true;
            this.labelTarefa.Location = new System.Drawing.Point(8, 9);
            this.labelTarefa.Name = "labelTarefa";
            this.labelTarefa.Size = new System.Drawing.Size(41, 15);
            this.labelTarefa.TabIndex = 26;
            this.labelTarefa.Text = "Tarefa:";
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.BackColor = System.Drawing.Color.White;
            this.buttonAdicionar.FlatAppearance.BorderSize = 0;
            this.buttonAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionar.Location = new System.Drawing.Point(230, 50);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionar.TabIndex = 25;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = false;
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(54, 50);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(151, 23);
            this.textBoxTitulo.TabIndex = 24;
            // 
            // labelTituloItem
            // 
            this.labelTituloItem.AutoSize = true;
            this.labelTituloItem.Location = new System.Drawing.Point(8, 53);
            this.labelTituloItem.Name = "labelTituloItem";
            this.labelTituloItem.Size = new System.Drawing.Size(40, 15);
            this.labelTituloItem.TabIndex = 23;
            this.labelTituloItem.Text = "Título:";
            // 
            // checkedListBoxItensTarefa
            // 
            this.checkedListBoxItensTarefa.FormattingEnabled = true;
            this.checkedListBoxItensTarefa.Location = new System.Drawing.Point(8, 79);
            this.checkedListBoxItensTarefa.Name = "checkedListBoxItensTarefa";
            this.checkedListBoxItensTarefa.Size = new System.Drawing.Size(312, 274);
            this.checkedListBoxItensTarefa.TabIndex = 31;
            // 
            // TelaConcluirItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(332, 422);
            this.Controls.Add(this.checkedListBoxItensTarefa);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.labelTarefaSelecionada);
            this.Controls.Add(this.labelTarefa);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.labelTituloItem);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaConcluirItens";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaConcluirItens";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Label labelTarefaSelecionada;
        private System.Windows.Forms.Label labelTarefa;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label labelTituloItem;
        private System.Windows.Forms.CheckedListBox checkedListBoxItensTarefa;
    }
}