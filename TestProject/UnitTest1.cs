using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickMarkertFraction;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConstructoDefaultFraccion()
        {
            Fraccion f = new Fraccion();

            int numerador = f.getNumerador();
            int denominador = f.getDenominador();
            bool b=(numerador==1) && (denominador==1);

            Assert.AreEqual(true, b);

        }

        [TestMethod]
        public void TestConstructoConParametrosFraccion()
        {
            Fraccion f = new Fraccion(2,3);

            int numerador = f.getNumerador();
            int denominador = f.getDenominador();
            bool b = (numerador == 2) && (denominador == 3);

            Assert.AreEqual(true, b);

        }

        [TestMethod]
        public void TestConstructoConParametrosDenominadorCeroFraccion()
        {
            try
            {
                Fraccion f = new Fraccion(2, 0);
            }
            catch(ArgumentException e)
            {
                return;
            }

            Assert.Fail();
        }
        
        [TestMethod]
        public void TestSumarDeFraccion()
        {
            Fraccion f1 = new Fraccion(1,3);
            Fraccion f2 = new Fraccion(2,3);
            Fraccion resultado = new Fraccion();

            resultado = f1.sumar(f2);

            //bool b = resultado.esIgual(new Fraccion(9,9);
            bool b = (resultado.getNumerador() == 9) && (resultado.getDenominador() == 9);

            Assert.AreEqual(true, b);
        }

        [TestMethod]
        public void TestRestarDeFraccion()
        {
            Fraccion f1 = new Fraccion(4, 3);
            Fraccion f2 = new Fraccion(2, 3);
            Fraccion resultado = new Fraccion();
            resultado = f1.restar(f2);

            //bool b = resultado.esIgual(new Fraccion(9,9);
            bool b = (resultado.getNumerador() == 6) && (resultado.getDenominador() == 9);

            Assert.AreEqual(true, b);
        }

        [TestMethod]
        public void TestMultiplicarFraccion()
        {
            Fraccion f1 = new Fraccion(4, 3);
            Fraccion f2 = new Fraccion(2, 3);
            Fraccion resultado = new Fraccion();
            resultado = f1.multiplicar(f2);

            //bool b = resultado.esIgual(new Fraccion(9,9);
            bool b = (resultado.getNumerador() == 8) && (resultado.getDenominador() == 9);
            Assert.AreEqual(true, b);
        }

        [TestMethod]
        public void TestDividirFraccion()
        {
            Fraccion f1 = new Fraccion(4, 3);
            Fraccion f2 = new Fraccion(2, 3);
            Fraccion resultado = new Fraccion();
            resultado = f1.dividir(f2);

            //bool b = resultado.esIgual(new Fraccion(9,9);
            bool b = (resultado.getNumerador() == 12) && (resultado.getDenominador() == 6);

            Assert.AreEqual(true, b);
        }

        [TestMethod]
        public void TestContructorDefaulProblema()
        {
            Problema p = new Problema();
            Fraccion op1 = p.getOperando1();
            Fraccion op2 = p.getOperando2();
            char operador = p.getOperador();
            Fraccion resultado = p.getResultado();
        }

        [TestMethod]
        public void TestSetNumerador()
        {

            Fraccion f1 = new Fraccion();
            f1.setNumerador(9);
            bool b = (f1.getNumerador() == 9);

            Assert.AreEqual(true, b);

        }

        [TestMethod]
        public void TestSetDenominador()
        {
            Fraccion f1 = new Fraccion();
            f1.setDenominador(5);
            bool b = (f1.getDenominador() == 5);
            Assert.AreEqual(true, b);

        }

    }
}
6);
            bool b = (f1.getDenominador() == 6);
            Assert.AreEqual(true, b);

        }

    }
}
