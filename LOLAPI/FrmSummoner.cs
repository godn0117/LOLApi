using Newtonsoft.Json.Linq;
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
        private List<Summoner> lstV4 = new List<Summoner>();
        private List<SummonerV3> lstV3 = new List<SummonerV3>();
        private List<SummonerRank> lstRank = new List<SummonerRank>();

        public FrmSummoner()
        {
            InitializeComponent();
        }
        public FrmSummoner(string summonerName) : this()
        {
            this.textBox1.Text = summonerName + " 님의 전적";
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

        private void ParsingSummonerRank()
        {
            var url = "https://kr.api.riotgames.com/lol/league/v4/positions/by-summoner/" + lstV4[0].Id + "?api_key=RGAPI-7d0d811d-9e39-4d8d-b704-45793927c5a2";
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
                    this.textBox2.Text = summonerRankJson;
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

                this.dataGridView1.DataSource = lstRank;
            }

        }

        private void ParsingSummonerCode()
        {
            var url = "https://kr.api.riotgames.com/lol/summoner/v4/summoners/by-name/" + searchName + "?api_key=RGAPI-7d0d811d-9e39-4d8d-b704-45793927c5a2";
            var url2 = "https://kr.api.riotgames.com/lol/summoner/v3/summoners/by-name/" + searchName + "?api_key=RGAPI-7d0d811d-9e39-4d8d-b704-45793927c5a2";
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
                textBox1.Text = "찾으시는 소환사가 없습니다";
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
