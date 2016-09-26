using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BIBLIOREG_Lib;

namespace BiblioReg
{
    public partial class frmLibro : Form
    {
        private bool IsNuevo = false;

        private bool IsEditar = false;

        public frmLibro()
        {
            InitializeComponent();
            this.tot.SetToolTip(this.txtbuscar, "Ingrese el Usuario a buscar");
            this.tot.SetToolTip(this.btnBuscar, "Boton para buscar");
            this.tot.SetToolTip(this.btnEliminar, "Elimina el Registro seleccionado");
            this.tot.SetToolTip(this.txtDescripcion, "Ingrese el Nombre del usuario");
            this.tot.SetToolTip(this.txtEditorial, "Ingrese Usuario");
            this.tot.SetToolTip(this.txtAutor, "Ingrese Password");
            this.tot.SetToolTip(this.btnAlta, "Nuevo usuario");
            this.tot.SetToolTip(this.btnGuardar, "Guarda la informacion");
            this.tot.SetToolTip(this.btnModificar, "Modifca Informacion ya Guardada");
            this.tot.SetToolTip(this.btnCancelar, "Cancela el registro");
            this.txtIdL.Enabled = false;
        }
        //Mostrar Mensaje de Confirmacion
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Administracion de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Mostrar Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Administracion de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //Limpiar Controles del formulario
        private void Limpiar()
        {
            this.txtIdL.Text = string.Empty;
            this.txtNom.Text = string.Empty;

            this.txtAutor.Text = string.Empty;
            this.txtEditorial.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;


        }
        //Habilitar los controles del formulario
        private void Habilitar(bool Valor)
        {
            this.txtIdL.ReadOnly = !Valor;
            this.txtNom.ReadOnly = !Valor;
            this.txtAutor.ReadOnly = !Valor;
            this.txtEditorial.ReadOnly = !Valor;
            this.txtDescripcion.ReadOnly = !Valor;







        }
        //Habilita los botones
        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar)
            {
                this.Habilitar(true);
                this.btnAlta.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnModificar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnAlta.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnModificar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }
        }
        //Metodo para ocultar columnas
        private void OcultarColumnas()
        {
            this.dataLibro.Columns[0].Visible = false;
        }
        //Método Mostrar()
        private void mostrar()
        {
            this.dataLibro.DataSource = NLibro.Mostrar();
            this.OcultarColumnas();
            LblTotal.Text = "Total de registros: " + Convert.ToString(dataLibro.Rows.Count);
        }
        private void BuscarNombre()
        {
            this.dataLibro.DataSource = NLibro.BuscarNombre(this.txtbuscar.Text);
            this.OcultarColumnas();
            LblTotal.Text = "Total de registros" + Convert.ToString(dataLibro.Rows.Count);
        }
        //Método Buscar por numero de expediente
        private void Buscar_Autor()
        {
            this.dataLibro.DataSource = NLibro.Buscar_Autor(this.txtbuscar.Text);
            this.OcultarColumnas();
            LblTotal.Text = "Total de registros" + Convert.ToString(dataLibro.Rows.Count);
        }

       

        private void frmLibro_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            this.mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbBuscar.Text.Equals("NOMBRE"))
            {
                this.BuscarNombre();
            }
            else if (cmbBuscar.Text.Equals("AUTOR"))
            {
                this.Buscar_Autor();
            }
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente desea Eliminar los Registros", "Administracion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string IdLibro;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dataLibro.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            IdLibro = Convert.ToString(row.Cells[1].Value);
                            Rpta = NLibro.Eliminar(Convert.ToInt32(IdLibro));

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se Elimino Correctamente el registro");
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }

                        }
                    }
                    this.mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

           
        }

        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEliminar.Checked)
            {
                this.dataLibro.Columns[0].Visible = true;
            }
            else
            {
                this.dataLibro.Columns[0].Visible = false;
            }
        }

        private void dataLibro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataLibro.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dataLibro.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtNom.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";

                if (this.txtNom.Text == string.Empty || this.txtAutor.Text == string.Empty || this.txtEditorial.Text == string.Empty
                     || this.txtDescripcion.Text == string.Empty)
                {
                    MensajeError("Falta igresar algunos datos, verifique los campos");

                }
                else
                {
                   
                    if (this.IsNuevo)
                    {
                        rpta = NLibro.Insertar(this.txtNom.Text.Trim().ToUpper(), dateTimeFecha.Value,
                        this.txtAutor.Text, this.txtEditorial.Text, this.txtDescripcion.Text);




                    }
                    else
                    {
                        rpta = NLibro.Editar(
                                Convert.ToInt32(this.txtIdL.Text),
                                this.txtNom.Text.Trim().ToUpper(),
                                dateTimeFecha.Value,
                                this.txtAutor.Text,
                                this.txtEditorial.Text,
                                this.txtDescripcion.Text);
                        this.txtbuscar.Focus();
                    }
                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se Guardo de forma correcta el registro");
                        }
                        else
                        {
                            this.MensajeOk("Se Actualizo de forma correcta el registro");
                        }
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }
                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.mostrar();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 100", ex.Message + ex.StackTrace, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
            this.txtIdL.Text = string.Empty;
            this.txtNom.Focus();
        }

        private void dataLibro_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdL.Text = Convert.ToString(this.dataLibro.CurrentRow.Cells["idLibro"].Value);

            this.txtNom.Text = Convert.ToString(this.dataLibro.CurrentRow.Cells["nombre"].Value);
            this.dateTimeFecha.Text = Convert.ToString(this.dataLibro.CurrentRow.Cells["fechaRegistro"].Value);
            this.txtAutor.Text = Convert.ToString(this.dataLibro.CurrentRow.Cells["autor"].Value);
            this.txtEditorial.Text = Convert.ToString(this.dataLibro.CurrentRow.Cells["editorial"].Value);
            this.txtDescripcion.Text = Convert.ToString(this.dataLibro.CurrentRow.Cells["descripcion"].Value);


            
            this.tabControl1.SelectedIndex = 1;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!this.txtIdL.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);

            }
            else
            {
                this.MensajeError("Debe seleccionar primero el registro a modificar ");
            }
        }

        private void dataLibro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtIdL.Text = Convert.ToString(this.dataLibro.CurrentRow.Cells["idLibro"].Value);

            this.txtNom.Text = Convert.ToString(this.dataLibro.CurrentRow.Cells["nombre"].Value);
            this.dateTimeFecha.Text = Convert.ToString(this.dataLibro.CurrentRow.Cells["fechaRegistro"].Value);
            this.txtAutor.Text = Convert.ToString(this.dataLibro.CurrentRow.Cells["autor"].Value);
            this.txtEditorial.Text = Convert.ToString(this.dataLibro.CurrentRow.Cells["editorial"].Value);
            this.txtDescripcion.Text = Convert.ToString(this.dataLibro.CurrentRow.Cells["descripcion"].Value);



            this.tabControl1.SelectedIndex = 1;
        }

        
    }
}
