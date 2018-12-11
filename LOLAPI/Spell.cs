using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOLAPI
{
    class Spell
    {
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private string tooltip;

        public string Tooltip
        {
            get { return tooltip; }
            set { tooltip = value; }
        }

        private float cooldown;

        public float Cooldown
        {
            get { return cooldown; }
            set { cooldown = value; }
        }

        private int summonerLevel;

        public int SummonerLevel
        {
            get { return summonerLevel; }
            set { summonerLevel = value; }
        }

        private string[] modes;

        public string[] Modes
        {
            get { return modes; }
            set { modes = value; }
        }

        private int range;

        public int Range
        {
            get { return range; }
            set { range = value; }
        }

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        private string image;

        public string Image
        {
            get { return image; }
            set { image = value; }
        }
    }
}
