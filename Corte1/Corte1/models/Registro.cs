using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corte1.models
{
    internal class Registro
    {
        private Persona[] personas = new Persona[30];

        private int i = 0;
        private ListBox lbDatos;

        public Registro(ListBox listBox)
        {
            lbDatos = listBox;
        }

        public void AgregarPersona(Persona persona)
        {
            if (i < 30)
            {
                personas[i] = persona;
                i++;
                lbDatos.Items.Add($"{persona.Nombres} {persona.Apellidos} {persona.FechaNac} {persona.Ciudad}" );
            }
            else
            {
                 MessageBox.Show("El registro de personas ya esta lleno, no se podran agregar mas valores.");
            }
        }
        public Persona[] MostrarPersonas()
        {
            return personas.Where(p => p != null).ToArray();
        }

    }
}
