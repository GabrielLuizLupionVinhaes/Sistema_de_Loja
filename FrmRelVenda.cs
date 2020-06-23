using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaCL
{
    public partial class FrmRelVenda : Form
    {
        public FrmRelVenda()
        {
            InitializeComponent();
        }

        private void FrmRelVenda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'DbLojaDataSet.venda'. Você pode movê-la ou removê-la conforme necessário.
            this.vendaTableAdapter.Fill(this.DbLojaDataSet.venda);

            this.reportViewer1.RefreshReport();
        }
    }
}
