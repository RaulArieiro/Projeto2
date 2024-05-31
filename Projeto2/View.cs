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
        public string MostrarMenuOrdenaçao(){
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
                Console.WriteLine("2. Idade");
                Console.WriteLine("3. Nota no Metacritic");
                Console.WriteLine("4. Número de recomendações");
                Console.WriteLine("5. Suporte de controlador");
                Console.WriteLine("6. Suporte para Windows");
                Console.WriteLine("7. Suporte para Linux");
                Console.WriteLine("8. Suporte para Mac");
                Console.WriteLine("9. Suporte para singleplaye");
                Console.WriteLine("10. Suporte para multiplaye");
                Console.WriteLine("11. Suporte para COP");
                Console.WriteLine("12. Inclusão de editor de níveis");
                Console.WriteLine("13. Suporte para VR \n");

            return Console.ReadLine();
        }
        
        public void MostrarJogo(int ID, string Nome, DateTime Data, int NumDLC, int Nota, int NumRecom, int NumCompraram, int NumOfPlayers, int Numachievements){
            Console.WriteLine($"{ID}");
            Console.WriteLine($"{Nome}");
            Console.WriteLine($"{Data}");
            Console.WriteLine($"{NumDLC}");
            Console.WriteLine($"{Nota}");
            Console.WriteLine($"{NumRecom}");
            Console.WriteLine($"{NumCompraram}");
            Console.WriteLine($"{NumOfPlayers}");
            Console.WriteLine($"{Numachievements}");
        }
        public void MostrarErro(){
            Console.WriteLine("Algo aconteçeu");
        }
    }
}