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
            _name = name;
            _score = 0;
            _gameTime = TimeSpan.FromSeconds(0);
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
        public TimeSpan gametime
        {
            get { return _gameTime; }
            set
            {
                _gameTime += value; 
            }
        }
    }
}
