using System;

namespace POO_treinamento
    {
    class Program
        {
        static void Main(string[] args)
            {
            Console.WriteLine ("Aprendendo POO");
          //Criando instancia da conta
            Conta conta1=new Conta();

            conta1.Limite = 1500;
            conta1.Limite = 2500;
            conta1.Numero = 500;
            Console.WriteLine(conta1.Numero);




            }
        }
    }
