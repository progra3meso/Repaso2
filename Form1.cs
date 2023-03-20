using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repaso2
{
    public partial class Form1 : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        List<Alquiler> alquileres = new List<Alquiler>();
        List<Reporte> reportes = new List<Reporte>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < alquileres.Count; i++)
            {                
                //Buscar el NIT del alquiler en el NIT de Clientes
                for (int j = 0; j < clientes.Count; j++)
                {
                    if(alquileres[i].Nit == clientes[j].Nit)
                    {
                        //guardar los datos en el reporte
                    }
                }
                //Buscar la Placa del alquiler en la Placa de Vehículo
                for (int k = 0; k < vehiculos.Count; k++)
                {
                    if (alquileres[i].Placa == vehiculos[k].Placa)
                    {
                        //guardar los datos en el reporte
                    }
                }


            }
        }
    }
}
