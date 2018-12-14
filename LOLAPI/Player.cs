using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOLAPI
{
    class Player
    {
        private string currentPlatformId;

        public string CurrentPlatformId
        {
            get { return currentPlatformId; }
            set { currentPlatformId = value; }
        }

        private string summonerName;

        public string SummonerName
        {
            get { return summonerName; }
            set { summonerName = value; }
        }
        private string matchHistoryUri;

        public string MatchHistoryUri
        {
            get { return matchHistoryUri; }
            set { matchHistoryUri = value; }
        }
        private string platformId;

        public string PlatformId
        {
            get { return platformId; }
            set { platformId = value; }
        }

        private string currentAccountId;

        public string CurrentAccountId
        {
            get { return currentAccountId; }
            set { currentAccountId = value; }
        }

        private int profileIcon;

        public int ProfileIcon
        {
            get { return profileIcon; }
            set { profileIcon = value; }
        }

        private string summonerId;

        public string SummonerId
        {
            get { return summonerId; }
            set { summonerId = value; }
        }

        private string accountId;

        public string AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }

        private int participantId;

        public int ParticipantId
        {
            get { return participantId; }
            set { participantId = value; }
        }



    }
}
