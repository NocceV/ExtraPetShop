using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Esboço
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
          
           
            menu();

        }
        public static void limpar() {
            Console.WriteLine("Presione Enter para continuar");
            Console.ReadLine();
            Console.Clear();
        }
        public static void cabecalho()
        {
            Console.WriteLine("------------MELHOR PETSHOP------------\n");
        }

        public static void menu()
        {
            RegistroPetShop meuregistro = new RegistroPetShop();
            bool repetidor = true;
            while (repetidor)
            {
                
                cabecalho();
                Console.WriteLine("Escolha uma das Opções: ");
                Console.WriteLine("0-Sair");
                Console.WriteLine("1-Adicionar PetShop");
                Console.WriteLine("2-Ver melhor PetShop");
                Console.WriteLine("3-Listar PetShops");

                int escolha = int.Parse(Console.ReadLine());
                switch (escolha) { 
                    case 0:
                        repetidor = false;
                        break;
                    case 1:
                        meuregistro.addPetShop(adicionarPetShop());
                        break;                      
                    case 2:
                        Console.WriteLine("Informe a quantidade de cães pequenos");
                        int pequeno = informar();
                        Console.WriteLine("Informe a quantidade de cães grandes");
                        int grande = informar();
                        Console.WriteLine(meuregistro.calcularMelhorPetshop(pequeno,grande));
                        break;

                    case 3:
                        Console.WriteLine (meuregistro.ToString());
                        break;
                
                }

                limpar();
            }
        }

        public static PetShop adicionarPetShop()
        {
            Console.WriteLine("Informe o nome do PetShop");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe a distância em metros do PetShop");
            double distancia= double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor do banho para cachorros pequenos");
            double pequenos = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor do banho para cachorros grandes");
            double grandes = double.Parse(Console.ReadLine());

            PetShop novo = new PetShop(nome, distancia, pequenos,grandes);
            return novo;
        }


        public static int informar() { 
            
            int quantidade = int.Parse(Console.ReadLine());
            
            return quantidade;
        }

    }
}
