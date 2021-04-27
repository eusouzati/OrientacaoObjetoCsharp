using _06_ProjetoByteBank;


namespace _06_ProjetoByteBank
{

    public class ContaCorrente
    {
        public Cliente Titular{ get; set; }
        public int Agencia { get; set; }
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
