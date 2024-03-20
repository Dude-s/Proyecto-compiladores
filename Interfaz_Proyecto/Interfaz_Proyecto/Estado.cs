using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Interfaz_Proyecto
{
    public class Estado
    {
        public string Name { get; }
        public Dictionary<char, List<Estado>> Transitions { get; }

        public Estado(string name)
        {
            Name = name;
            Transitions = new Dictionary<char, List<Estado>>();
        }

        public void AddTransition(char input, Estado nextEstado)
        {
            if (!Transitions.ContainsKey(input))
            {
                Transitions[input] = new List<Estado>();
            }
            Transitions[input].Add(nextEstado);
        }
    }

}
