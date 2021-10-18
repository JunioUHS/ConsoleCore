using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador3 : IJogador
    {
        public string Chuta()
        {
            return "Teste chuta\n";
        }

        public string Corre()
        {
            return "Teste corre\n";
        }

        public string Passe()
        {
            return "Teste passe\n";
        }
    }
}