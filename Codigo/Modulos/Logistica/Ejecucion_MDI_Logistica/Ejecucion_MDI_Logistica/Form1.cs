using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

<<<<<<<< HEAD:Codigo/Modulos/Bancos/Capa_vista/Ejemplo.cs
namespace Vista_PrototipoMenu
{
    public partial class Ejemplo : Form
    {
        public Ejemplo()
========
namespace Ejecucion_MDI_Logistica
{
    public partial class Form1 : Form
    {
        public Form1()
>>>>>>>> d134d46b27d24029392750d003c6bd5ccf8e587c:Codigo/Modulos/Logistica/Ejecucion_MDI_Logistica/Ejecucion_MDI_Logistica/Form1.cs
        {
            InitializeComponent();
            this.navegador1.config("ejemplo", this, "Ejemplo2");
        }
    }
}
