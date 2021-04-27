using _07_ProjetoByteBank;


namespace _07_ProjetoByteBank
{

    public class ContaCorrente
    {
        public Cliente Titular{ get; set; }

        // Informa o total de contas criadas
        public static int TotalDeContasCriadas { get; private set; }

       
        private int _agencia;
        public int Agencia 
        {
            get
            {
                return _agencia; 
            }
            set 
            {
                if(value <= 0) 
                {
                    return;                
                }
                _agencia = value;
            } 

        }
        public int Numero { get; set; }
        
        private double _saldo = 99.00;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if(value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }

        //public void SetSaldo(double saldo)    //Set = Definir - Tradução
        //{
           // if(saldo < 0)
            //{
               // return;

           // }
           // else
           // {
               // this.saldo = saldo;
           // }
        //}
    //

      //  public double GetSaldo() //Get = Obter - Tradução
       // {
         //   return saldo;
      //  }

        //********************************************************************************


        // Construtor das informações de Conta Corrente, Agencia e Numero obrigatório
        public ContaCorrente(int agencia, int numero)
        {
            Numero = numero;
            Agencia = agencia;

            TotalDeContasCriadas++;
        }


        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                return true;
            }
        }
        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }

}
