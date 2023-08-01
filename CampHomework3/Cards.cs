using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampHomework3
{

    class Cards
    {
        private string _name;
        private Element _element;
        private int _power;
        private WorldView _worldView;
        public string Name { get { return _name; } private set { } }
        public Element Elements { get { return _element;  } private set { } }
        public int Power { get { return _power; } private set { } }

        public Cards(string name, Element element, int power, WorldView worldView)
        {
            _worldView = worldView;
            _name = Name;
            _element = Elements;
            _power = Power;
        }      
    }
    enum Element
    {
        Fire,
        Water,
        Terra,
        Air
    }
}
