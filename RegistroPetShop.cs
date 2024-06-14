using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esboço
{
    internal class RegistroPetShop
    {
        private List<PetShop> petShops;

        public RegistroPetShop()
        {
            petShops = new List<PetShop>();
        }

        public void addPetShop(PetShop petShop)
        {
            petShops.Add(petShop);
        }

        public string calcularMelhorPetshop(int qtdPequeno, int qtdGrande)
        {
            PetShop melhor = petShops[0];
           
            string retorno = petShops[0]._nome+" "+melhor.calcularValorBanho(qtdPequeno,qtdGrande);

            for (int i = 1; i < petShops.Count; i++) {

                double temp1 = petShops[i].calcularValorBanho(qtdPequeno, qtdGrande);
                double temp2 = melhor.calcularValorBanho(qtdPequeno, qtdGrande);

                if (temp1 < temp2)
                {
                    melhor = petShops[i];
                    retorno = petShops[i]._nome + " " + temp1;
                }
                else if (temp1 == temp2) {

                    melhor = menorDistancia(melhor, petShops[i]);
                    retorno = melhor._nome + " " + temp1;
                }
            }

            return "Melhor PetShop = "+retorno;
        }

        public PetShop menorDistancia(PetShop petShop1, PetShop petShop2)
        {
            if (petShop1.distanciaCanil <= petShop2.distanciaCanil) { return petShop1; } else { return petShop2; }
        }


        public override string ToString() { 
        
            StringBuilder Builder = new StringBuilder();
            for (int i = 0; i < petShops.Count; i++) { 
                Builder.AppendLine(petShops[i].ToString());
            }

            return Builder.ToString();
        }
    }
}
