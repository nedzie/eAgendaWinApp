namespace eAgenda.WinApp.ModuloTarefa
{
    partial class TelaItens
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
            this.checkedListBoxItensDaTarefa = new System.Windows.Forms.CheckedListBox();
            this.labelTituloItem = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonGravar = new System.Windows.Forms.Button();
            this.labelTarefa = new System.Windows.Forms.Label();
            this.labelTarefaSelecionada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListBoxItensDaTarefa
            // 
            this.checkedListBoxItensDaTarefa.CheckOnClick = true;
            this.checkedListBoxItensDaTarefa.FormattingEnabled = true;
            this.checkedListBoxItensDaTarefa.Location = new System.Drawing.Point(12, 98);
            this.checkedListBoxItensDaTarefa.Name = "checkedListBoxItensDaTarefa";
            this.checkedListBoxItensDaTarefa.Size = new System.Drawing.Size(297, 238);
            this.checkedListBoxItensDaTarefa.TabIndex = 0;
            // 
            // labelTituloItem
            // 
            this.labelTituloItem.AutoSize = true;
            this.labelTituloItem.Location = new System.Drawing.Point(12, 53);
            this.labelTituloItem.Name = "labelTituloItem";
            this.labelTituloItem.Size = new System.Drawing.Size(40, 15);
            this.labelTituloItem.TabIndex = 1;
            this.labelTituloItem.Text = "Título:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 23);
            this.textBox1.TabIndex = 2;
            // 
            // buttonGravar
            // 
            this.buttonGravar.BackColor = System.Drawing.Color.White;
            this.buttonGravar.FlatAppearance.BorderSize = 0;
            this.buttonGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGravar.Location = new System.Drawing.Point(234, 50);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(75, 23);
            this.buttonGravar.TabIndex = 3;
            this.buttonGravar.Text = "Gravar:";
            this.buttonGravar.UseVisualStyleBackColor = false;
            // 
            // labelTarefa
            // 
            this.labelTarefa.AutoSize = true;
            this.labelTarefa.Location = new System.Drawing.Point(12, 9);
            this.labelTarefa.Name = "labelTarefa";
            this.labelTarefa.Size = new System.Drawing.Size(41, 15);
            this.labelTarefa.TabIndex = 4;
            this.labelTarefa.Text = "Tarefa:";
            // 
            // labelTarefaSelecionada
            // 
            this.labelTarefaSelecionada.AutoSize = true;
            this.labelTarefaSelecionada.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTarefaSelecionada.Location = new System.Drawing.Point(73, 9);
            this.labelTarefaSelecionada.Name = "labelTarefaSelecionada";
            this.labelTarefaSelecionada.Size = new System.Drawing.Size(111, 15);
            this.labelTarefaSelecionada.TabIndex = 5;
            this.labelTarefaSelecionada.Text = "Tarefa Selecionada";
            // 
            // TelaItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(332, 402);
            this.Controls.Add(this.labelTarefaSelecionada);
            this.Controls.Add(this.labelTarefa);
            this.Controls.Add(this.buttonGravar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelTituloItem);
            this.Controls.Add(this.checkedListBoxItensDaTarefa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaItens";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaItens";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxItensDaTarefa;
        private System.Windows.Forms.Label labelTituloItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonGravar;
        private System.Windows.Forms.Label labelTarefa;
        private System.Windows.Forms.Label labelTarefaSelecionada;
    }
}