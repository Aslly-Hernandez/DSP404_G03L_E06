using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreTarea.Text))
            {
                {
                    MessageBox.Show("El nombre de la tarea no puedeestar vacio.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var item = new ListViewItem(txtNombreTarea.Text);
                item.SubItems.Add(dtpFechaLimite.Value.ToShortDateString());
                lvTareasPendientes.Items.Add(item);

                txtNombreTarea.Clear();
                dtpFechaLimite.Value = DateTime.Now;
            }


        }

        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            if(lvTareasPendientes.SelectedItems.Count > 0)
            {
                lvTareasPendientes.Items.Remove(lvTareasPendientes.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Seleccione una tarea para eliminar.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarTarea_Click(object sender, EventArgs e)
        {
            if (lvTareasPendientes.SelectedItems.Count > 0)
            {
                var selectedItem = lvTareasPendientes.SelectedItems[0];
                selectedItem.Text = txtNombreTarea.Text;
                selectedItem.SubItems[1].Text = dtpFechaLimite.Value.ToShortDateString();
            }
            else
            {
                MessageBox.Show("Seleccione una tarea para editar.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMarcarCompletada_Click(object sender, EventArgs e)
        {
            if (lvTareasPendientes.SelectedItems.Count > 0)
            {
                var completedItem = lvTareasPendientes.SelectedItems[0];
                lvTareasPendientes.Items.Remove(completedItem);
                completedItem.Checked = true;
                lvTareasCompletadas.Items.Add(completedItem);
            }
            else
            {
                MessageBox.Show("Seleccione una tarea para marcar como completada.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
   


