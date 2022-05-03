namespace eAgenda.WinApp.ModuloTarefa
{
    partial class TelaTarefa
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageTarefasPendentes = new System.Windows.Forms.TabPage();
            this.listBoxTarefasPendentes = new System.Windows.Forms.ListBox();
            this.tabPageTarefasConcluidas = new System.Windows.Forms.TabPage();
            this.listBoxTarefasConcluidas = new System.Windows.Forms.ListBox();
            this.buttonAdicionarItens = new System.Windows.Forms.Button();
            this.buttonConcluirItens = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageTarefasPendentes.SuspendLayout();
            this.tabPageTarefasConcluidas.SuspendLayout();
            this.SuspendLayout();
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageTarefasPendentes);
            this.tabControl1.Controls.Add(this.tabPageTarefasConcluidas);
            this.tabControl1.Location = new System.Drawing.Point(138, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(650, 300);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPageTarefasPendentes
            // 
            this.tabPageTarefasPendentes.Controls.Add(this.listBoxTarefasPendentes);
            this.tabPageTarefasPendentes.Location = new System.Drawing.Point(4, 24);
            this.tabPageTarefasPendentes.Name = "tabPageTarefasPendentes";
            this.tabPageTarefasPendentes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTarefasPendentes.Size = new System.Drawing.Size(642, 272);
            this.tabPageTarefasPendentes.TabIndex = 0;
            this.tabPageTarefasPendentes.Text = "Tarefas Pendentes";
            this.tabPageTarefasPendentes.UseVisualStyleBackColor = true;
            // 
            // listBoxTarefasPendentes
            // 
            this.listBoxTarefasPendentes.FormattingEnabled = true;
            this.listBoxTarefasPendentes.ItemHeight = 15;
            this.listBoxTarefasPendentes.Location = new System.Drawing.Point(6, 6);
            this.listBoxTarefasPendentes.Name = "listBoxTarefasPendentes";
            this.listBoxTarefasPendentes.Size = new System.Drawing.Size(630, 259);
            this.listBoxTarefasPendentes.TabIndex = 0;
            // 
            // tabPageTarefasConcluidas
            // 
            this.tabPageTarefasConcluidas.Controls.Add(this.listBoxTarefasConcluidas);
            this.tabPageTarefasConcluidas.Location = new System.Drawing.Point(4, 24);
            this.tabPageTarefasConcluidas.Name = "tabPageTarefasConcluidas";
            this.tabPageTarefasConcluidas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTarefasConcluidas.Size = new System.Drawing.Size(642, 272);
            this.tabPageTarefasConcluidas.TabIndex = 1;
            this.tabPageTarefasConcluidas.Text = "Tarefas Concluídas";
            this.tabPageTarefasConcluidas.UseVisualStyleBackColor = true;
            // 
            // listBoxTarefasConcluidas
            // 
            this.listBoxTarefasConcluidas.FormattingEnabled = true;
            this.listBoxTarefasConcluidas.ItemHeight = 15;
            this.listBoxTarefasConcluidas.Location = new System.Drawing.Point(6, 6);
            this.listBoxTarefasConcluidas.Name = "listBoxTarefasConcluidas";
            this.listBoxTarefasConcluidas.Size = new System.Drawing.Size(630, 259);
            this.listBoxTarefasConcluidas.TabIndex = 0;
            // 
            // buttonAdicionarItens
            // 
            this.buttonAdicionarItens.BackColor = System.Drawing.Color.White;
            this.buttonAdicionarItens.FlatAppearance.BorderSize = 0;
            this.buttonAdicionarItens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionarItens.Location = new System.Drawing.Point(12, 165);
            this.buttonAdicionarItens.Name = "buttonAdicionarItens";
            this.buttonAdicionarItens.Size = new System.Drawing.Size(120, 45);
            this.buttonAdicionarItens.TabIndex = 3;
            this.buttonAdicionarItens.Text = "Adicionar itens";
            this.buttonAdicionarItens.UseVisualStyleBackColor = false;
            this.buttonAdicionarItens.Click += new System.EventHandler(this.buttonAdicionarItens_Click);
            // 
            // buttonConcluirItens
            // 
            this.buttonConcluirItens.BackColor = System.Drawing.Color.White;
            this.buttonConcluirItens.FlatAppearance.BorderSize = 0;
            this.buttonConcluirItens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConcluirItens.Location = new System.Drawing.Point(12, 216);
            this.buttonConcluirItens.Name = "buttonConcluirItens";
            this.buttonConcluirItens.Size = new System.Drawing.Size(120, 45);
            this.buttonConcluirItens.TabIndex = 15;
            this.buttonConcluirItens.Text = "Concluir itens";
            this.buttonConcluirItens.UseVisualStyleBackColor = false;
            this.buttonConcluirItens.Click += new System.EventHandler(this.buttonConcluirItens_Click);
            // 
            // TelaTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 329);
            this.Controls.Add(this.buttonConcluirItens);
            this.Controls.Add(this.buttonAdicionarItens);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonInserir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaTarefa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaTarefa";
            this.tabControl1.ResumeLayout(false);
            this.tabPageTarefasPendentes.ResumeLayout(false);
            this.tabPageTarefasConcluidas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageTarefasPendentes;
        private System.Windows.Forms.ListBox listBoxTarefasPendentes;
        private System.Windows.Forms.TabPage tabPageTarefasConcluidas;
        private System.Windows.Forms.ListBox listBoxTarefasConcluidas;
        private System.Windows.Forms.Button buttonAdicionarItens;
        private System.Windows.Forms.Button buttonConcluirItens;
    }
}