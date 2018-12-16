﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOLAPI
{
    public partial class FrmSummoner : Form
    {
        private string summonerName;

        public string SummonerName
        {
            get { return summonerName; }
            set { summonerName = value; }
        }

        string searchName;
        string json;
        string json2;
        string summonerRankJson;
        string matchJson;
        string playerJson;
        private List<Summoner> lstV4 = new List<Summoner>();
        private List<SummonerV3> lstV3 = new List<SummonerV3>();
        private List<SummonerRank> lstRank = new List<SummonerRank>();
        private List<Matches> lstMatches = new List<Matches>();
        private List<Player> lstPlayer = new List<Player>();
        private List<MatchInf> lstMatInf = new List<MatchInf>();

        public FrmSummoner()
        {
            InitializeComponent();
        }
        public FrmSummoner(string summonerName) : this()
        {
            this.label1.Text = summonerName + " 님의 전적";
            searchName = summonerName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSummoner_Load(object sender, EventArgs e)
        {
            ParsingSummonerCode();
            ParsingSummonerRank();
            ParsingMatches();
            ParsingPlayer();
            this.txtLevel.Text = "레벨 : " + lstV4[0].SummonerLevel;

            for (int i = 0; i < lstRank.Count; i++)
            {
                if (lstRank[i].QueueType == "RANKED_SOLO_5x5")
                {
                    this.txtWinLose.Text = "랭크 : " + lstRank[i].Wins + " 승  " + lstRank[i].Losses + "패";
                    this.txtGrade.Text = "등급 : " + lstRank[i].Tier + "  " + lstRank[i].Rank;
                    this.txtLeguePoints.Text = "리그 포인트 : " + lstRank[i].LeaguePoints;
                    this.txtLeagueName.Text = lstRank[i].LeagueName;
                }
                if (lstRank[i].QueueType == "RANKED_FLEX_SR")
                {
                    this.txtTeamWinLose.Text = "랭크 : " + lstRank[i].Wins + " 승  " + lstRank[i].Losses + "패";
                    this.txtTeamGrade.Text = "등급 : " + lstRank[i].Tier + "  " + lstRank[i].Rank;
                    this.txtTeamLeaguePoints.Text = "리그 포인트 : " + lstRank[i].LeaguePoints;
                    this.txtTeamLeagueName.Text = lstRank[i].LeagueName;
                }
            }
        }

        private void ParsingPlayer()
        {
            string currentPlatformId;
            string summonerName;
            string matchHistoryUri;
            string platformId;
            string currentAccountId;
            int profileIcon;
            string summonerId;
            string accountId;
            int participantId;
            int kills;
            int assists;
            int deaths;
            int goldEarned;
            int totalDamageDealtToChampions;
            int totalDamageTaken;
            int item0;
            int item1;
            int item2;
            int item3;
            int item4;
            int item5;
            int item6;
            int perk0;
            int perk1;
            int perk2;
            int perk3;
            int perk4;
            int perk5;
            bool playerwin;
            int spell1Id;
            int spell2Id;
            int championId;

            List<Player> lstplayer2 = new List<Player>();

            for (int i = 0; i < 10; i++)
            {
                var url = "https://kr.api.riotgames.com/lol/match/v4/matches/" + lstMatches[i].GameId + "?api_key=RGAPI-6fa8d8d0-1636-4b98-97e5-724bae313026";
                var req = (HttpWebRequest)WebRequest.Create(url);
                var res = (HttpWebResponse)req.GetResponse();
                var stream = res.GetResponseStream();
                var sr = new StreamReader(stream, Encoding.UTF8);
                playerJson = sr.ReadToEnd();


                var jObj = JObject.Parse(playerJson);
                var itemsArr = JArray.Parse(jObj["participantIdentities"].ToString());
                foreach (JObject item in itemsArr)
                {
                    currentPlatformId = item["player"]["currentPlatformId"].ToString();
                    summonerName = item["player"]["summonerName"].ToString();
                    matchHistoryUri = item["player"]["matchHistoryUri"].ToString();
                    platformId = item["player"]["platformId"].ToString();
                    currentAccountId = item["player"]["currentAccountId"].ToString();
                    profileIcon = Int32.Parse(item["player"]["profileIcon"].ToString());
                    summonerId = item["player"]["summonerId"].ToString();
                    accountId = item["player"]["accountId"].ToString();
                    participantId = Int32.Parse(item["participantId"].ToString());

                    Player p = new Player
                    {
                        CurrentPlatformId = currentPlatformId,
                        SummonerName = summonerName,
                        MatchHistoryUri = matchHistoryUri,
                        PlatformId = platformId,
                        CurrentAccountId = currentAccountId,
                        ProfileIcon = profileIcon,
                        SummonerId = summonerId,
                        AccountId = accountId,
                        ParticipantId = participantId
                    };

                    lstPlayer.Add(p);
                }
                var itemsArr3 = JArray.Parse(jObj["participants"].ToString());
                foreach (JObject item in itemsArr3)
                {
                    kills = Int32.Parse(item["stats"]["kills"].ToString());
                    assists = Int32.Parse(item["stats"]["assists"].ToString());
                    deaths = Int32.Parse(item["stats"]["deaths"].ToString());
                    goldEarned = Int32.Parse(item["stats"]["goldEarned"].ToString());
                    totalDamageDealtToChampions = Int32.Parse(item["stats"]["totalDamageDealtToChampions"].ToString());
                    totalDamageTaken = Int32.Parse(item["stats"]["totalDamageTaken"].ToString());
                    item0 = Int32.Parse(item["stats"]["item0"].ToString());
                    item1 = Int32.Parse(item["stats"]["item1"].ToString());
                    item2 = Int32.Parse(item["stats"]["item2"].ToString());
                    item3 = Int32.Parse(item["stats"]["item3"].ToString());
                    item4 = Int32.Parse(item["stats"]["item4"].ToString());
                    item5 = Int32.Parse(item["stats"]["item5"].ToString());
                    item6 = Int32.Parse(item["stats"]["item6"].ToString());
                    perk0 = Int32.Parse(item["stats"]["perk0"].ToString());
                    perk1 = Int32.Parse(item["stats"]["perk1"].ToString());
                    perk2 = Int32.Parse(item["stats"]["perk2"].ToString());
                    perk3 = Int32.Parse(item["stats"]["perk3"].ToString());
                    perk4 = Int32.Parse(item["stats"]["perk4"].ToString());
                    perk5 = Int32.Parse(item["stats"]["perk5"].ToString());
                    playerwin = bool.Parse(item["stats"]["win"].ToString());
                    spell1Id = Int32.Parse(item["spell1Id"].ToString());
                    spell2Id = Int32.Parse(item["spell2Id"].ToString());
                    championId = Int32.Parse(item["championId"].ToString());

                    Player p1 = new Player
                    {
                        Kills = kills,
                        Assists = assists,
                        Deaths = deaths,
                        GoldEarned= goldEarned,
                        TotalDamageDealtToChampions=totalDamageDealtToChampions,
                        TotalDamageTaken=totalDamageTaken,
                        Item0=item0,
                        Item1=item1,
                        Item2=item2,
                        Item3=item3,
                        Item4=item4,
                        Item5=item5,
                        Item6=item6,
                        Perk0=perk0,
                        Perk1=perk1,
                        Perk2=perk2,
                        Perk3=perk3,
                        Perk4=perk4,
                        Perk5=perk5,
                        Win=playerwin,
                        Spell1Id=spell1Id,
                        Spell2Id=spell2Id,
                        ChampionId=championId
                    };
                    lstplayer2.Add(p1);
                }



                List<Bans> banList = new List<Bans>();
                var itemsArr2 = JArray.Parse(jObj["teams"].ToString());
                foreach (JObject item in itemsArr2)
                {
                    bool firstDragon = bool.Parse(item["firstDragon"].ToString());

                    foreach (var banArr in JArray.Parse(item["bans"].ToString()))
                    {
                        Bans ban = new Bans();
                        ban.PickTurn = Int32.Parse(banArr["pickTurn"].ToString());
                        ban.ChampionId = Int32.Parse(banArr["championId"].ToString());
                        textBox2.Text += ban.PickTurn + " ";
                        textBox2.Text += ban.ChampionId + " \r\n";
                        banList.Add(ban);
                    }
                    bool firstInhibitor = bool.Parse(item["firstInhibitor"].ToString());
                    string win = item["win"].ToString();
                    bool firstRiftHerald = bool.Parse(item["firstRiftHerald"].ToString());
                    bool firstBaron = bool.Parse(item["firstBaron"].ToString());
                    int baronKills = Int32.Parse(item["baronKills"].ToString());
                    int riftHeraldKills = Int32.Parse(item["riftHeraldKills"].ToString());
                    bool firstBlood = bool.Parse(item["firstBlood"].ToString());
                    int teamId = Int32.Parse(item["teamId"].ToString());
                    bool firstTower = bool.Parse(item["firstTower"].ToString());
                    int vilemawKills = Int32.Parse(item["vilemawKills"].ToString());
                    int inhibitorKills = Int32.Parse(item["inhibitorKills"].ToString());
                    int towerKills = Int32.Parse(item["towerKills"].ToString());
                    int dominionVictoryScore = Int32.Parse(item["dominionVictoryScore"].ToString());
                    int dragonKills = Int32.Parse(item["dragonKills"].ToString());

                    MatchInf m = new MatchInf
                    {
                        FirstDragon = firstDragon,
                        Bans = banList,
                        FirstInhibitor = firstInhibitor,
                        Win = win,
                        FirstRiftHerald = firstRiftHerald,
                        FirstBaron = firstBaron,
                        BaronKills = baronKills,
                        RiftHeraldKills = riftHeraldKills,
                        FirstBlood = firstBlood,
                        TeamId = teamId,
                        FirstTower = firstTower,
                        VilemawKills = vilemawKills,
                        InhibitorKills = inhibitorKills,
                        TowerKills = towerKills,
                        DominionVictoryScore = dominionVictoryScore,
                        DragonKills = dragonKills
                    };

                    lstMatInf.Add(m);
                }
            }
            for (int i = 0; i < lstPlayer.Count; i++)
            {// 따로 파싱한 플레이어 정보 하나로 합침 (수정..)
                lstPlayer[i].Kills = lstplayer2[i].Kills;
                lstPlayer[i].Assists = lstplayer2[i].Assists;
                lstPlayer[i].Deaths = lstplayer2[i].Deaths;
                lstPlayer[i].GoldEarned = lstplayer2[i].GoldEarned;
                lstPlayer[i].TotalDamageDealtToChampions = lstplayer2[i].TotalDamageDealtToChampions;
                lstPlayer[i].TotalDamageTaken = lstplayer2[i].TotalDamageTaken;
                lstPlayer[i].Item0 = lstplayer2[i].Item0;
                lstPlayer[i].Item1 = lstplayer2[i].Item1;
                lstPlayer[i].Item2 = lstplayer2[i].Item2;
                lstPlayer[i].Item3 = lstplayer2[i].Item3;
                lstPlayer[i].Item4 = lstplayer2[i].Item4;
                lstPlayer[i].Item5 = lstplayer2[i].Item5;
                lstPlayer[i].Item6 = lstplayer2[i].Item6;
                lstPlayer[i].Perk0 = lstplayer2[i].Perk0;
                lstPlayer[i].Perk1 = lstplayer2[i].Perk1;
                lstPlayer[i].Perk2 = lstplayer2[i].Perk2;
                lstPlayer[i].Perk3 = lstplayer2[i].Perk3;
                lstPlayer[i].Perk4 = lstplayer2[i].Perk4;
                lstPlayer[i].Perk5 = lstplayer2[i].Perk5;
                lstPlayer[i].Win = lstplayer2[i].Win;
                lstPlayer[i].Spell1Id = lstplayer2[i].Spell1Id;
                lstPlayer[i].Spell2Id = lstplayer2[i].Spell2Id;
                lstPlayer[i].ChampionId = lstplayer2[i].ChampionId;
            }
            //this.dataGridView1.DataSource = lstMatInf;
            this.dataGridView1.DataSource = lstPlayer;
        }

        private void ParsingMatches()
        {
            var url = "https://kr.api.riotgames.com/lol/match/v4/matchlists/by-account/" + lstV4[0].AccountId + "?api_key=RGAPI-6fa8d8d0-1636-4b98-97e5-724bae313026";
            var req = (HttpWebRequest)WebRequest.Create(url);

            try
            {
                var res = (HttpWebResponse)req.GetResponse();
                var statusCode = res.StatusCode.ToString();
                if (statusCode == "OK")
                {
                    var stream = res.GetResponseStream();
                    var sr = new StreamReader(stream, Encoding.UTF8);
                    matchJson = sr.ReadToEnd();
                    //this.textBox2.Text = matchJson;
                }
                else
                {
                    MessageBox.Show("매치에러" + statusCode);
                }
            }
            catch (WebException)
            {
                MessageBox.Show("매치기록 정보 없음");
                return;
            }

            var jObj = JObject.Parse(matchJson);
            var itemsArr = JArray.Parse(jObj["matches"].ToString());

            foreach (JObject item in itemsArr)
            {
                string lane = item["lane"].ToString();
                string gameId = item["gameId"].ToString();
                int champion = Int32.Parse(item["champion"].ToString());
                string platformId = item["platformId"].ToString();
                string timestamp = item["timestamp"].ToString();
                int queue = Int32.Parse(item["queue"].ToString());
                string role = item["role"].ToString();
                int season = Int32.Parse(item["season"].ToString());

                Matches m = new Matches
                {
                    Lane = lane,
                    GameId = gameId,
                    Champion = champion,
                    PlatformId = platformId,
                    Timestamp = timestamp,
                    Queue = queue,
                    Role = role,
                    Season = season
                };
                lstMatches.Add(m);
            }
            //this.dataGridView1.DataSource = lstMatches;
        }
        private void ParsingSummonerRank()
        {
            var url = "https://kr.api.riotgames.com/lol/league/v4/positions/by-summoner/" + lstV4[0].Id + "?api_key=RGAPI-6fa8d8d0-1636-4b98-97e5-724bae313026";
            var req = (HttpWebRequest)WebRequest.Create(url);

            try
            {
                var res = (HttpWebResponse)req.GetResponse();
                var statusCode = res.StatusCode.ToString();
                if (statusCode == "OK")
                {
                    var stream = res.GetResponseStream();
                    var sr = new StreamReader(stream, Encoding.UTF8);

                    summonerRankJson = sr.ReadToEnd();
                    //this.textBox2.Text = summonerRankJson;
                }
                else
                {
                    MessageBox.Show("에러" + statusCode);
                }
            }
            catch (WebException)
            {
                MessageBox.Show("찾으시는 소환사의 랭크정보가 없습니다");
                return;
            }

            var jObj = JToken.Parse(summonerRankJson);

            var itemsArr = JArray.Parse(jObj.ToString());


            if (jObj.First != null)
            {
                string queueType = jObj.First["queueType"].ToString();
                string summonerName = jObj.First["summonerName"].ToString();
                int wins = Int32.Parse(jObj.First["wins"].ToString());
                int losses = Int32.Parse(jObj.First["losses"].ToString());
                string rank = jObj.First["rank"].ToString();
                string leagueName = jObj.First["leagueName"].ToString();
                string leagueId = jObj.First["leagueId"].ToString();
                string tier = jObj.First["tier"].ToString();
                string summonerId = jObj.First["summonerId"].ToString();
                int leaguePoints = Int32.Parse(jObj.First["leaguePoints"].ToString());
                SummonerRank sumr = new SummonerRank
                {
                    QueueType = queueType,
                    SummonerName = summonerName,
                    Wins = wins,
                    Losses = losses,
                    Rank = rank,
                    LeagueName = leagueName,
                    LeagueId = leagueId,
                    Tier = tier,
                    SummonerId = summonerId,
                    LeaguePoints = leaguePoints
                };
                lstRank.Add(sumr);

                if (jObj.First.Next != null)
                {
                    queueType = jObj.Last["queueType"].ToString();
                    summonerName = jObj.Last["summonerName"].ToString();
                    wins = Int32.Parse(jObj.Last["wins"].ToString());
                    losses = Int32.Parse(jObj.Last["losses"].ToString());
                    rank = jObj.Last["rank"].ToString();
                    leagueName = jObj.Last["leagueName"].ToString();
                    leagueId = jObj.Last["leagueId"].ToString();
                    tier = jObj.Last["tier"].ToString();
                    summonerId = jObj.Last["summonerId"].ToString();
                    leaguePoints = Int32.Parse(jObj.Last["leaguePoints"].ToString());

                    sumr = new SummonerRank
                    {
                        QueueType = queueType,
                        SummonerName = summonerName,
                        Wins = wins,
                        Losses = losses,
                        Rank = rank,
                        LeagueName = leagueName,
                        LeagueId = leagueId,
                        Tier = tier,
                        SummonerId = summonerId,
                        LeaguePoints = leaguePoints
                    };
                    lstRank.Add(sumr);
                }

                //this.dataGridView1.DataSource = lstRank;
            }

        }

        private void ParsingSummonerCode()
        {
            var url = "https://kr.api.riotgames.com/lol/summoner/v4/summoners/by-name/" + searchName + "?api_key=RGAPI-6fa8d8d0-1636-4b98-97e5-724bae313026";
            var url2 = "https://kr.api.riotgames.com/lol/summoner/v3/summoners/by-name/" + searchName + "?api_key=RGAPI-6fa8d8d0-1636-4b98-97e5-724bae313026";
            var req = (HttpWebRequest)WebRequest.Create(url);
            var req2 = (HttpWebRequest)WebRequest.Create(url2);

            try
            {
                var res = (HttpWebResponse)req.GetResponse();
                var res2 = (HttpWebResponse)req2.GetResponse();

                var statusCode = res.StatusCode.ToString();
                var statusCode2 = res2.StatusCode.ToString();

                if (statusCode == "OK" && statusCode2 == "OK")
                {
                    var stream = res.GetResponseStream();
                    var sr = new StreamReader(stream, Encoding.UTF8);
                    var stream2 = res2.GetResponseStream();
                    var sr2 = new StreamReader(stream2, Encoding.UTF8);

                    string v1 = sr.ReadToEnd();
                    string v2 = sr2.ReadToEnd();

                    //this.textBox2.Text = v1 + v2;
                    json = v1;
                    json2 = v2;
                }
                else
                {
                    MessageBox.Show("에러" + statusCode);
                }
            }
            catch (WebException)
            {
                this.label1.Text = "찾으시는 소환사가 없습니다";
                return;
            }


            var jObj = JObject.Parse(json);
            //var itemsArr = JArray.Parse(jObj.Root.ToString());
            int profileIconId = Int32.Parse(jObj["profileIconId"].ToString());
            string name = jObj["name"].ToString();
            string puuid = jObj["puuid"].ToString();
            int summonerLevel = Int32.Parse(jObj["summonerLevel"].ToString());
            string accountId = jObj["accountId"].ToString();
            string id = jObj["id"].ToString();
            string revisionDate = jObj["revisionDate"].ToString();

            Summoner s = new Summoner
            {
                ProfileIconId = profileIconId,
                Name = name,
                Puuid = puuid,
                SummonerLevel = summonerLevel,
                AccountId = accountId,
                Id = id,
                RevisionDate = revisionDate
            };

            lstV4.Add(s);


            var jobj2 = JObject.Parse(json2);
            int profileIconId2 = Int32.Parse(jobj2["profileIconId"].ToString());
            string name2 = jobj2["name"].ToString();
            int summonerLevel2 = Int32.Parse(jobj2["summonerLevel"].ToString());
            string accountId2 = jobj2["accountId"].ToString();
            string id2 = jobj2["id"].ToString();
            string revisionDate2 = jobj2["revisionDate"].ToString();

            SummonerV3 s2 = new SummonerV3
            {
                ProfileIconId = profileIconId2,
                Name = name2,
                SummonerLevel = summonerLevel2,
                AccountId = accountId2,
                Id = id2,
                RevisionDate = revisionDate2
            };

            lstV3.Add(s2);

            //this.dataGridView1.DataSource = lstV3;
            //this.dataGridView1.DataSource = lstV4;
        }
    }
}
