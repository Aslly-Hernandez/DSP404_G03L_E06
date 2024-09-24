using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CajeroWeb.Models
{
    public class Transaccion
    {
        private string sNumeroTarjeta;
        private double fSaldo;

        public Transaccion(string tarjeta)
        {
            sNumeroTarjeta = tarjeta;
            fSaldo = 500;
        }

        public Transaccion(string tarjeta, double saldo)
        {
            sNumeroTarjeta = tarjeta;
            fSaldo = saldo;
        }
        public double getSaldo()
        {
            return fSaldo;
        }
        public void setSaldo(double saldo)
        {
            fSaldo = saldo;
        }
        public String getNumTarjeta()
        {
            return sNumeroTarjeta;
        }
        public void setNumTarjeta(string tarjeta)
        {
            sNumeroTarjeta = tarjeta;
        }
        public void transferenciaNacional(double monto)
        {
            fSaldo = fSaldo - monto;
        }
        public void transferenciaInternacional(double monto)
        {
            fSaldo = fSaldo - monto;
        }
    }
}