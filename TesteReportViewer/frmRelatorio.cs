﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteReportViewer
{
    public partial class frmRelatorio : Form
    {
        public frmRelatorio()
        {
            InitializeComponent();
        }

        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'AdventureWorks2008R2DataSet.ContactType'. Você pode movê-la ou removê-la conforme necessário.
            this.ContactTypeTableAdapter.Fill(this.AdventureWorks2008R2DataSet.ContactType);

            this.reportViewer1.RefreshReport();
        }
    }
}
