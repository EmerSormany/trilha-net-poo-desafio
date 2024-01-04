using System;

namespace trilha_net_poo_desafio.Models
{
    public abstract class Smartphone
    {
        public Smartphone()
        {

        }
        public Smartphone(string numero, string modelo, string imei)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
        }
        private string _numero;
        public string Numero 
        { 
            get => _numero; 
            set
            {
                if (value.Length != 11)
                {
                    throw new ArgumentException("O número passado não possui o padrão correto");
                }
                _numero = value;
            }
        }
        private string _modelo;
        protected string Modelo 
        {
            get => _modelo.ToUpper();
            set
            {
                if (value == "")
                {   
                    throw new ArgumentException("O modelo não pode estar vazio.");
                }
                _modelo = value;
            }
        }
        private string _imei;
        protected string IMEI 
        { 
            get => _imei;
            set
            {
                if (value.Length != 15)
                {
                    throw new ArgumentException("O IMEI informado não possui o padrão correto.");
                }
                _imei = value;
            }
        }
        protected int _memoria = 128;
        protected int Memoria 
        { 
            get => _memoria; 
            set => _memoria = value;
        }
        public void Ligar()
        {
            Console.WriteLine($"Seu {Modelo} está ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Seu {Modelo} está recebendo uma ligação...");
        }
        public abstract void InstalarAplicativo(string nomeApp);

    }
}
