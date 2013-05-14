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

        public Fraccion sumar(Fraccion F1, Fraccion F2)
        {
            this.F1 = F1;
            this.F2 = F2;
            Resultado.setDenominador(F1.getDenominador() * F2.getDenominador());
            int a = F1.getNumerador()*F2.getDenominador();
            int b = F2.getNumerador()*F1.getDenominador();
            Resultado.setNumerador(a + b);
            return Resultado;
        }

        public Fraccion restar(Fraccion F1, Fraccion F2)
        {
            this.F1 = F1;
            this.F2 = F2;
            Resultado.setDenominador(F1.getDenominador() * F2.getDenominador());
            int a = F1.getNumerador() * F2.getDenominador();
            int b = F2.getNumerador() * F1.getDenominador();
            Resultado.setNumerador(a - b);
            return Resultado;
        }

        public Fraccion multiplicar(Fraccion F1, Fraccion F2)
        {
            this.F1 = F1;
            this.F2 = F2;
            Resultado.setDenominador(F2.getDenominador() * F1.getDenominador());
            Resultado.setNumerador(F1.getNumerador() * F2.getNumerador());
            return Resultado;
        }

        public Fraccion dividir(Fraccion F1, Fraccion F2)
        {
            this.F1 = F1;
            this.F2 = F2;
            Resultado.setNumerador(F1.getNumerador() * F2.getDenominador());
            Resultado.setDenominador(F1.getDenominador() * F2.getNumerador());
            return Resultado;
        }
    }
}
