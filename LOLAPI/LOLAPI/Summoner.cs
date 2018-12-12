using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOLAPI
{
    class Summoner
    {
        // "profileIconId": 3632,
        // "name": "곱등성님",
        // "puuid": "2OJoLIxeJw9vgVTBPyMSd4Fkj633StKyZXixrdZdT0OAuqAmqIuz0gc4mzWbUbM4NyqXlaoZ27V_hg",
        // "summonerLevel": 76,
        // "accountId": "QRxVNH00J1JNuDjEz7xFUjhS7Pe5lzv_OMLonhcb2kEzZ5w",
        // "id": "iV1drko-kBrSEOX5zjL0juduKI1oOlyjHHhY174fYv1lGwU",
        // "revisionDate": 1544252435000

        // "profileIconId": 779,
        // "name": "YGYU",
        // "puuid": "wZI59yI93EJoqC6W9mGQ7D3OIzqufkskI7aG5oLx8LFumlg6bYu1dvUFfQ62vyZ81uB4GDnj1ojQsg",
        // "summonerLevel": 92,
        // "accountId": "msBUN0YwzvyZA2yq6Z-5IBhh2lsE7F7pGZOnZ33kQVRVlHY",
        // "id": "hDCNqnmY6cUp-hHYrT514N1JaIxbTKzdvcl-wwR6ggwgQeg",
        // "revisionDate": 1544076865000

        // https://kr.api.riotgames.com/lol/summoner/v4/summoners/by-name/YGYU
        // "Origin": "https://developer.riotgames.com",
        // "Accept-Charset": "application/x-www-form-urlencoded; charset=UTF-8",
        // "X-Riot-Token": "RGAPI-a7408503-0984-4aa4-98ab-328fdd41a6de",
        // "Accept-Language": "ko-KR,ko;q=0.9,en-US;q=0.8,en;q=0.7",
        // "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.110 Safari/537.36"


        private int profileIconId;

        public int ProfileIconId
        {
            get { return profileIconId; }
            set { profileIconId = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string puuid;

        public string Puuid
        {
            get { return puuid; }
            set { puuid = value; }
        }

        private int summonerLevel;

        public int SummonerLevel
        {
            get { return summonerLevel; }
            set { summonerLevel = value; }
        }

        private string accountId;

        public string AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }

        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private long revisionDate;

        public long RevisionDate
        {
            get { return revisionDate; }
            set { revisionDate = value; }
        }

    }
}
