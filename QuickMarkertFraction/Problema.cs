using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickMarkertFraction
{
    public class Problema
    {
        Fraccion F1;
        Fraccion F2;
        char operador;
        Fraccion Resultado;

        public Problema()
        {
            F1 = new Fraccion();
            F2 = new Fraccion();
            Resultado = new Fraccion();
            operador = '+';
        }

        public Fraccion getOperando1()
        {
            return F1;
        }

        public Fraccion getOperando2()
        {
            return F2;
        }

        public char getOperador()
        {
            return operador;
        }

        public Fraccion getResultado()
        {
            return Resultado;
        }

    }
}
