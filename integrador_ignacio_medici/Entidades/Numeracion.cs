using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numeracion
    {
        private ESistema sistema;
        private double valorNumerico;
        private double valorDecimal;

        public ESistema Sistema 
        {
            get 
            {
                return this.sistema;
            }
        }
        public string ValorNumerico
        {
            get
            {
                return this.valorNumerico.ToString();
            }
        }

        public double BinarioADecimal(string valor)
        {
            double valorDecimal = Convert.ToInt32(valor, 2);
            if (EsBinario(valor))
            {
                return 0;
            }
            return valorDecimal;
        }

        public string ConvertirA(ESistema sistema)
        {

            string retorno = string.Empty;


            if (sistema == ESistema.Decimal)
            {
                retorno = this.BinarioADecimal(this.ValorNumerico).ToString();
            }
            else
            {
                retorno = this.DecimalABinario(this.ValorNumerico);
            }
            return retorno;
        }



        private void InicializarValores(string valor, ESistema sistema)
        {
            if (sistema == ESistema.Binario)
            { 
                double.TryParse(valor,out double valorParsed);
                this.valorNumerico = valorParsed;
                this.sistema = sistema;
            }
            else if (sistema == ESistema.Decimal)
            {
                double.TryParse(valor, out double valorParsed);
                this.valorNumerico = valorParsed;
                this.sistema = sistema;
            }
            else
            {
                this.valorNumerico = double.MinValue;
            }
        }

        private string DecimalABinario(int valor)
        {
            string mensajeError = "Numero invalido";
            string valorBinario = Convert.ToString(valor,2);

            if (valor < 0)
            {
                return mensajeError;
            }

            return valorBinario;
        }

        private string DecimalABinario(string valor)
        {
            if (int.TryParse(valor, out int valorDecimal))
            {
                return this.DecimalABinario(valorDecimal);
            }
            else
            {
                return "Numero invalido";
            }
        }

        public bool EsBinario(string valor)
        {
            foreach(char caracter in valor)
            {
                if(caracter != '0' && caracter != '1')
                {
                    return false;
                }
            }
            return true;
        }
        public Numeracion(ESistema sistema, double valorNumerico) 
        { 
            this.sistema = sistema;
            this.valorNumerico = valorNumerico;
        }
        public Numeracion(string valor, ESistema sistema)
        { 
            this.InicializarValores(valor, sistema);
        }
        public static bool operator ==(ESistema sistema, Numeracion numeracion)
        {
            return sistema == numeracion.sistema;
        }
        public static bool operator ==(Numeracion n1, Numeracion n2)
        {
            return n1.sistema == n2.sistema;
        }
        public static bool operator!=(ESistema sistema, Numeracion numeracion)
        {
            return sistema != numeracion.sistema;
        }
        public static bool operator!=(Numeracion n1,Numeracion n2)
        {
            return n1.sistema != n2.sistema;
        }
        public static Numeracion operator+(Numeracion n1,Numeracion n2)
        {
            double aux1;
            double aux2;

            double.TryParse(n1.ValorNumerico, out aux1);
            double.TryParse(n2.ValorNumerico, out aux2);

            return new Numeracion(ESistema.Decimal, aux1 + aux2);
        }
        public static Numeracion operator-(Numeracion n1, Numeracion n2)
        {
            double aux1;
            double aux2;

            double.TryParse(n1.ValorNumerico, out aux1);
            double.TryParse(n2.ValorNumerico, out aux2);

            return new Numeracion(ESistema.Decimal, aux1 - aux2);
        }
        public static Numeracion operator*(Numeracion n1, Numeracion n2)
        {
            double aux1; 
            double aux2;

            double.TryParse(n1.ValorNumerico, out aux1);
            double.TryParse(n2.ValorNumerico, out aux2);

            return new Numeracion(ESistema.Decimal, aux1 * aux2);
        }
        public static Numeracion operator/(Numeracion n1, Numeracion n2)
        {
            double aux1;
            double aux2;

            double.TryParse(n1.ValorNumerico, out aux1);
            double.TryParse(n2.ValorNumerico, out aux2);

            return new Numeracion(ESistema.Decimal, aux1 / aux2);
        }

    }

    public enum ESistema
    {
        Decimal = 10,
        Binario 
    }
}
