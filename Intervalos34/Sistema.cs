using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intervalos34
{
    public class Sistema
    {
       
        public void MenuPrincipal()
        {
            Validador.Bienvenida();
            
            TimerCallback llamada = new TimerCallback(Tick);

            Console.WriteLine("\n Fecha Actual: {0}\n",
                               /* DateTime.Now.ToString("hh:mm:ss"));*/
                               DateTime.Now.ToLongDateString());
            
            Timer pulso = new Timer(llamada, null, 0, 10000);

            Thread.Sleep(59000);

        }

        static public void Tick(Object estadoInformativo)
        {
            Console.WriteLine("\n Tick: {0}", DateTime.Now.ToLongDateString());
        }

        public void Iniciar()
        {
            MenuPrincipal();
        }
    }
}
