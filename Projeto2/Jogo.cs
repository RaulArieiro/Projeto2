using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto2
{
    public class Jogo
    {
        public string Nome{get;}
        public int ID {get;} 
        public DateTime Data {get;}
        public int Idade {get;}
        public int NumDLC {get;}
        public int Nota {get;}
        public int Numtralers {get;}
        public int NumRecom {get;}
        public int NumPrint {get;}
        public int NumCompraram {get;}
        public int NumOfPlayers {get;}
        public int Numachievements {get;}
        public bool Suporte {get;}
        public bool Windows {get;}
        public bool Linux {get;}
        public bool Mac {get;}
        public bool Single {get;}
        public bool Multi {get;}
        public bool Cop {get;}
        public bool Editor {get;}
        public bool VR {get;}
        public Uri URL {get;}
        public string Descricao {get;}
        public Uri Imagem {get;}
        public Uri Website {get;}

        public Jogo(
            int id,
            string nome,
            DateTime data,
            int idate,
            int numDLC,
            int nota,
            int numtralers,
            int numRecom,
            int numPrint,      
            int numCompraram,    
            int numOfPlayers,
            int numachievements,
            bool suporte,
            bool windows,
            bool linux,
            bool mac,
            bool single,
            bool multi,
            bool cop,
            bool editor,
            bool vr,
            Uri url,
            string descricao,
            Uri imagem,
            Uri website
        ){
            ID = id;
            Nome = nome;
            Data = data;
            Idade = Idade;
            NumDLC = numDLC;
            Nota = nota;
            Numtralers = numtralers;
            NumRecom = numRecom;
            NumPrint = numPrint;
            NumCompraram = numCompraram;
            NumOfPlayers = numOfPlayers;
            Numachievements = numachievements;
            Suporte = suporte;
            Windows = windows;
            Linux = linux;
            Mac = mac;
            Single = single;
            Multi = multi;
            Cop = cop;
            Editor = editor;
            VR = vr;
            Descricao = descricao;
            Imagem = imagem;
            Website = website;
        }
    }
}