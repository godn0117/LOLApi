using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;

namespace LOLAPI
{
    public partial class ControlChampion : UserControl
    {
        public ControlChampion()
        {
            InitializeComponent();
        }
        List<Champion> champions;
        private void ControlChampion_Load(object sender, EventArgs e)
        {
            champions = new List<Champion>();
            string serverUrl = "http://ddragon.leagueoflegends.com/cdn/8.24.1/data/ko_KR/champion.json";

            var req = WebRequest.Create(serverUrl) as HttpWebRequest;
            var res = req.GetResponse() as HttpWebResponse;
            var stream = res.GetResponseStream();
            var sr = new StreamReader(stream, Encoding.UTF8);
            var json = sr.ReadToEnd();

            JObject jObj = JObject.Parse(json);
            JObject jsondata = JObject.Parse(jObj["data"].ToString());

            List<string> ll = new List<string>();

            foreach (var item in JObject.Parse(jObj["data"].ToString()))
            {
                string id = item.Key; // 챔피언 이름
                string key = item.Value["key"].ToString(); // 챔피언 id
                string name = item.Value["name"].ToString(); // 챔피언 한글이름
                string title = item.Value["title"].ToString(); // 챔피언 타이틀
                string blurb = item.Value["blurb"].ToString(); // 챔피언 배경설명
                var itemArr = JArray.Parse(item.Value["tags"].ToString());
                foreach (var item2 in itemArr)
                {
                    ll.Add(item2.ToString());
                }

                champions.Add(new Champion { Id = id, Key = int.Parse(key), Name = name, Title = title, Blurb = blurb, Tags = ll.ToArray() });
            }

            // 챔피언 스탯
            string[] statsArr = { "hp", "hpperlevel", "mp","mpperlevel","movespeed","armor","armorperlevel","spellblock",
                "spellblockperlevel","attackrange","hpregen","hpregenperlevel","mpregen","mpregenperlevel",
                "attackdamage","attackdamageperlevel","attackspeedperlevel","attackspeed" };
            // 챔피언 정보 4가지
            string[] infoArr = { "attack", "defense", "magic", "difficulty" };
            //foreach (var item in infoArr)
            //{
            //    MessageBox.Show(jObj["data"][name]["info"][item].ToString());
            //}

            // 챔피언 이미지
            // jObj["data"]["Aatrox"]["image"]["full"].ToString();
            

            string chName = String.Empty;
            foreach (var item in champions)
            {
                chName = item.Id;
                JObject jsonCham = ReJObject(chName);
                foreach (var chamItem in JObject.Parse(jsonCham.ToString()))
                {
                    // 스탯
                    foreach (var statsItem in statsArr)
                    {
                        //MessageBox.Show(jObj["data"][chName]["stats"][statsItem].ToString());
                    }
                }
                foreach (var chamItem in JObject.Parse(jsonCham.ToString()))
                {
                    ChampionInfo ci = new ChampionInfo();
                    string[] strInfo = new string[4];
                    int i = 0;
                    foreach (var infoItem in infoArr)
                    {
                        strInfo[i++] = jObj["data"][chName]["info"][infoItem].ToString();
                        //MessageBox.Show(jObj["data"][chName]["info"][infoItem].ToString());
                    }
                    
                }
            }

            // 로딩 이미지 추가
            // http://ddragon.leagueoflegends.com/cdn/img/champion/loading/Aatrox_0.jpg // 챔피언 로딩 사진

            // 스킨 이미지 추가
            // http://ddragon.leagueoflegends.com/cdn/img/champion/splash/Aatrox_0.jpg // 챔피언 스킨 사진

            // details

        }

        private JObject ReJObject(string name)
        {
            string serverUrl = "http://ddragon.leagueoflegends.com/cdn/8.24.1/data/ko_KR/champion/" + name + ".json";
            var req = WebRequest.Create(serverUrl) as HttpWebRequest;
            var res = req.GetResponse() as HttpWebResponse;
            var stream = res.GetResponseStream();
            var sr = new StreamReader(stream, Encoding.UTF8);
            var json = sr.ReadToEnd();

            JObject jObj = JObject.Parse(json);

            return JObject.Parse(jObj["data"].ToString());
        }

        #region 체크박스
        private void checkBox1_CheckedChanged(object sender, EventArgs e) // 암살자
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) // 전사
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e) // 마법사
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e) // 서포터
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e) // 탱커
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e) // 원거리 딜러
        {

        }
        #endregion
    }
}
