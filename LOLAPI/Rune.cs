using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOLAPI
{
    class Rune
    {       
        private int code; // 코드

        public int Code
        {
            get { return code; }
            set { code = value; }
        }

        private string key; // 키

        public string Key
        {
            get { return key; }
            set { key = value; }
        }

        private string icon; // 사진 

        public string Icon
        {
            get { return icon; }
            set { icon = value; }
        }

        private string name; // 이름

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string shortDesc; // 짧은 설명 

        public string ShortDesc
        {
            get { return shortDesc; }
            set { shortDesc = value; }
        }

        private string longDesc; // 긴 설명

        public string LongDesc
        {
            get { return longDesc; }
            set { longDesc = value; }
        }
    }
}
