using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace VSPROEKT
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        Play play;
        Settings settings = new Settings();
       
        static ListOfPlayers ListOfplayers = new ListOfPlayers();
        HighScore highScore = new HighScore(ListOfplayers);

        string filePath;

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //otvori ja formata i ako vlezot e ok
            RegisterPlayer regPlayer = new RegisterPlayer();
            if (regPlayer.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                //dodadi go igracot vo highScore listata i pusti go
                //vo play formata za da se menuvaat negovite poeni
                ListOfplayers.players.Add(regPlayer.player);
                highScore.fillList();
                play = new Play(settings, regPlayer.player, highScore);
                play.Show();
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            settings.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHighScore_Click(object sender, EventArgs e)
        {
            highScore.fillList();
            highScore.Show();
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
           Serialize();
        }

        public void Serialize()//save the file
        {
             

           IFormatter fmt = new BinaryFormatter();
           FileStream strm = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None);
           fmt.Serialize(strm, ListOfplayers);
           strm.Close();
        }


        public void Deserialize()//opens the file
        {
            
            IFormatter fmt = new BinaryFormatter();
            FileStream strm = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.None);
            ListOfplayers = (ListOfPlayers)fmt.Deserialize(strm);
            strm.Close();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            filePath = Directory.GetCurrentDirectory().ToString();
            filePath += "\\HighScoreFile.hs";

            if (System.IO.File.Exists(filePath))
            {
                Deserialize();
            }
            else {
                Serialize();
            }

            pbCsGo.Image = Properties.Resources.csgo;
           
            btnPlay.Image = Properties.Resources.btnPlay;
            btnHighScore.Image = Properties.Resources.btnHighScore;
            btnSettings.Image = Properties.Resources.btnSettings;
            btnExit.Image = Properties.Resources.btnExit;
             
            Deserialize();
            highScore = new HighScore(ListOfplayers);
            highScore.fillList();
        }

   
    }
}
