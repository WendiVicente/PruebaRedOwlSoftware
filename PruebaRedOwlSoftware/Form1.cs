using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaRedOwlSoftware
{
    public partial class Form1 : Form
    {
        private FormularioClientes frcliente;

        public Form1()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frcliente == null)
            {
                frcliente = new FormularioClientes();
                frcliente.MdiParent = this;
                frcliente.FormClosed += new FormClosedEventHandler(cerrarforma);
                frcliente.Show();

            }
            else
            {
                frcliente.Activate();
            }
        }
            void cerrarforma(object sender, FormClosedEventArgs e)
            {
                frcliente=null;
            }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FProducto per = new FProducto();
            per.MdiParent = this;
            per.Show();
        }
    }
    }

