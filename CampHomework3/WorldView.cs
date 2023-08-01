using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampHomework3
{
    class WorldView
    {
        private Dictionary<NameOfWorldView, int> _worldView;
        public Dictionary<NameOfWorldView, int> WorldViewInfo { get { return _worldView; } private set { _worldView = value; } }
        public WorldView(Dictionary<NameOfWorldView, int> worldViewInfo)
        {
            worldViewInfo = WorldViewInfo;
        }       
    }
    enum NameOfWorldView
    {
        Morale,
        Ethics
    }
   
}
