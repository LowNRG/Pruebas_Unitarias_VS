using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using gestionBancariaApp;
namespace gestionBancariaTest
{
    [TestClass]
    public class gestionBancariaTests
    {
        [TestMethod]
        public void ValidarMetodoIngreso()
        {
            double saldoInicial = 1000;
            double ingreso = 500;
            double saldoActual = 0;
            double saldoEsperado = 1500;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            cuenta.realizarIngreso(ingreso);
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]

        public void ValidarMetodoIngresoCero()
        {
            double saldoInicial = 1000;
            double cantidad = -50;
            double saldoActual = 0;
            

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            cuenta.realizarIngreso(cantidad);
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoInicial, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]

        public void ValidarReintegroCero()
        {
            
            double saldoActual = 0;
            double cantidad = 0;
            double saldoInicial = 1000;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            cuenta.realizarReintegro(cantidad);
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoInicial, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]

        public void ValidarReintegroNegativo()
        {

            double saldoActual = 0;
            double cantidad = -5;
            double saldoInicial = 1000;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            cuenta.realizarReintegro(cantidad);
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoInicial, saldoActual, 0.001, "El saldo de la cuenta no es correcto");

        }
        [TestMethod]

        public void ValidarReintegroValido()
        {

            double saldoActual = 0;
            double cantidad = 100;
            double saldoInicial = 1000;
            double saldoEsperado = 900;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            cuenta.realizarReintegro(cantidad);
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]

        public void ValidarReintegroSaldoSuperior()
        {

            double saldoActual = 0;
            double cantidad = 100000;
            double saldoInicial = 1000;
            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            cuenta.realizarReintegro(cantidad);
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoInicial, saldoActual, 0.001, "El saldo de la cuenta no es correcto");

        }
    }
}
