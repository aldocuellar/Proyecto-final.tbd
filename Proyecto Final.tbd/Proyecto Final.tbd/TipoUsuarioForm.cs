using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.tbd
{
    public partial class TipoUsuarioForm : Form
    {
        public TipoUsuarioForm()
        {
            InitializeComponent();
            ActualizarGridView();
        }

        private void ActualizarGridView()
        {
            ejemplofarmaciaEntities datos = new ejemplofarmaciaEntities();
            var db = (from u in datos.Tipo_Usuario
                      select new
                      {
                          Id_Tipo_Usuario = u.Id_Tipo_Usuario,
                          Tipo_Usuario = u.Nombre_TU,
                      }).ToList();

            dgvTU.DataSource = db;
            dgvTU.Refresh();
            dgvTU.ClearSelection();
        }

        private void btnCerrarTU_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsertTU_Click(object sender, EventArgs e)
        {
            if (tbIdTUInsert.Text != null && !string.IsNullOrEmpty(tbNombreTUInsert.Text))
            {
                int id = Convert.ToInt32(tbNombreTUInsert.Text);
                ejemplofarmaciaEntities datos = new ejemplofarmaciaEntities();
                Tipo_Usuario registro = datos.Tipo_Usuario.SingleOrDefault(p => p.Id_Tipo_Usuario == id);
                if (registro == null)
                {
                    Tipo_Usuario newRegistro = new Tipo_Usuario
                    {
                        Id_Tipo_Usuario = Convert.ToInt32(tbIdTUInsert.Text),
                        Nombre_TU = tbNombreTUInsert.Text,
                    };
                    datos.Tipo_Usuario.Add(newRegistro);
                    datos.SaveChanges();
                    ActualizarGridView();
                    MessageBox.Show("El tipo de usuario se agregó con éxito", "Advertencia");
                }
                else
                {
                    MessageBox.Show("El tipo de usuario ya existe", "Error");
                }
            }
            else
            {
                MessageBox.Show("Llene todos los espacios", "Error");
            }
        }

        private void tbIdTUMod_TextChanged(object sender, EventArgs e)
        {/*
            if ((!String.IsNullOrWhiteSpace(tbIdTUMod.Text)) || (!String.IsNullOrEmpty(tbNombreTUMod.Text)))
            {
                int id = Convert.ToInt32(tbIdTUMod.Text);
                ejemplofarmaciaEntities datos = new ejemplofarmaciaEntities();
                IQueryable<Usuario> RegistrosUsuarios = from tabla in datos.Usuario
                                                        where tabla.Id_Usuario == id
                                                        select tabla;
                List<Usuario> Usuario = RegistrosUsuarios.ToList();
                if (Usuario.Count > 0)
                {
                    var first = Usuario[0];
                    tbNombreDeUsuarioMod.Text = first.Nombre_Usuario;
                    tbPasswordMod.Text = first.Contraseña;
                    tbApPaternoMod.Text = first.Ap_Paterno;
                    tbApMaternoMod.Text = first.Ap_Materno;
                    tbNombreUsMod.Text = first.Nombre;
                    dtpFechaNacMod.Value = first.Fecha_Nacimiento;
                    cbGeneroMod.SelectedItem = first.Genero;
                    cbIdTUMod.SelectedItem = first.Id_Tipo_Usuario_FK;
                }
                else
                {
                    tbIdUsuarioMod.Clear();
                    tbNombreDeUsuarioMod.Clear();
                    tbPasswordMod.Clear();
                    tbApPaternoMod.Clear();
                    tbApMaternoMod.Clear();
                    tbNombreUsMod.Clear();
                    dtpFechaNacMod.Value = DateTime.Today;
                    cbGeneroMod.SelectedIndex = 0;
                    cbIdTUMod.SelectedIndex = 0;
                }
            }*/
        }

        private void btnModTU_Click(object sender, EventArgs e)
        {

        }

        private void btnDropTU_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectTU_Click(object sender, EventArgs e)
        {

        }

    }
}
