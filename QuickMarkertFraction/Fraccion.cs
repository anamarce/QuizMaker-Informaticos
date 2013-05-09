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
    }
}
