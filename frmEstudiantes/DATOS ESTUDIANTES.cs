using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FrmEstudiantes
{
    public partial class frmDatosEstudiantes : Form
    {
        public frmDatosEstudiantes()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            //Controla excepciones o errores
            try
            {

                //Guarda los datos de entrada
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                int cedula = Convert.ToInt32(txtCedula.Text);
                string fechaDeNacimiento = txtFecha.Text;
                string ciudad = txtCiudad.Text;
                string sexo;


                        
                //condicional para asignar el dato de entrada que se guardará

                if (radFemenino.Checked == false)
                {
                    sexo = "Femenino";
                }
                else
                {
                    sexo = "Masculino";
                }

                //Mensaje de confirmación
                MessageBox.Show("Señor@ " + txtNombre.Text+ " " + txtApellido.Text + " su registro ha sido exitoso con la identificación " + txtCedula.Text +". Sí desea guardar el registro en su dispositivo, presione desde el menú principal guardar.");

            }
            catch (Exception)
            {
                //Mensaje por la excepción
                MessageBox.Show("Señor usuario, recuerde digitar correctamente los datos.");
            }
           
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Limpia los campos
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCedula.Text = "";
            txtFecha.Text = "";
            txtCiudad.Text = "";
            radFemenino.Checked = false;
            radMasculino.Checked = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Cierra el formulario de datos estudiates
            Close();
        }

        private void grpDatos_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmDatosEstudiantes_Load(object sender, EventArgs e, frmMenuPrincipal frmMenuPrincipal)
        {
            
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDatosEstudiantes_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog().Equals(DialogResult.OK))
                {
                    Stream strGuardar = saveFileDialog1.OpenFile();
                    StreamWriter wrtGuardar = new StreamWriter(strGuardar);

                    wrtGuardar.WriteLine("Nombre: ");
                    wrtGuardar.WriteLine(txtNombre.Text);
                    wrtGuardar.WriteLine("Apellido: ");
                    wrtGuardar.WriteLine(txtApellido.Text);
                    wrtGuardar.WriteLine("Cédula: ");
                    wrtGuardar.WriteLine(Convert.ToInt32(txtCedula.Text));
                    wrtGuardar.WriteLine("Fecha de nacimiento: ");
                    wrtGuardar.WriteLine(txtFecha.Text);
                    wrtGuardar.WriteLine("Ciudad: ");
                    wrtGuardar.WriteLine(txtCiudad.Text);
                    wrtGuardar.WriteLine("Sexo: ");

                    if (radFemenino.Checked == false)
                    {
                        wrtGuardar.WriteLine ("Femenino");
                    }
                    else
                    {
                        wrtGuardar.WriteLine("Masculino") ;
                    }




                    wrtGuardar.Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Señor@ usuario recuerde digitar bien los datos.");
            }

        }
    }
}
