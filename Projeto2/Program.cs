using System;
using System.Collections.Generic;


namespace Projeto2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Jogo> jogo = new List<Jogo>();

            // Ordenador ordenador = new Ordenador();

            // Flitor flitor = new Flitor(); 
            View view = new View();

            LeitorDeFicheiro leitor = new LeitorDeFicheiro();

            Controller controller = new Controller(jogo, leitor, view,"jogos.csv");


            controller.Iniciar();
            
            //Controller controller = new Controller();
            

        }
    }
}
