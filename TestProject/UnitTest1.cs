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
        public void TestSumarMetodoPublicoDeFraccion()
        {
            Fraccion f1 = new Fraccion(1,3);
            Fraccion f2 = new Fraccion(2,3);
            Fraccion resultado = new Fraccion();

            Problema p = new Problema();
            resultado = p.sumar(f1, f2);

            //bool b = resultado.esIgual(new Fraccion(9,9);
            bool b = (resultado.getNumerador() == 9) && (resultado.getDenominador() == 9);

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
    }
}
