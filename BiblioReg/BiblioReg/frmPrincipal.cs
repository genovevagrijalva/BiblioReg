using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioReg
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aDMINISTRACIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLibro libro = new frmLibro();
            libro.ShowDialog();
        }

        

        private void mANUALDEUSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManual manual = new frmManual();
            manual.ShowDialog();
        }

        private void aCERCADEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcerca acerca = new frmAcerca();
            acerca.ShowDialog();
        }

        
        

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }
        
    }
}
