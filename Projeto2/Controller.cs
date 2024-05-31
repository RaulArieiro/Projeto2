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
                    MenuOrdenaçao(jogos);

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
    }
}

        private void MenuOrdenaçao(IEnumerable<Jogo> jogos){
            int escolha3;

            try{
                escolha3 = int.Parse(view.MostrarMenuOrdenaçao());                
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
                    MenuOrdenaçao(jogos);
                    break;   
            }          
        }
        private void MenuFlitragem(IEnumerable<Jogo> jogos){
            int escolha4;

            try{
                escolha4 = int.Parse(view.MostrarMenuOrdenaçao());                
            }catch{
                escolha4 = 0;
            }
            switch(escolha4){
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
                    jogos = jogos.OrderBy(suporta => suporta.Suporte);
                    break;  
                case 8:
                    jogos = jogos.OrderBy(window => window.Windows);
                    break;    
                case 9:
                    jogos = jogos.OrderBy(linux => linux.Linux);
                    break;   
                case 10:
                    jogos = jogos.OrderBy(mac => mac.Mac);
                    break;
                case 11:
                    jogos = jogos.OrderBy(single => single.Single);
                    break;
                case 12:
                    jogos = jogos.OrderBy(multi => multi.Multi);
                    break;
                case 13:
                    jogos = jogos.OrderBy(edita => edita.Editor);
                    break;
                case 14:
                    jogos = jogos.OrderBy(vr => vr.VR);
                    break;                    
                default:
                    view.MostrarErro();
                    MenuFlitragem(jogos);
                    break;   
            }

        }
        
    }
}