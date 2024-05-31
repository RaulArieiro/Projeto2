using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto2
{
    public class View
    {
        public string MostrarMenuPrincipal(){
            Console.WriteLine("\n1. Defenir pesquisa");
            Console.WriteLine("2. Realizar pesquisa");
            Console.WriteLine("3. Sair \n");

            return Console.ReadLine();
        }
        public string MostrarMenuSecundario(){
            	Console.WriteLine("\n1. Indicar critério de ordenação");
                Console.WriteLine("2. Indicar critérios de filtragem");
                Console.WriteLine("3. Voltar \n");

                return Console.ReadLine();
        }
        public string MostrarMenuOrdenacao(){
                Console.WriteLine("\n1. O ID do menor até o maior");
                Console.WriteLine("2. O nome por ordem alfabetica");              
                Console.WriteLine("3. A data de lançamento mais antiga a mais recente");
                Console.WriteLine("4. Numero de DLC da menor até o maior numero de DLC");
                Console.WriteLine("5. A nota no Metacritic menor para maior");
                Console.WriteLine("6. Numero de recomento da melhores até as piores");
                Console.WriteLine("7. Numero de copias compradas maior até menor");
                Console.WriteLine("8. Numero de players ativos maior até menor ");
                Console.WriteLine("9. Numero de achievements o que tem mais até o que tem menos \n");
    
                return Console.ReadLine();
        }
        public string MostrarFlitragem(){
                Console.WriteLine("\n1. Nome");
                Console.WriteLine("2. Data");
                Console.WriteLine("3. Idade");
                Console.WriteLine("4. Nota no Metacritic");
                Console.WriteLine("5. Número de recomendações");
                Console.WriteLine("6. Suporte de controlador");
                Console.WriteLine("7. Suporte para Windows");
                Console.WriteLine("8. Suporte para Linux");
                Console.WriteLine("9. Suporte para Mac");
                Console.WriteLine("10. Suporte para singleplaye");
                Console.WriteLine("11. Suporte para multiplaye");
                Console.WriteLine("12. Suporte para COP");
                Console.WriteLine("13. Inclusão de editor de níveis");
                Console.WriteLine("14. Suporte para VR \n");

            return Console.ReadLine();
        }
        
        public void MostrarJogo(int ID, string Nome, DateTime Data, int NumDLC, int Nota, int NumRecom, int NumCompraram, int NumOfPlayers, int Numachievements){
            Console.WriteLine($"\nO id do jogo: {ID}");
            Console.WriteLine($"O nome do jogo: {Nome}");
            Console.WriteLine($"A data de lançamento: {Data}");
            Console.WriteLine($"Numero de DLC: {NumDLC}");
            Console.WriteLine($"Sua avalição: {Nota}");
            Console.WriteLine($"Numero de recomendações: {NumRecom}");
            Console.WriteLine($"Numero de copias compradas: {NumCompraram}");
            Console.WriteLine($"Players ativos: {NumOfPlayers}");
            Console.WriteLine($"Numero de Achievements: {Numachievements}\n");
        }
        public void MostrarErro(){
            Console.WriteLine("Algo aconteçeu");
        }
        public string nom(){
            Console.WriteLine("Escreve o nome do jogo para flitar ");
            return Console.ReadLine();
        }
        public string datee(){
            Console.WriteLine("Escreve a data de lançamento do jogo ");
            return Console.ReadLine();
        }  
        public int idad(){
            Console.WriteLine("Escreve a idade minima do jogo ");
            return Convert.ToInt32(Console.ReadLine());
        }
        public int Not(){
           Console.WriteLine("Escreve a nota minima do jogo "); 
           return Convert.ToInt32(Console.ReadLine());Console.ReadLine();
        }
        public int Reeee(){
            Console.WriteLine("Escreve o numero minimo de recomendações do jogo ");
            return Convert.ToInt32(Console.ReadLine());Console.ReadLine();
        }
    }
}