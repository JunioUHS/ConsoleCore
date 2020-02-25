using System;
using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFoda
    {
        private readonly IJogador jogador1;
        private readonly IJogador jogador2;

        public JogoFoda(IJogador jogador1, IJogador jogador2)
        {
            this.jogador1 = jogador1;
            this.jogador2 = jogador2;
            this.jogador2 = jogador2;
        }
        public void IniciarJogo()
        {
            Console.WriteLine(this.jogador1.Corre());
            Console.WriteLine(this.jogador1.Chuta());
            Console.WriteLine(this.jogador1.Passe());

            Console.WriteLine(this.jogador2.Corre());
            Console.WriteLine(this.jogador2.Chuta());
            Console.WriteLine(this.jogador2.Passe());
        }
    }
}