using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 : IJogador
    {
        public readonly string _Nome;

        public Jogador1(string nome = "Ronaldo")
        {
            _Nome = nome;
        }

        //Chutar
        public string Chuta()
        {
            return $"{_Nome} está chutando\n";
        }
        //Correr
        public string Corre()
        {
            return $"{_Nome} está correndo\n";
        }
        //Passe
        public string Passe() 
        {
            return $"{_Nome} está passendo\n";
        }
    }
}