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
    public partial class FormularioClientes : Form
    {
        public FormularioClientes()
        {
            InitializeComponent();
        }
void cargar()
        {
            ConexionPrueba contexto = new ConexionPrueba();
            DetalleCliente.DataSource = contexto.Cliente.ToList();
        }
        void llengar()
        {
            this.txtcodigo.Text = DetalleCliente.SelectedRows[0].Cells[0].Value.ToString();
            this.txtnombre.Text =DetalleCliente.SelectedRows[0].Cells[1].Value.ToString();
            this.txtapellido.Text = DetalleCliente.SelectedRows[0].Cells[2].Value.ToString();
            this.txtemail.Text = DetalleCliente.SelectedRows[0].Cells[3].Value.ToString();
            this.txtdireccion.Text = DetalleCliente.SelectedRows[0].Cells[4].Value.ToString();
            this.txttelefono.Text = DetalleCliente.SelectedRows[0].Cells[5].Value.ToString();
        }
        private void FormularioClientes_Load(object sender, EventArgs e)
        {
            cargar();
                }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombre=txtnombre.Text;
            String apellido=txtapellido.Text;
            String direccion=txtdireccion.Text;
            String gmail = txtemail.Text;
           int telefono = int.Parse(txttelefono.Text);

            using (ConexionPrueba contexto = new ConexionPrueba())
            {
                Cliente c = new Cliente
                {
                    
                    Nombre = nombre,
                    Dirección = direccion,
                    Teléfono = telefono,
                    Apellidos = apellido,
                    E_mail = gmail
                };
                contexto.Cliente.Add(c);
                contexto.SaveChanges();
                cargar();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void DetalleCliente_Click(object sender, EventArgs e)
        {
            llengar();
        }

        private void DetalleCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(this.txtcodigo.Text);    
            String nombre=txtnombre.Text;
            String apellido=txtapellido.Text;   
            String direccion=txtdireccion.Text;
            int telefono=int.Parse(this.txttelefono.Text);
            String gmail=txtemail.Text;

            using(ConexionPrueba contexto=new ConexionPrueba())
            {
            Cliente c=contexto.Cliente.FirstOrDefault(x=>x.Id==id);
                c.Nombre=nombre;
                c.Apellidos=apellido;
                c.Dirección=direccion;
                c.Teléfono=telefono;
                c.E_mail=gmail;
                contexto.SaveChanges();
                cargar();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(this.txtcodigo.Text);;
            using(ConexionPrueba contexto=new ConexionPrueba())
            {
                Cliente c = contexto.Cliente.FirstOrDefault(x => x.Id == id);
                contexto.Cliente.Remove(c);
                contexto.SaveChanges();
                cargar();
            }

        }
    }
}
