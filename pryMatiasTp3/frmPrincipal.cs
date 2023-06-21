using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pryMatiasTp3
{
    public partial class frmPrincipal : Form
    {
        clsEncuestas Encuestas;
        clsLocalidad Localidades;
        clsProfesion Profesiones;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAgregarProfesion_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreProfesion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreProfesion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtIDProfesion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIDProfesion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtNombreLocalidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreLocalidad_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtIDLocalidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIDLocalidad_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnAgregarLocalidad_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                    
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void btnAgregarL_Click(object sender, EventArgs e)
        {
            try
            {
                Localidades = new clsLocalidad();
                Int32 Localidad = Convert.ToInt32(txtLocalidad.Text);

                Localidades.Buscar(Localidad);

                if (Localidades.Local == Localidad)
                {
                    MessageBox.Show("El Id ingresado ya esta registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Localidades.Localidad = txtNombreLocalidad.Text;
                    Localidades.Local = Convert.ToInt32(txtLocalidad.Text);
                    Localidades.RegistroDeLocalidad();

                    Localidades.ListarLocalidades(cbLocalidad);
                    cbLocalidad.SelectedIndex = -1;//Si no pongo esto se selecciona un item luego de cargar la info

                    txtNombreLocalidad.Text = "";
                    txtLocalidad.Text = "";
                    txtLocalidad.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas con la base de datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            try
            {
                Profesiones = new clsProfesion();
                Int32 IDProfesionBuscada = Convert.ToInt32(txtProfesion.Text);
                Profesiones.Buscar(IDProfesionBuscada);

                Profesiones.Buscar(IDProfesionBuscada);
                if (Profesiones.Prof == IDProfesionBuscada)
                {
                    MessageBox.Show("El Id ingresado ya esta registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Profesiones.Profesion = txtNombreProfesion.Text;
                    Profesiones.Prof = Convert.ToInt32(txtProfesion.Text);
                    Profesiones.RegistroProfesion();

                    Profesiones.ListarProfesiones(cbProfesion);
                    cbProfesion.SelectedIndex = -1;//Si no pongo esto se selecciona un item luego de cargar la info

                    txtNombreProfesion.Text = "";
                    txtProfesion.Text = "";
                    txtProfesion.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas con la base de datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Encuestas = new clsEncuestas();

                bool valor = Encuestas.Registrar((int)cbLocalidad.SelectedValue, (int)cbProfesion.SelectedValue, Convert.ToInt32(txtIngreseCantidad.Text));

                if (valor == true)
                {
                    txtIngreseCantidad.Text = "";
                    cbProfesion.SelectedIndex = -1;
                    cbLocalidad.SelectedIndex = -1;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas con la base de datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dgvEncuestas.Rows.Clear();
                dgvEncuestas.Columns.Clear();

                dgvEncuestas.Columns.Add("Localidades", "Localidades");

                Localidades = new clsLocalidad();
                Profesiones = new clsProfesion();
                Encuestas = new clsEncuestas();

                DataTable tablaProfesiones = Profesiones.getAll();
                DataTable tablaLocalidades = Localidades.getAll();
                DataTable tablaEncuestas = Encuestas.getAll();


                foreach (DataRow dr in tablaProfesiones.Rows)
                {
                    dgvEncuestas.Columns.Add("Profesion", dr.ItemArray[1].ToString());
                }
                foreach (DataRow dr in tablaLocalidades.Rows)
                {
                    dgvEncuestas.Rows.Add(dr.ItemArray[1].ToString());
                }

                foreach (DataRow dr in tablaEncuestas.Rows)
                {
                    string varLocalidad = Localidades.BuscarLocalidad(Convert.ToInt32(dr.ItemArray[0]));
                    string varProfesion = Profesiones.BuscarProfesion(Convert.ToInt32(dr.ItemArray[1]));

                    foreach (DataGridViewTextBoxColumn dcGrilla in dgvEncuestas.Columns)
                    {
                        if (varProfesion == dcGrilla.HeaderText)
                        {
                            int posicionColumna = dcGrilla.Index;

                            foreach (DataGridViewRow drGrilla in dgvEncuestas.Rows)
                            {
                                if (varLocalidad == drGrilla.Cells[0].Value.ToString())
                                {
                                    int posicionFila = drGrilla.Index;
                                    dgvEncuestas.Rows[posicionFila].Cells[posicionColumna].Value = dr["cantidad"];
                                }
                            }
                        }
                    }

                    dgvEncuestas.AutoResizeColumns();
                    dgvEncuestas.AutoResizeRows();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas con la base de datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }
    }
}
