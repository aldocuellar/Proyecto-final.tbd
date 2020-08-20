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
    public partial class UsuarioForm : Form
    {
        public UsuarioForm()
        {
            InitializeComponent();
            LlenarComboBoxIdTU(cbIdTU);
            LlenarComboBoxGenero(cbGenero);
            LlenarComboBoxIdUs(cbSelectUsuarios);
            ActualizarGridView();
        }

        private void btnCerrarUsuarios_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LlenarComboBoxGenero(ComboBox cb)
        {
            cb.Text = "Seleccionar";
            cb.Items.Add("Seleccionar");
            cb.Items.Add("F");
            cb.Items.Add("M");
        }

        private void LlenarComboBoxIdTU(ComboBox cb)
        {
            ejemplofarmaciaEntities datos = new ejemplofarmaciaEntities();//Se crea el objeto de bd
            var lista = datos.Tipo_Usuario.ToList();//Generamos una variable para guardar los datos de la bd
            cb.Items.Add("Seleccionar");//Añadimos un item al combo box que aparecerá como indice 0
            foreach (var item in lista)//Con el ciclo recorremos la variable para llenar el combo box con los datos
            {
                cb.Items.Add(item.Nombre_TU);//Se añaden los datos de la db
            }
            cb.SelectedIndex = 0;//Se establece el indice en 0
        }

        private void ActualizarGridView()
        {
            ejemplofarmaciaEntities datos = new ejemplofarmaciaEntities();
            var db = (from u in datos.Usuario
                      join tu in datos.Tipo_Usuario on u.Id_Tipo_Usuario_FK equals tu.Id_Tipo_Usuario
                      select new
                      {
                          Id_Usuario = u.Id_Usuario,
                          Nombre_de_Usuario = u.Nombre_Usuario,
                          Contraseña = u.Contraseña,
                          Apellido_Paterno = u.Ap_Paterno,
                          Apellido_Materno = u.Ap_Materno,
                          Nombre = u.Nombre,
                          Fecha_Nacimiento = u.Fecha_Nacimiento,
                          Genero = u.Genero,
                          Tipo_Usuario = tu.Nombre_TU,
                      }).ToList();

            dgvUsuarios.DataSource = db;
            dgvUsuarios.Refresh();
            dgvUsuarios.ClearSelection();
        }

        private void btnInsertUsuarios_Click(object sender, EventArgs e)
        {
            if (cbIdTU.SelectedIndex != 0 && !string.IsNullOrEmpty(tbIdUsuario.Text))
            {
                int id = Convert.ToInt32(tbIdUsuario.Text);
                ejemplofarmaciaEntities datos = new ejemplofarmaciaEntities();
                Usuario registro = datos.Usuario.SingleOrDefault(p => p.Id_Usuario == id);
                if (registro == null)
                {
                    Usuario newRegistro = new Usuario
                    {
                        Id_Usuario = Convert.ToInt32(tbIdUsuario.Text),
                        Nombre_Usuario = tbNombreDeUsuario.Text,
                        Contraseña = tbPassword.Text,
                        Ap_Paterno = tbApPaterno.Text,
                        Ap_Materno = tbApMaterno.Text,
                        Nombre = tbNombreUs.Text,
                        Fecha_Nacimiento = dtpFechaNac.Value,
                        Genero= Convert.ToString(cbGenero.SelectedIndex),
                        Id_Tipo_Usuario_FK = Convert.ToInt32(cbIdTU.SelectedIndex),
                    };
                    datos.Usuario.Add(newRegistro);
                    datos.SaveChanges();
                    ActualizarGridView();
                    MessageBox.Show("El usuario se agregó con éxito","Advertencia");
                }
                else
                {
                    MessageBox.Show("El usuario ya existe", "Error");
                }
            }
            else
            {
                MessageBox.Show("Llene todos los espacios", "Error");
            }
        }

        private void tbIdUsuarioMod_TextChanged(object sender, EventArgs e)
        {
            if ((!String.IsNullOrWhiteSpace(tbIdUsuarioMod.Text)) || (!String.IsNullOrEmpty(tbIdUsuarioMod.Text)))
            {
                int id = Convert.ToInt32(tbIdUsuarioMod.Text);
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
            }
        }

        private void btnModUsuarios_Click(object sender, EventArgs e)
        {
            if (cbIdTUMod.SelectedIndex != 0 && !String.IsNullOrWhiteSpace(tbIdUsuarioMod.Text))
            {
                int id = Convert.ToInt32(tbIdUsuarioMod.Text);
                ejemplofarmaciaEntities datos = new ejemplofarmaciaEntities();
                Usuario mod = datos.Usuario.SingleOrDefault(p => p.Id_Usuario == id);
                if (mod == null)
                {
                    MessageBox.Show("El usuario no existe, intente de nuevo","Error");
                }
                else
                {
                    mod.Id_Usuario = Convert.ToInt32(tbIdUsuario.Text);
                    mod.Nombre_Usuario = tbNombreDeUsuario.Text;
                    mod.Contraseña = tbPassword.Text;
                    mod.Ap_Paterno = tbApPaterno.Text;
                    mod.Ap_Materno = tbApMaterno.Text;
                    mod.Nombre = tbNombreUs.Text;
                    mod.Fecha_Nacimiento = dtpFechaNac.Value;
                    mod.Genero = Convert.ToString(cbGenero.SelectedIndex);
                    mod.Id_Tipo_Usuario_FK = Convert.ToInt32(cbIdTU.SelectedIndex);
                    datos.SaveChanges();
                    MessageBox.Show("El usuario se actualizó con éxito","Advertencia");
                    ActualizarGridView();
                }
            }
            else
            {
                MessageBox.Show("Ingrese una id de usuario válida","Error");
            }
        }

        private void tbIdUsuarioDrop_TextChanged(object sender, EventArgs e)
        {
            if ((!String.IsNullOrWhiteSpace(tbIdUsuarioDrop.Text)) || (!String.IsNullOrEmpty(tbIdUsuarioDrop.Text)))
            {
                int id = Convert.ToInt32(tbIdUsuarioDrop.Text);
                ejemplofarmaciaEntities datos = new ejemplofarmaciaEntities();
                IQueryable<Usuario> RegistrosUsuarios = from tabla in datos.Usuario
                                                      where tabla.Id_Usuario == id
                                                      select tabla;
                List<Usuario> Usuario = RegistrosUsuarios.ToList();
                if (Usuario.Count > 0)
                {
                    var first = Usuario[0];
                    tbNombreDeUsuarioDrop.Text = first.Nombre_Usuario;
                    tbPasswordDrop.Text = first.Contraseña;
                    tbApPaternoDrop.Text = first.Ap_Paterno;
                    tbApMaternoDrop.Text = first.Ap_Materno;
                    tbNombreUsDrop.Text = first.Nombre;
                    dtpFechaNacDrop.Value = first.Fecha_Nacimiento;
                    cbGeneroDrop.SelectedItem = first.Genero;
                    cbIdTUDrop.SelectedItem = first.Id_Tipo_Usuario_FK;
                }
                else
                {
                    tbIdUsuarioDrop.Clear();
                    tbNombreDeUsuarioDrop.Clear();
                    tbPasswordDrop.Clear();
                    tbApPaternoDrop.Clear();
                    tbApMaternoDrop.Clear();
                    tbNombreUsDrop.Clear();
                    dtpFechaNacDrop.Value=DateTime.Today;
                    cbGeneroDrop.SelectedIndex=0;
                    cbIdTUDrop.SelectedIndex=0;
                }
            }
        }

        private void btnDropUsuarios_Click(object sender, EventArgs e)
        {
            if ((!String.IsNullOrWhiteSpace(tbIdUsuarioDrop.Text)) || (!String.IsNullOrEmpty(tbIdUsuarioDrop.Text)))
            {
                int id = Convert.ToInt32(tbIdUsuarioDrop.Text);
                ejemplofarmaciaEntities datos = new ejemplofarmaciaEntities();
                Usuario drop = datos.Usuario.SingleOrDefault(p => p.Id_Usuario == id);
                if (drop != null)
                {
                    datos.Usuario.Remove(drop);
                    datos.SaveChanges();
                    MessageBox.Show("Usuario eliminado","Advertencia");
                    ActualizarGridView();
                }
                else
                {
                    MessageBox.Show("El usuario no existe","Error");
                }
            }
        }

        private void LlenarComboBoxIdUs(ComboBox cb)
        {
            ejemplofarmaciaEntities datos = new ejemplofarmaciaEntities();
            var lista = datos.Usuario.ToList();
            cb.Items.Add("Seleccionar");
            foreach (var item in lista)
            {
                cb.Items.Add(item.Nombre);
            }
            cb.SelectedIndex = 0;
        }

        private void btnSelectUsuarios_Click(object sender, EventArgs e)
        {
            if (cbSelectUsuarios.SelectedIndex != 0)
            {
                ejemplofarmaciaEntities datos = new ejemplofarmaciaEntities();
                int indexUsuario = cbSelectUsuarios.SelectedIndex;
                var db = ( from tu in datos.Tipo_Usuario
                           join u in datos.Usuario on tu.Id_Tipo_Usuario equals u.Id_Tipo_Usuario_FK
                           join v in datos.Venta on u.Id_Usuario equals v.Id_Usuario_FK
                           join dv in datos.Detalle_Venta on v.Ticket equals dv.Ticket_FK
                           where u.Id_Usuario == indexUsuario
                           select new
                           {
                               Nombre = u.Nombre,
                               Ap_Paterno = u.Ap_Paterno,
                               Ap_Materno = u.Ap_Materno,
                               Fecha_Nacimiento = u.Fecha_Nacimiento,
                               Genero = u.Genero,
                               Tipo_Usuario = tu.Nombre_TU,
                               Ticket = v.Ticket,
                               Total = v.Total,
                               Fecha = v.Fecha
                           }).ToList();
                dgvUsuarios.DataSource = db;
                dgvUsuarios.Refresh();
            }
            else
            {
                dgvUsuarios.DataSource = null;
            }
        }
    }
}
