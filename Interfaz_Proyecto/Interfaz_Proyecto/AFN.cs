using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Transactions;
using static System.Windows.Forms.AxHost;

namespace Interfaz_Proyecto
{
    public class AFN
    {

        private static List<AFN> automataList = new List<AFN>();
        public Estado InitialEstado { get; }
        public Estado FinalEstado { get; }
        public string idAutomata { get; }

        public AFN(Estado initialEstado, Estado finalEstado, string idAuto)
        {
            idAutomata = idAuto; 
            InitialEstado = initialEstado;
            FinalEstado = finalEstado;
        }

        public void CrearAFNBasico(char Rango1, char Rango2, string id)
        {

            char startChar = Rango1;
            char endChar = Rango2;

            Estado initialEstado = new Estado("q0");
            Estado finalEstado = new Estado("q1");


            for (char c = startChar; c <= endChar; c++)
            {
                initialEstado.AddTransition(c, finalEstado);
            }

            AFN AFN = new AFN(initialEstado, finalEstado,id);
            automataList.Add(AFN);

            // Ahora puedes hacer lo que quieras con los automatas almacenados en la lista 'automatas'
            ImprimirAutomata();
        }

        public void ImprimirAutomata()
        {
            Console.WriteLine("Transiciones del autómata:");
            foreach (var estado in automataList)
            {
                Console.WriteLine($"ID del autómata: {estado.idAutomata}");
                Console.WriteLine($"Estado inicial: {estado.InitialEstado.Name}");
                Console.WriteLine($"Estado final: {estado.FinalEstado.Name}");

                foreach (var transition in estado.InitialEstado.Transitions)
                {
                    foreach (var target in transition.Value)
                    {
                        Console.WriteLine($"Transición: {estado.InitialEstado.Name} -> {target.Name} con símbolo '{transition.Key}'");
                    }
                }
            }
        }
    }


}
