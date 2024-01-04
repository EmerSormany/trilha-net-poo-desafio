using System;
using trilha_net_poo_desafio.Interface;

namespace trilha_net_poo_desafio.Models
{
    public class Nokia : Smartphone, ICelular
    {
        public Nokia()
        {

        }
        public Nokia(string numero, string modelo, string imei) : base(numero, modelo, imei)
        {

        }
        public void CadastrarMemoria(int memoria)
        {
            
            if (memoria <= 0 || Memoria < memoria)
            {
                throw new ArgumentException("Valor da memória não pode ser negativo ou o celular está com a memória cheia.");
            }
            Memoria -= memoria;
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Smartphone {Modelo}");
            Console.WriteLine($"Espaço de memória disponível no aparelho {Memoria}GB.");
        }
    }
}
