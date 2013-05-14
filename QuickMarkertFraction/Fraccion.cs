using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickMarkertFraction
{
    public class Fraccion
    {
        private int _numerador;
        private int _denominador;
        private int resultadoSuma;
        private Fraccion F1, F2, Resultado;

        public Fraccion()
        {
            this._denominador = 1;
            this._numerador = 1;
        }

        public Fraccion(int num, int den)
        {
            if(den==0)throw new ArgumentException();

            this._numerador = num;
            this._denominador = den;
        }
        public int getNumerador()
        {
            return this._numerador;
 	        //throw new System.NotImplementedException();
        }
        
        public int getDenominador()
        {
            return this._denominador;
 	        //throw new System.NotImplementedException();
        }

        public void setNumerador(int num)
        {
            this._numerador = num;
        }

        public void setDenominador(int den)
        {
            this._denominador = den;
        }

        public Fraccion sumar(Fraccion F2)
        {
            this.F2 = F2;
            Resultado = new Fraccion();
            Resultado.setDenominador(this.getDenominador() * F2.getDenominador());
            int a = this.getNumerador() * F2.getDenominador();
            int b = F2.getNumerador() * this.getDenominador();
            Resultado.setNumerador(a + b);
            this.setNumerador(Resultado.getNumerador());
            this.setDenominador(Resultado.getDenominador());
            return this;
        }

        public Fraccion restar( Fraccion F2)
        {
            this.F2 = F2;
            Resultado = new Fraccion();
            Resultado.setDenominador(this.getDenominador() * F2.getDenominador());
            int a = this.getNumerador() * F2.getDenominador();
            int b = F2.getNumerador() * this.getDenominador();
            Resultado.setNumerador(a - b);
            this.setNumerador(Resultado.getNumerador());
            this.setDenominador(Resultado.getDenominador());
            return Resultado;
        }

        public Fraccion multiplicar( Fraccion F2)
        {
            this.F2 = F2;
            Resultado = new Fraccion();
            Resultado.setDenominador(F2.getDenominador() * this.getDenominador());
            Resultado.setNumerador(this.getNumerador() * F2.getNumerador());
            this.setNumerador(Resultado.getNumerador());
            this.setDenominador(Resultado.getDenominador());
            return Resultado;
        }

        public Fraccion dividir( Fraccion F2)
        {
            
            this.F2 = F2;
            Resultado = new Fraccion();
            Resultado.setNumerador(this.getNumerador() * F2.getDenominador());
            Resultado.setDenominador(this.getDenominador() * F2.getNumerador());
            this.setNumerador(Resultado.getNumerador());
            this.setDenominador(Resultado.getDenominador());
            return Resultado;
        }


        private int mcd()
        {
            int u = Math.Abs(_numerador);
            int v = Math.Abs(_denominador);
            if (v == 0)
            {
                return u;
            }
            int r;
            while (v != 0)
            {
                r = u % v;
                u = v;
                v = r;
            }
            return u;
        }

        public Fraccion simplificar()
        {
            int dividir = mcd();
            _numerador = _numerador / dividir;
            _denominador = _denominador / dividir;
            return this;
        }


    }
}
