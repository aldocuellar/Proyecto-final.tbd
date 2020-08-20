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
    public partial class ProductoForm : Form
    {
        public ProductoForm()
        {
            InitializeComponent();
            LlenarComboBoxIdTP(cbIdTP);
            LlenarComboBoxIdFP(cbIdFP);
            LlenarComboBoxIdMP(cbIdMP);
            LlenarComboBoxIdProducto(cbSelectProductos);
            ActualizarGridView();
        }

        private void btnCerrarProductos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LlenarComboBoxIdTP(ComboBox cb)
        {
            ejemplofarmaciaEntities datos = new ejemplofarmaciaEntities();
            var lista = datos.Tipo_Producto.ToList();
            cb.Items.Add("Seleccionar");
            foreach (var item in lista)
            {
                cb.Items.Add(item.Nombre_TP);
            }
            cb.SelectedIndex = 0;
        }

        private void LlenarComboBoxIdFP(ComboBox cb)
        {
            ejemplofarmaciaEntities datos = new ejemplofarmaciaEntities();
            var lista = datos.Familia_Producto.ToList();
            cb.Items.Add("Seleccionar");
            foreach (var item in lista)
            {
                cb.Items.Add(item.Nombre_Fam);
            }
            cb.SelectedIndex = 0;
        }

        private void LlenarComboBoxIdMP(ComboBox cb)
        {
            ejemplofarmaciaEntities datos = new ejemplofarmaciaEntities();
            var lista = datos.Marca.ToList();
            cb.Items.Add("Seleccionar");
            foreach (var item in lista)
            {
                cb.Items.Add(item.Nombre_Marca);
            }
            cb.SelectedIndex = 0;
        }

        private void ActualizarGridView()
        {
            ejemplofarmaciaEntities datos = new ejemplofarmaciaEntities();
            var db = (from p in datos.Producto
                      join tp in datos.Tipo_Producto on p.Id_Tipo_Producto_FK equals tp.Id_Tipo_Producto 
                      join fp in datos.Familia_Producto on p.Id_Familia_FK equals fp.Id_Familia
                      join mp in datos.Marca on p.Id_Marca_FK equals mp.Id_Marca
                      select new
                      {
                          Id_Producto = p.Id_Producto,
                          Nombre_Producto = p.Nombre_Producto,
                          Descripcion = p.Descripcion,
                          Precio = p.Precio,
                          Existencia = p.Existencia,
                          Id_Tipo_Producto = tp.Nombre_TP,
                          Id_Familia_Producto = fp.Nombre_Fam,
                          Id_Marca = mp.Nombre_Marca
                      }).ToList();

            dgvProductos.DataSource = db;
            dgvProductos.Refresh();
            dgvProductos.ClearSelection();
        }

        private void btnInsertProductos_Click(object sender, EventArgs e)
        {
            if (cbIdTP.SelectedIndex != 0 && !string.IsNullOrEmpty(tbIdProducto.Text))
            {
                int id = Convert.ToInt32(tbIdProducto.Text);
                ejemplofarmaciaEntities datos = new ejemplofarmaciaEntities();
                Producto registro = datos.Producto.SingleOrDefault(p => p.Id_Producto == id);
                if (registro == null)
                {
                    Producto newRegistro = new Producto
                    {
                        Id_Producto = Convert.ToInt32(tbIdProducto.Text),
                        Nombre_Producto = tbNombreProducto.Text,
                        Descripcion = tbDescripcionProducto.Text,
                        Precio = Convert.ToInt32(tbPrecioProducto.Text),
                        Existencia = Convert.ToInt32(tbExistencia.Text),
                        Id_Tipo_Producto_FK = Convert.ToInt32(cbIdTP.SelectedIndex),
                        Id_Familia_FK = Convert.ToInt32(cbIdFP.SelectedIndex),
                        Id_Marca_FK = Convert.ToInt32(cbIdMP.SelectedIndex),
                    };
                    datos.Producto.Add(newRegistro);
                    datos.SaveChanges();
                    ActualizarGridView();
                    MessageBox.Show("El producto se agregó con éxito", "Advertencia");
                }
                else
                {
                    MessageBox.Show("El producto ya existe", "Error");
                }
            }
            else
            {
                MessageBox.Show("Llene todos los espacios", "Error");
            }
        }

        //-
        private void tbIdProductoMod_TextChanged(object sender, EventArgs e)
        {
            if ((!String.IsNullOrWhiteSpace(tbIdProductoMod.Text)) || (!String.IsNullOrEmpty(tbIdProductoMod.Text)))
            {
                int id = Convert.ToInt32(tbIdProductoMod.Text);
                ejemplofarmaciaEntities datos = new ejemplofarmaciaEntities();
                IQueryable<Producto> RegistrosProductos = from tabla in datos.Producto
                                                        where tabla.Id_Producto == id
                                                        select tabla;
                List<Producto> Producto = RegistrosProductos.ToList();
                if (Producto.Count > 0)
                {
                    var first = Producto[0];
                    tbNombreProductoMod.Text = first.Nombre_Producto;
                    tbDescripcionProductoMod.Text = first.Descripcion;
                    first.Precio = Convert.ToInt32(tbPrecioProductoMod.Text);
                    first.Existencia = Convert.ToInt32(tbExistenciaMod.Text);
                    cbIdTPMod.SelectedIndex = first.Id_Tipo_Producto_FK;
                    cbIdFPMod.SelectedIndex = first.Id_Familia_FK;
                    cbIdMPMod.SelectedIndex = first.Id_Marca_FK;
                }
                else
                {
                    tbNombreProductoMod.Clear();
                    tbDescripcionProductoMod.Clear();
                    tbPrecioProductoMod.Clear();
                    tbExistenciaMod.Clear();
                    cbIdTPMod.SelectedIndex = 0;
                    cbIdFPMod.SelectedIndex = 0;
                    cbIdMPMod.SelectedIndex = 0;
                }
            }
        }

        private void tbIdProductoDrop_TextChanged(object sender, EventArgs e)
        {
            if ((!String.IsNullOrWhiteSpace(tbIdProductoDrop.Text)) || (!String.IsNullOrEmpty(tbIdProductoDrop.Text)))
            {
                int id = Convert.ToInt32(tbIdProductoDrop.Text);
                ejemplofarmaciaEntities datos = new ejemplofarmaciaEntities();
                IQueryable<Producto> RegistrosProductos = from tabla in datos.Producto
                                                          where tabla.Id_Producto == id
                                                          select tabla;
                List<Producto> Producto = RegistrosProductos.ToList();
                if (Producto.Count > 0)
                {
                    var first = Producto[0];
                    tbNombreProductoDrop.Text = first.Nombre_Producto;
                    tbDescripcionProductoDrop.Text = first.Descripcion;
                    first.Precio = Convert.ToInt32(tbPrecioProductoDrop.Text);
                    first.Existencia = Convert.ToInt32(tbExistenciaDrop.Text);
                    cbIdTPDrop.SelectedIndex = first.Id_Tipo_Producto_FK;
                    cbIdFPDrop.SelectedIndex = first.Id_Familia_FK;
                    cbIdMPDrop.SelectedIndex = first.Id_Marca_FK;
                }
                else
                {
                    tbNombreProductoDrop.Clear();
                    tbDescripcionProductoDrop.Clear();
                    tbPrecioProductoDrop.Clear();
                    tbExistenciaDrop.Clear();
                    cbIdTPDrop.SelectedIndex = 0;
                    cbIdFPDrop.SelectedIndex = 0;
                    cbIdMPDrop.SelectedIndex = 0;
                }
            }
        }
        //-

        private void btnModProductos_Click(object sender, EventArgs e)
        {
            if (cbIdTPMod.SelectedIndex != 0 && !String.IsNullOrWhiteSpace(tbIdProductoMod.Text))
            {
                int id = Convert.ToInt32(tbIdProductoMod.Text);
                ejemplofarmaciaEntities datos = new ejemplofarmaciaEntities();
                Producto mod = datos.Producto.SingleOrDefault(p => p.Id_Producto == id);
                if (mod == null)
                {
                    MessageBox.Show("El producto no existe, intente de nuevo", "Error");
                }
                else
                {
                    mod.Id_Producto = Convert.ToInt32(tbIdProductoMod.Text);
                    mod.Nombre_Producto = tbNombreProductoMod.Text;
                    mod.Descripcion = tbDescripcionProductoMod.Text;
                    mod.Precio = Convert.ToInt32(tbPrecioProductoMod.Text);
                    mod.Existencia = Convert.ToInt32(tbExistenciaMod.Text);
                    mod.Id_Tipo_Producto_FK = cbIdTPMod.SelectedIndex;
                    mod.Id_Familia_FK = cbIdFPMod.SelectedIndex;
                    mod.Id_Marca_FK = cbIdMPMod.SelectedIndex;
                    datos.SaveChanges();
                    MessageBox.Show("El producto se actualizó con éxito", "Advertencia");
                    ActualizarGridView();
                }
            }
            else
            {
                MessageBox.Show("Ingrese una id de producto válida", "Error");
            }
        }

        private void btnDropProductos_Click(object sender, EventArgs e)
        {
            if ((!String.IsNullOrWhiteSpace(tbIdProductoDrop.Text)) || (!String.IsNullOrEmpty(tbIdProductoDrop.Text)))
            {
                int id = Convert.ToInt32(tbIdProductoDrop.Text);
                ejemplofarmaciaEntities datos = new ejemplofarmaciaEntities();
                Usuario drop = datos.Usuario.SingleOrDefault(p => p.Id_Usuario == id);
                if (drop != null)
                {
                    datos.Usuario.Remove(drop);
                    datos.SaveChanges();
                    MessageBox.Show("Producto eliminado", "Advertencia");
                    ActualizarGridView();
                }
                else
                {
                    MessageBox.Show("El producto no existe", "Error");
                }
            }
        }

        private void LlenarComboBoxIdProducto(ComboBox cb)
        {
            ejemplofarmaciaEntities datos = new ejemplofarmaciaEntities();
            var lista = datos.Producto.ToList();
            cb.Items.Add("Seleccionar");
            foreach (var item in lista)
            {
                cb.Items.Add(item.Nombre_Producto);
            }
            cb.SelectedIndex = 0;
        }

        private void btnSelectProductos_Click(object sender, EventArgs e)
        {
            if (cbSelectProductos.SelectedIndex != 0)
            {
                ejemplofarmaciaEntities datos = new ejemplofarmaciaEntities();
                int indexProducto = cbSelectProductos.SelectedIndex;
                var db = (from tp in datos.Tipo_Producto
                          join p in datos.Producto on tp.Id_Tipo_Producto equals p.Id_Tipo_Producto_FK
                          join dv in datos.Detalle_Venta on p.Id_Producto equals dv.Id_Producto_FK
                          where p.Id_Producto == indexProducto
                          select new
                          {
                              Tipo_Producto = tp.Nombre_TP,
                              Nombre_Producto = p.Nombre_Producto,
                              Descripcion = p.Descripcion,
                              Precio = p.Precio,
                              Ticket = dv.Ticket_FK,
                              Cantidad = dv.Cantidad
                          }).ToList();
                dgvProductos.DataSource = db;
                dgvProductos.Refresh();
            }
            else
            {
                dgvProductos.DataSource = null;
            }
        }
    }
}
