using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

<<<<<<<< HEAD:Codigo/Modulos/Prototipo/Ejecucion/Ejecucion/Program.cs
namespace Ejecucion
========
namespace Hoteleria
>>>>>>>> d134d46b27d24029392750d003c6bd5ccf8e587c:Codigo/Modulos/Hoteleria/Hoteleria/Hoteleria/Program.cs
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<<< HEAD:Codigo/Modulos/Prototipo/Ejecucion/Ejecucion/Program.cs
            Application.Run(new Vista_PrototipoMenu.MenuSeguridad());
            
        }   
========
            Application.Run(new Form1());
        }
>>>>>>>> d134d46b27d24029392750d003c6bd5ccf8e587c:Codigo/Modulos/Hoteleria/Hoteleria/Hoteleria/Program.cs
    }
}
