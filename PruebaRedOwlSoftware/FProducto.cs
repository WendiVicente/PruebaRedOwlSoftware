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
    public partial class FProducto : Form
    {
        public FProducto()
        {
            InitializeComponent();
        }
        void cargar()
        {
            ConexionPrueba contexto = new ConexionPrueba();
            DetalleProducto.DataSource = contexto.Productos.ToList();
        }
        void llegar()
        {
            this.txtcodigop.Text = DetalleProducto.SelectedRows[0].Cells[0].Value.ToString();
            this.txtproducto.Text = DetalleProducto.SelectedRows[0].Cells[1].Value.ToString();
            this.txtprecio.Text = DetalleProducto.SelectedRows[0].Cells[2].Value.ToString();
            this.txtexistencia.Text = DetalleProducto.SelectedRows[0].Cells[3].Value.ToString();
           
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.txtcodigop.Text);
            String prod = txtproducto.Text;
            String exi = txtexistencia.Text;
            String pre = txtprecio.Text;
           

            using (ConexionPrueba contexto = new ConexionPrueba())
            {
                Productos c = contexto.Productos.FirstOrDefault(x => x.Id == id);
                c.Producto = prod;
                c.Existencia = exi;
                c.PrecioVenta = pre;
                
                contexto.SaveChanges();
                cargar();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String produc = txtproducto.Text;
            String existen= txtexistencia.Text;
            String pre = txtprecio.Text;

            using (ConexionPrueba contexto = new ConexionPrueba())
            {
                Productos cc = new Productos
                {
                    Producto = produc,
                    Existencia = existen,
                    PrecioVenta = pre
                };
                contexto.Productos.Add(cc);
                contexto.SaveChanges();
                cargar();
            }
        }

        private void DetalleCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtapellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(this.txtcodigop.Text); ;
            using (ConexionPrueba contexto = new ConexionPrueba())
            {
                Productos c = contexto.Productos.FirstOrDefault(x => x.Id == id);
                contexto.Productos.Remove(c);
                contexto.SaveChanges();
                cargar();
            }
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
