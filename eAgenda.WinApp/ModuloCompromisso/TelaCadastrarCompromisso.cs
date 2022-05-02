using eAgenda.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public partial class TelaCadastrarCompromisso : Form
    {
        Compromisso compromisso;
        public TelaCadastrarCompromisso(Compromisso compromissoVazio)
        {
            InitializeComponent();
            this.compromisso = compromissoVazio;
        }
    }
}
