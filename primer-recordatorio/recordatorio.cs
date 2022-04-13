using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_recordatorio
{
    public static class Recordatorio
    {
        public static void Mensaje1()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Que onda crack de la programación?-----------------------");
            Console.WriteLine("Creamos un par de recordatorios?-------------------------");
            Console.WriteLine("Presionar una tecla para continuar...--------------------");
            Console.WriteLine("---------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();
        }
        public static void Mensaje2()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("1 => Crear proyecto -----------------------------------------");
            Console.WriteLine("2 => En el buscador de Windows => 'Programador de tareas'----");
            Console.WriteLine("3 => Nueva tarea y configurar las repeticiones, etc----------");
            Console.WriteLine("4 => Acciones => NUEVA => SELECCIONAR Proyecto.exe-----------");
            Console.WriteLine("5 => Docu => https://www.youtube.com/watch?v=0V5p_qRa_zI'----");
            Console.WriteLine("-------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}
