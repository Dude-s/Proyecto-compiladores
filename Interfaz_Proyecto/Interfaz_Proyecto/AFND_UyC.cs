using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Interfaz_Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AFN> automatas = new List<AFN>(); // Lista para almacenar los AFN creados

            while (true)
            {
                Console.WriteLine("\nMENU:");
                Console.WriteLine("1. Unión de AFNDs");
                Console.WriteLine("2. Concatenación de AFNDs");
                Console.WriteLine("3. Salir");

                Console.Write("Ingrese su elección: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Creación del primer AFND:");
                        AFN afn1 = CrearAFND();
                        Console.WriteLine("Creación del segundo AFND:");
                        AFN afn2 = CrearAFND();

                        // Realizar unión de los AFNDs
                        AFN unionAFND = UnirAFNDs(afn1, afn2);
                        automatas.Add(unionAFND);

                        Console.WriteLine("\nResultado de la unión de AFNDs:");
                        unionAFND.ImprimirAutomata();
                        break;

                    case 2:
                        Console.WriteLine("Creación del primer AFND:");
                        AFN afn3 = CrearAFND();
                        Console.WriteLine("Creación del segundo AFND:");
                        AFN afn4 = CrearAFND();

                        // Realizar concatenación de los AFNDs
                        AFN concatenacionAFND = ConcatenarAFNDs(afn3, afn4);
                        automatas.Add(concatenacionAFND);

                        Console.WriteLine("\nResultado de la concatenación de AFNDs:");
                        concatenacionAFND.ImprimirAutomata();
                        break;

                    case 3:
                        Console.WriteLine("¡Hasta luego!");
                        return;

                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }

        static AFN CrearAFND()
        {
            Console.WriteLine("Ingrese el rango de caracteres (inicio fin):");
            string[] rango = Console.ReadLine().Split();
            char startChar = char.Parse(rango[0]);
            char endChar = char.Parse(rango[1]);

            Console.WriteLine("Ingrese un identificador para el AFND:");
            string id = Console.ReadLine();

            AFN afn = new AFN();
            afn.CrearAFNBasico(startChar, endChar, id);

            return afn;
        }

        static AFN UnirAFNDs(AFN afn1, AFN afn2)
        {
            // Creamos un nuevo AFN para la unión
            AFN unionAFND = new AFN();

            // Creamos nuevos estados para el AFN unión
            Estado nuevoInicial = new Estado("q0");
            Estado nuevoFinal = new Estado("q1");

            // Agregamos las transiciones del primer AFND al nuevo AFN
            foreach (var transicion in afn1.InitialEstado.Transitions)
            {
                foreach (var target in transicion.Value)
                {
                    nuevoInicial.AddTransition(transicion.Key, target);
                }
            }

            // Agregamos las transiciones del segundo AFND al nuevo AFN
            foreach (var transicion in afn2.InitialEstado.Transitions)
            {
                foreach (var target in transicion.Value)
                {
                    nuevoInicial.AddTransition(transicion.Key, target);
                }
            }

            // Conectamos el nuevo estado inicial al antiguo estado inicial del primer AFND
            nuevoInicial.AddTransition('ε', afn1.InitialEstado);

            // Conectamos el antiguo estado final del primer AFND al nuevo estado final
            foreach (var transicion in afn1.FinalEstado.Transitions)
            {
                foreach (var target in transicion.Value)
                {
                    transicion.Key.AddTransition('ε', nuevoFinal);
                }
            }

            // Conectamos el antiguo estado final del segundo AFND al nuevo estado final
            foreach (var transicion in afn2.FinalEstado.Transitions)
            {
                foreach (var target in transicion.Value)
                {
                    transicion.Key.AddTransition('ε', nuevoFinal);
                }
            }

            // Establecemos los nuevos estados inicial y final del AFN unión
            unionAFND.InitialEstado = nuevoInicial;
            unionAFND.FinalEstado = nuevoFinal;

            return unionAFND;
        }


        static AFN ConcatenarAFNDs(AFN afn1, AFN afn2)
        {
                // Creamos un nuevo AFN para la concatenación
                AFN concatenacionAFND = new AFN();

                // Conectamos el estado final del primer AFND al estado inicial del segundo AFND
                foreach (var transicion in afn1.FinalEstado.Transitions)
                {
                    foreach (var target in transicion.Value)
                    {
                        transicion.Key.AddTransition('ε', afn2.InitialEstado);
                    }
                }

            // Mantenemos los estados iniciales y finales de los AFNDs originales
            concatenacionAFND.InitialEstado = afn1.InitialEstado;
            concatenacionAFND.FinalEstado = afn2.FinalEstado;

            return concatenacionAFND;
        }

    }
}
