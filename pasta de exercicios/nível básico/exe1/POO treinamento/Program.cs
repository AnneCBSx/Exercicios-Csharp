using System;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Xml.Linq;

namespace POO_treinamento
    {
    class Program
        {
        static void Main(string[] args)
            {
            Console.WriteLine ("Aprendendo POO");
          //Criando instancia da conta
            Conta conta1=new Conta();

            conta1.Saldo = 1500;
            conta1.Limite = 2500;
            conta1.Numero = 500;

            Console.WriteLine ("Seu Saldo é:" + conta1.Saldo);

            Console.WriteLine ("Limite de saque:" + conta1.Limite);
            Console.WriteLine ("Numero da conta:" + conta1.Numero);
        }
    }
}
