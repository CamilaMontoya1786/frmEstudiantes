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
    public partial class frmDatosAcademicos : Form
    {
        public frmDatosAcademicos()
        {
            InitializeComponent();
        }
      


        private void frmDatosAcademicos_Load(object sender, EventArgs e)
        {
            
        }

        private void lbSexo_Click(object sender, EventArgs e)
        {

        }

        private void radFemenino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            //Controla excepciones
            try
            {
                //Guarda datos de entrada
                int semestre = Convert.ToInt16(txtSemestre.Text);
                string materia = cboMateria.Text;
                cboMateria.DropDownStyle = ComboBoxStyle.DropDownList;

                //Condicional para asignar el dato de entrada que se guardará

                if (radSi.Checked == true)
                {
                    string estudianteActivo = "Sí";

                   
                }
                else
                {
                    string estudianteActivo = "No";

                    

                  
                }

                //Mensaje de confirmación
                MessageBox.Show("Señor@ su registro ha sido exitoso, siendo usted del semestre: " + txtSemestre.Text + ". Sí desea guardar el registro en su dispositivo, presione desde el menú principal guardar.");

            }
            catch (Exception)
            {
                //Mensaje de excepción
                MessageBox.Show("Señor@ usuario recuerde digitar el semestre con números.");
            }
       
           

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Limpia los campos
            txtSemestre.Text = "";
            cboMateria.Text=" ";
            cboMateria.Enabled = true;
            radSi.Checked = false;
            radNo.Checked = false;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Cierra el formulario
            Close();
        }

        private void cboMateria_SelectedIndexChanged(object sender, EventArgs e)
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

                    wrtGuardar.WriteLine("Materia que cursa: ");
                    wrtGuardar.WriteLine(cboMateria.Text);
                    wrtGuardar.WriteLine("Estudiante activo: ");
                    if (radSi.Checked == true)
                    {
                        wrtGuardar.WriteLine(" Sí ");

                    }
                    else
                    {
                        wrtGuardar.WriteLine("No ");
                    }

                    wrtGuardar.WriteLine("Semestre que cursa: ");
                    wrtGuardar.WriteLine(Convert.ToInt16(txtSemestre.Text));

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
