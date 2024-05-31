using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto2
{
    public class Controller
    {
        private IEnumerable<Jogo> jogosOriginais;
        public string ficheiro;
        public View view; 

        private LeitorDeFicheiro leitor;

        public Controller(IEnumerable<Jogo> jogos, LeitorDeFicheiro leitor, View view, string ficheiro){
            this.jogosOriginais = jogos;
            this.view = view;
            this.ficheiro = ficheiro;
            this.leitor = leitor;
        }
        public void Iniciar(){
            jogosOriginais = leitor.VerificarFicheiro(ficheiro);
            MenuPrincipal(jogosOriginais);            
        }
        private void MenuPrincipal(IEnumerable<Jogo> jogos){
            int escolha1;
            
            try{
                escolha1 = int.Parse(view.MostrarMenuPrincipal());
            }catch{
                escolha1 = 0;
            }
            switch(escolha1){
                case 1:
                    MenuSecundario(jogos);

                    break;
                case 2:
                    MenuRealizarPesquisa(jogos);
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    view.MostrarErro();
                    MenuPrincipal(jogos);
                    break;   
            }

        } 
        private void MenuSecundario(IEnumerable<Jogo> jogos){
            int escolha2;

            try{
                escolha2 = int.Parse(view.MostrarMenuSecundario());                
            }catch{
                escolha2 = 0;
            }
            switch(escolha2){
                case 1:
                    MenuOrdenacao(jogos);

                    break;
                case 2:
                    MenuFlitragem(jogos);
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    view.MostrarErro();
                    MenuSecundario(jogos);
                    break;   
            }
        }
        private void MenuRealizarPesquisa(IEnumerable<Jogo> jogos){
            int jogosPorPagina = 20;

            for(int i = 0; i < jogos.Count(); i += jogosPorPagina){
                IEnumerable<Jogo> jogosParciais = jogos.Skip(i).Take(jogosPorPagina);

                foreach(Jogo j in jogosParciais){
                    view.MostrarJogo(
                    j.ID,
                    j.Nome,
                    j.Data,
                    j.NumDLC,
                    j.Nota,
                    j.NumRecom,
                    j.NumCompraram,
                    j.NumOfPlayers,
                    j.Numachievements
            );
        }
        Console.WriteLine("Escreva sair para voltar para o menu principal ");
        if(Console.ReadLine() == "sair" ){
            break;
        }
    }
    MenuPrincipal(jogos);
}

        private void MenuOrdenacao(IEnumerable<Jogo> jogos){
            int escolha3;

            try{
                escolha3 = int.Parse(view.MostrarMenuOrdenacao());                
            }catch{
                escolha3 = 0;
            }
            switch(escolha3){
                case 1:
                    jogos = jogos.OrderBy(game => game.ID);
                    break;
                case 2:
                    jogos = jogos.OrderBy(Name => Name.Nome);
                    break;               
                case 3: 
                    jogos = jogos.OrderBy(Date => Date.Data);
                    break;    
                case 4:
                    jogos = jogos.OrderBy(DLC => DLC.NumDLC);
                    break;   
                case 5:
                    jogos = jogos.OrderBy(nota => nota.Nota);
                break;     
                case 6:
                    jogos = jogos.OrderBy(Recom => Recom.NumRecom);
                    break;
                case 7:
                    jogos = jogos.OrderBy(Compra => Compra.NumCompraram);
                    break;  
                case 8:
                    jogos = jogos.OrderBy(Ativos => Ativos.NumOfPlayers);
                    break;    
                case 9:
                    jogos = jogos.OrderBy(Achie => Achie.Numachievements);
                    break;     
                default:
                    view.MostrarErro();
                    MenuOrdenacao(jogos);
                    break;   
            } 
            MenuPrincipal(jogos);         
        }
        private void MenuFlitragem(IEnumerable<Jogo> jogos){
            int escolha4;

            try{
                escolha4 = int.Parse(view.MostrarFlitragem());                
            }catch{
                escolha4 = 0;
            }
            switch(escolha4){
                case 1:
                    string guarda = view.nom();
                    jogos = jogos.Where(game => game.Nome.Contains(guarda)).Select(game => game);
                    break;
                case 2:
                    string corda = view.datee();
                    DateTime lanca = DateTime.TryParse(corda, out DateTime dat ) ? dat : DateTime.MinValue;                
                    jogos = jogos.Where(game => game.Data > lanca).Select(game => game);
                    break;               
                case 3:                     
                    int age = view.idad();
                    jogos = jogos.Where(game => game.Idade > age).Select(game => game);
                    break;    
                case 4:                  
                    int not = view.Not();
                    jogos = jogos.Where(game => game.Nota > not).Select(game => game);
                    break;   
                case 5:                   
                    int rem = view.Reeee();
                    jogos = jogos.Where(game => game.NumRecom > rem).Select(game => game);
                break;     
                case 6:               
                    jogos = jogos.Where(game => game.Suporte == true).Select(game => game);
                    break;
                case 7:
                    jogos = jogos.Where(game => game.Windows == true).Select(game => game);
                    break;  
                case 8:
                    jogos = jogos.Where(game => game.Linux == true).Select(game => game);
                    break;    
                case 9:
                    jogos = jogos.Where(game => game.Mac == true).Select(game => game);
                    break;   
                case 10:
                    jogos = jogos.Where(game => game.Single == true).Select(game => game);
                    break;
                case 11:
                    jogos = jogos.Where(game => game.Multi == true).Select(game => game);
                    break;
                case 12:
                    jogos = jogos.Where(game => game.Cop == true).Select(game => game);
                    break;
                case 13:
                    jogos = jogos.Where(game => game.Editor == true).Select(game => game);
                    break;
                case 14:
                    jogos = jogos.Where(game => game.VR == true).Select(game => game);
                    break;                    
                default:
                    view.MostrarErro();
                    MenuFlitragem(jogos);
                    break;   
            }
        MenuPrincipal(jogos);
        }
        
    }
}