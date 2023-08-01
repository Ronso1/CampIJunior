using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampHomework3
{
    class Enemy
    {
        private string _name;
        private float _health;
        private Element _element;
        private WorldView _worldView;
        public string Name { get { return _name; } private set { } }
        public WorldView worldView { get { return _worldView; } private set { } }

        public Enemy(string name, Element element, float health, WorldView worldView)
        {
            _name = name;
            _health = health;
            _element = element;
            _worldView = worldView;
        }
    }
}
