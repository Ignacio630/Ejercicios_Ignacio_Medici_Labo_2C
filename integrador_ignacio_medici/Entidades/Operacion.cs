using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Entidades
{
    public class Operacion
    {
        private Numeracion primerOperando;
        private Numeracion segundoOperando;

        private Numeracion PrimerOperando
        {
            get
            {
                return this.primerOperando;
            }
            set
            {
                this.primerOperando = value;
            }
        }
        private Numeracion SegundoOperando
        {
            get
            {
                return this.segundoOperando;
            }
            set
            {
                this.segundoOperando = value;
            }
        }
        public Operacion(Numeracion primerOperando, Numeracion segundoOperando)
        {
            this.primerOperando = primerOperando;
            this.segundoOperando = segundoOperando;
        }

        public Numeracion Operar(char operador)
        {
            Numeracion resultadoOperacion;
           

            switch (operador)
            {
                case '+':
                    
                    resultadoOperacion = this.primerOperando + this.segundoOperando;

                    break;
                case '-':

                    resultadoOperacion = this.primerOperando - this.segundoOperando;

                    break;
                case '/':

                    if(this.segundoOperando.ValorNumerico != "0")
                    {
                        resultadoOperacion = this.primerOperando / this.segundoOperando;
                    }
                    else
                    {
                        resultadoOperacion = this.primerOperando;
                    }
                    break;

                case '*':

                    resultadoOperacion = this.primerOperando * this.segundoOperando;

                    break;

                default:

                    resultadoOperacion = this.primerOperando;
                    
                    break;
            }
            return resultadoOperacion;
        }





        
        
        
    }


}