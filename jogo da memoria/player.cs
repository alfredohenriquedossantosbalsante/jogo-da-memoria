using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace jogo_da_memoria
{
    internal class player
    {
        //atributos
        public string _name;
        int _score;
        TimeSpan _gameTime;
        public player(string name)
        {
            Name = name;
            Score = 0;
            GameTime = TimeSpan.FromSeconds(0);
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
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
        public override string ToString()
        {
            return "Nome: " + Name +
                "\nPontuação: " + Score +
                $"\nTempo de partida:  {GameTime :hh\\:mm\\:ss}" +
                "\nquantidade de jogadas: " + Name + ": "+ ;
        }
        
    }
}
