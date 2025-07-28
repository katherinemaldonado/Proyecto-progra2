namespace Proyecto_progra2;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


public partial class Form1 : Form

{
    List<Equipo> listaEquipos = new List<Equipo>();

    public Form1()
    {
        InitializeComponent();
    }

    private void btnAgregarEquipo_Click(object sender, EventArgs e)
    {

        Equipo nuevo = new Equipo()

        {
            Codigo = txtCodigo.Text,
            Tipo = cmbTipo.SelectedItem?.ToString(),
            Marca = txtMarca.Text,
            Modelo = txtModelo.Text,
            Serie = txtSerie.Text,
            Ubicacion = cmbUbicacion.SelectedItem?.ToString(),
            Estado = cmbEstado.SelectedItem?.ToString()
        };

        listaEquipos.Add(nuevo);
        MostrarEquipos();
        MessageBox.Show("Equipo agregado correctamente.");
    }
    
    private void MostrarEquipos()

    {
        dgvEquipos.DataSource = null;
        dgvEquipos.DataSource = listaEquipos;
    }

    private void btnVerManteniemintos_Click(object sender, EventArgs e)
    { 
        // Verificar que haya un equipo seleccionado en la tabla
        if (dgvEquipos.CurrentRow == null)
        {
            MessageBox.Show("Selecciona un equipo primero.");
            return;
        }

        // Obtener el equipo seleccionado
        Equipo seleccionado = dgvEquipos.CurrentRow.DataBoundItem as Equipo;

        if (seleccionado != null)
        {
            // Abrir el formulario de mantenimientos
            frmMantenimientos ventana = new frmMantenimientos(seleccionado);
            ventana.ShowDialog();

            // Actualizar la tabla por si cambió algo
            MostrarEquipos();
        }
    }

}

