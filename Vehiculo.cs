﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso2
{
    class Vehiculo
    {
        string placa;
        string marca;
        int modelo;
        string color;
        double precioKilometro;

        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Modelo { get => modelo; set => modelo = value; }
        public string Color { get => color; set => color = value; }
        public double PrecioKilometro { get => precioKilometro; set => precioKilometro = value; }
    }
}
