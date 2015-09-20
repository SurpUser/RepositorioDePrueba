using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Agenda : Form
    {
        public Agenda()
        {
            InitializeComponent();
        } 

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Persona p = new Persona();
            p.Nombre = NombretextBox.Text;

            int resultado = PersonaDAL.Agregar(p);
            if (resultado > 0)
            {
                MessageBox.Show("Guardado Correctamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error Al Guardar", "Datos No Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
