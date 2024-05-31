using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto2
{
    public class LeitorDeFicheiro
    {
        public IEnumerable<Jogo> VerificarFicheiro(string ficheiro){
            if(!File.Exists(ficheiro)){
                Environment.Exit(0);
            }
            return LerFicheiro(ficheiro);
        }
        public IEnumerable<Jogo> LerFicheiro(string ficheiro){
            string linha;
            string[] dados;
            using(StreamReader sr = new StreamReader(ficheiro)){
            sr.ReadLine();
            
                while((linha = sr.ReadLine()) != null){

                    dados = linha.Split(',');

                    DateTime data = DateTime.TryParse(dados[2], out DateTime dat ) ? dat : DateTime.MinValue; 

                    Uri suporte = Uri.TryCreate(dados[21], 0, out Uri sup) ? sup : null;
                    Uri imagem = Uri.TryCreate(dados[22], 0, out Uri img) ? sup : null;
                    Uri website = Uri.TryCreate(dados[23], 0, out Uri web) ? sup : null;

                    yield return new Jogo(
                        int.Parse(dados[0]),
                        dados[1],
                        data,                        
                        int.Parse(dados[3]),
                        int.Parse(dados[4]),
                        int.Parse(dados[5]),
                        int.Parse(dados[6]),
                        int.Parse(dados[7]),
                        int.Parse(dados[8]),
                        int.Parse(dados[9]),
                        int.Parse(dados[10]),
                        int.Parse(dados[11]),
                        bool.Parse(dados[12]),
                        bool.Parse(dados[13]),
                        bool.Parse(dados[14]),
                        bool.Parse(dados[15]),
                        bool.Parse(dados[16]),
                        bool.Parse(dados[17]),
                        bool.Parse(dados[18]),
                        bool.Parse(dados[19]),
                        bool.Parse(dados[20]),
                        suporte,
                        dados[22],
                        imagem,
                        website
                    );
                }
            }
        }
    }   

    
}