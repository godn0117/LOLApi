using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOLAPI
{
    class Item
    {
        
        private int code; // 코드

        public int Code
        {
            get { return code; }
            set { code = value; }
        }

        private string name;

        public string Name // 이름
        {
            get { return name; }
            set { name = value; }
        }

        private string description;

        public string Description // 설명
        {
            get { return description; }
            set { description = value; }
        }

        private string plaintext;

        public string Plaintext // 부연 설명
        {
            get { return plaintext; }
            set { plaintext = value; }
        }

        private string image; // img 저장이름

        public string Image
        {
            get { return image; }
            set { image = value; }
        }

        private int gold; // 판매 가격

        public int Gold
        {
            get { return gold; }
            set { gold = value; }
        }
    }
}
