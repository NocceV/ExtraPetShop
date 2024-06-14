using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esboço
{
    internal class PetShop
    {
        public string _nome;
        public double distanciaCanil;
        private double precoCaoPequeno;
        private double precoCaoGrande;

        public PetShop(string nome, double distanciaCanil, double precoCaoPequeno, double precoCaoGrande)
        {
            _nome = nome;
            this.distanciaCanil = distanciaCanil;
            this.precoCaoPequeno = precoCaoPequeno;
            this.precoCaoGrande = precoCaoGrande;
        }

        public double calcularValorBanho(int qtdPequeno,int qtsGrande)
        {
            return(qtdPequeno *precoCaoPequeno)+(qtsGrande *precoCaoGrande);
        }

        public override string ToString()
        {
            return "----------------------------" +
                "\nPet Shop: " + _nome + "\nPreço Cão Pequeno: " + precoCaoPequeno+ "\nPreço Cão grande: "+ precoCaoGrande+"\nDistância do canil em metros: "+ distanciaCanil;
        }
    }
}
