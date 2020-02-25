using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 : IJogador
    {
        public readonly string nome;

        public Jogador1(string nome)
        {
            this.nome = nome;
        }

        public string Chuta()
        {
            return $"{this.nome} está chutando";
        }

        public string Corre()
        {
            return $"{this.nome} está correndo";
        }

        public string Passe()
        {
            return $"{this.nome} está passando";
        }
    }
}