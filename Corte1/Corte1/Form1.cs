using Corte1.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corte1
{
    public partial class Form1 : Form
    {
        private Registro registro;
        private Operacion operacion = new Operacion();
        public Form1()
        {
            InitializeComponent();
            cbCiudad.Items.AddRange(new string[] { "Esteli", "Chontales", "Managua", "Boaco", "Masatepe", "Diriamba"});
            registro = new Registro(lbDatos);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona
            {
                Nombres = tbNames.Text,
                Apellidos = tbLastName.Text,
                FechaNac = dtpFechaNac.Value,
                Ciudad = cbCiudad.SelectedItem.ToString()
            };

            registro.AgregarPersona(persona);
            MessageBox.Show("Persona agregada correctamente.");

        }

        private void btnEvalueAge_Click(object sender, EventArgs e)
        {
            Persona persona = registro.MostrarPersonas().LastOrDefault();

            if (persona == null)
            {
                MessageBox.Show("No hay personas registradas.");
                return;
            }

            int edad = operacion.CalcularEdad(persona.FechaNac);

            bool esMayor = operacion.EsMayorDeEdad(persona.FechaNac);

            MessageBox.Show($"{persona.Nombres} tiene {edad} años y es {(esMayor ? "mayor" : "menor")} de edad.");
        }
    }
}
