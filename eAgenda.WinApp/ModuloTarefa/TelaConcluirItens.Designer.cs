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
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.labelTarefaSelecionada = new System.Windows.Forms.Label();
            this.labelTarefa = new System.Windows.Forms.Label();
            this.checkedListBoxItensTarefa = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.White;
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Location = new System.Drawing.Point(180, 323);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(120, 45);
            this.buttonCancelar.TabIndex = 30;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.BackColor = System.Drawing.Color.White;
            this.buttonAtualizar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAtualizar.FlatAppearance.BorderSize = 0;
            this.buttonAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAtualizar.Location = new System.Drawing.Point(54, 323);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(120, 45);
            this.buttonAtualizar.TabIndex = 29;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = false;
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
            // checkedListBoxItensTarefa
            // 
            this.checkedListBoxItensTarefa.CheckOnClick = true;
            this.checkedListBoxItensTarefa.FormattingEnabled = true;
            this.checkedListBoxItensTarefa.Location = new System.Drawing.Point(8, 37);
            this.checkedListBoxItensTarefa.Name = "checkedListBoxItensTarefa";
            this.checkedListBoxItensTarefa.Size = new System.Drawing.Size(312, 274);
            this.checkedListBoxItensTarefa.TabIndex = 31;
            // 
            // TelaConcluirItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(332, 383);
            this.Controls.Add(this.checkedListBoxItensTarefa);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.labelTarefaSelecionada);
            this.Controls.Add(this.labelTarefa);
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
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.Label labelTarefaSelecionada;
        private System.Windows.Forms.Label labelTarefa;
        private System.Windows.Forms.CheckedListBox checkedListBoxItensTarefa;
    }
}