using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

<<<<<<<< HEAD:Codigo/Modulos/Prototipo/Prototipo/Capa_vista/Ejemplo.cs
namespace Vista_PrototipoMenu
{
    public partial class Ejemplo : Form
    {
        public Ejemplo()
========
namespace Hoteleria
{
    public partial class Salon : Form
    {
        public Salon()
>>>>>>>> d134d46b27d24029392750d003c6bd5ccf8e587c:Codigo/Modulos/Hoteleria/Hoteleria/Hoteleria/Salon.cs
        {
            InitializeComponent();
            this.navegador1.config("ejemplo", this, "Ejemplo2");
        }
    }
}
