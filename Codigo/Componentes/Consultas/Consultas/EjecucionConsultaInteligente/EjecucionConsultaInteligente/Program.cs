﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_VistaConsultas;


namespace EjecucionConsultaInteligente
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          //  Application.Run(new Capa_VistaConsultas.Busqueda());
            Application.Run(new Capa_VistaConsultas.Busqueda());
        }
    }
}

