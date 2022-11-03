using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PracticaStatic;

namespace Winapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleado empleado1 = new Empleado();
            Empleado empleado2 = new Empleado();
            Empleado.Comision = 10;
            MessageBox.Show("La comision de los empleados es :"+Empleado.Comision.ToString());

            Empleado empleado3 = new Empleado();
            Empleado empleado4 = new Empleado();
            Empleado.Comision = 20;
            MessageBox.Show("La comision de los empleados ahora es:" + Empleado.Comision.ToString());
            // La comision es igual para todos los empleados

        }
    }
}
