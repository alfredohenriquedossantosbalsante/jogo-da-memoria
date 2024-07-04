using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_da_memoria
{
    internal class Player
    {
        //Atributos
        private string _name;
        private int _score;
        private TimeSpan _gameTime;
        private int _jogadas;

        public Player(string name)
        {
            Name = name;
            Score = 0;
            GameTime = TimeSpan.FromSeconds(0);
            Jogadas = 0;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _name = value;
            }
        }

        public int Score
        {
            get { return _score; }
            set
            {
                if (value >= 0)
                    _score += value;
            }
        }

        public TimeSpan GameTime
        {
            get { return _gameTime; }
            set
            {
                _gameTime += value;
            }
        }

        public int Jogadas
        {
            get { return _jogadas; }
            set
            {
                _jogadas += value;
            }
        }

        public override string ToString()
        {
            return "Nome: " + Name +
            "\nPontuação: " + Score +
            $"\nTempo de Partida: {GameTime:hh\\:mm\\:ss}" +
            "\njogadas: " + Jogadas;
        }
    }
}
