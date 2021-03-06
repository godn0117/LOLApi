﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOLAPI
{
    class Champion
    {
        private string version;

        public string Version
        {
            get { return version; }
            set { version = value; }
        }

        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private int key;

        public int Key
        {
            get { return key; }
            set { key = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string blurb;

        public string Blurb
        {
            get { return blurb; }
            set { blurb = value; }
        }

        private ChampionInfo info;

        public ChampionInfo Info
        {
            get { return info; }
            set { info = value; }
        }

        private ApiImage image;

        public ApiImage Image
        {
            get { return image; }
            set { image = value; }
        }

        private string[] tags;

        public string[] Tags
        {
            get { return tags; }
            set { tags = value; }
        }

        private float hp;

        public float Hp
        {
            get { return hp; }
            set { hp = value; }
        }

        private float hpperlevel;

        public float Hpperlevel
        {
            get { return hpperlevel; }
            set { hpperlevel = value; }
        }

        private float mp;

        public float Mp
        {
            get { return mp; }
            set { mp = value; }
        }

        private float mpperlevel;

        public float Mpperlevel
        {
            get { return mpperlevel; }
            set { mpperlevel = value; }
        }

        private float movespeed;

        public float Movespeed
        {
            get { return movespeed; }
            set { movespeed = value; }
        }

        private float armor;

        public float Armor
        {
            get { return armor; }
            set { armor = value; }
        }

        private float armorperlevel;

        public float Armorperlevel
        {
            get { return armorperlevel; }
            set { armorperlevel = value; }
        }

        private float spellblock;

        public float Spellblock
        {
            get { return spellblock; }
            set { spellblock = value; }
        }

        private float spellblockperlevel;

        public float Spellblockperlevel
        {
            get { return spellblockperlevel; }
            set { spellblockperlevel = value; }
        }

        private float attackrange;

        public float Attackrange
        {
            get { return attackrange; }
            set { attackrange = value; }
        }

        private float hpregen;

        public float Hpregen
        {
            get { return hpregen; }
            set { hpregen = value; }
        }

        private float hpregenperlevel;

        public float Hpregenperlevel
        {
            get { return hpregenperlevel; }
            set { hpregenperlevel = value; }
        }

        private float mpregen;

        public float Mpregen
        {
            get { return mpregen; }
            set { mpregen = value; }
        }

        private float mpregenperlevel;

        public float Mpregenperlevel
        {
            get { return mpregenperlevel; }
            set { mpregenperlevel = value; }
        }

        private float crit;

        public float Crit
        {
            get { return crit; }
            set { crit = value; }
        }

        private float critperlevel;

        public float Critperlevel
        {
            get { return critperlevel; }
            set { critperlevel = value; }
        }

        private float attackdamage;

        public float Attackdamage
        {
            get { return attackdamage; }
            set { attackdamage = value; }
        }

        private float attackdamageperlevel;

        public float Attackdamageperlevel
        {
            get { return attackdamageperlevel; }
            set { attackdamageperlevel = value; }
        }

        private float attackspeed;

        public float Attackspeed
        {
            get { return attackspeed; }
            set { attackspeed = value; }
        }

        private float attackspeedperlevel;

        public float Attackspeedperlevel
        {
            get { return attackspeedperlevel; }
            set { attackspeedperlevel = value; }
        }
    }
}
