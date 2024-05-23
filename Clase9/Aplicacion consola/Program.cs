using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        static void Mostrarmenu()
        { int op = 0;
            switch(op) {
                case 1:
                    {
                        Console.WriteLine("Registrar acesso");
                        break;
                    }
                case 2: { Console.WriteLine("Mostrar cantidad de ingresos");
                            break;}
                case 3: { Console.WriteLine("Mostrar informe de caja");
                        break;
                             }
                case 4: { Console.WriteLine("salida");
                        break;
                    }

                    
                    }
                    
        }
    }
}
