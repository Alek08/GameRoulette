using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSPROEKT
{
    public partial class Play : Form
    {
        public Play(Settings settings,Player currentPlayer,HighScore highScore)
        {
            InitializeComponent();
            this.settings = settings;
            this.currentPlayer = currentPlayer;
            this.highScore = highScore;

            timerRefreshRate.Tick += new EventHandler(timerRefreshRate_Tick);// Everytime timer ticks, timer_Tick will be called
            //timerRefreshRate.Interval = 200; // Timer will tick every miliseconds
            //timerRefreshRate.Enabled = true; // Enable the timer
            //timerRefreshRate.Start(); // Start the timer

            timer1m.Tick += new EventHandler(timer1m_Tick); 

            timerstop.Tick += new EventHandler(timerstop_Tick); 

            DoubleBuffered = true;
        }

        Settings settings;
        HighScore highScore;
        NumericUpDown nudTimerInterval;
        NumericUpDown nudSpeed;
        TextBox tbSpinLasts;
        TextBox tbHorizontalScrollValue;
        public Timer timerRefreshRate = new Timer();// na sekoj tick se zgolemuva scrol za vrednosta na speed
        public int speed; //HorizontalScroll
        public Player currentPlayer;

        Color curColor;//should be global
        bool hitGreen = false;

        bool boolBtnBlackClicked, boolBtnRedClicked, boolBtnGreenClicked;

        bool Spinning;

        //timer so interval od 1milsec za da se obnovuvaat podatocite od settings formata
        Timer timer1m = new Timer();

        //timer da stopira animate za random vreme
        Timer timerstop = new Timer();

        bool spinDirection = true; // move-right=true; move-left=false;

        void timerRefreshRate_Tick(object sender, EventArgs e)
        {//pri spin se startuva timerot
            Animate();
        }

        void timer1m_Tick(object sender, EventArgs e)
        {
            // ReadOnly NumUpDown
            //za 1 millsec se citaat vrednostite na kontrolite od settings formata
            // ako sakas sam da gi postavuvas vrednostite trgni gi komentarite
            // i smeni gi readOnly na false na numUpDown 
          // timerRefreshRate.Interval = (int)nudTimerInterval.Value;
          //  speed = (int)nudSpeed.Value;
            //ReadOnly NumUpDown

            // ova se postavuva vo settings formata
            tbHorizontalScrollValue.Text = panel1.HorizontalScroll.Value.ToString();
            if (panel1.HorizontalScroll.Value >= 15049) {//move-left=false;
                spinDirection = false;
            }
            else if (panel1.HorizontalScroll.Value <= speed ) { //move-right=true;
                spinDirection = true ;//ScrollValue se namaluva za speed i ne prima vrednost 0
            }
            readColor();
        }

        public void Animate() {
            if (this.ActiveControl != null)
            {
                if (spinDirection == true)
                    panel1.HorizontalScroll.Value = panel1.HorizontalScroll.Value + speed;
                else if (spinDirection == false)
                {
                    if (panel1.HorizontalScroll.Value - speed >= 0)
                    panel1.HorizontalScroll.Value = panel1.HorizontalScroll.Value - speed;
                }
            }
        }

        private void Play_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.allInOneMultiple;
            pbArrow.Image = Properties.Resources.arrow;

            // na load se zamaat kontrolite na settings formata
            this.nudTimerInterval = settings.nudTimerInterval;
            this.nudSpeed = settings.nudSpeed;
            this.tbSpinLasts = settings.tbSpinLasts;
            this.tbHorizontalScrollValue = settings.tbHorizontalScrollValue;

            //na load vkluci go tajmerot za obnova na podatoci so settings formata
            timer1m.Interval = 1; // Timer will tick every miliseconds
            timer1m.Enabled = true; // Enable the timer
            timer1m.Start(); // Start the timer

            //zapisi koj igra i negovite poeni
            tbPlayerName.Text = currentPlayer.name;
            tbPlayerCoins.Text = currentPlayer.coins.ToString();

             boolBtnBlackClicked = false;
             boolBtnRedClicked = false;
             boolBtnGreenClicked = false;

            Spinning = false;//da ne moze da se bet dodeka vrti
        }
       

        private void btnSpin_Click(object sender, EventArgs e)
        {
                // ako ne vrt i ako betot e ok pocni so vrtenje
                if (Spinning == false &&  isBetCoinsOk() && readPlayerBetColor())
                {
                    timerRefreshRate.Interval = (int)nudTimerInterval.Value;
                    speed = (int)nudSpeed.Value;

                    timerRefreshRate.Enabled = true;
                    timerRefreshRate.Start();

                    spinStart();
               }   
        }

        public void spinStart()
        {
            Spinning = true;
            colorBetButtonsDeActivate();
            PlayerMakesBet(currentPlayer, int.Parse(tbBetCoins.Text));//namali gi parite bidejki si svrtel
            highScore.fillList();//smeni ja vrednosta na coins na tekovniot igrac bidejki se oblozil vo listata na HiScore
            Random rnd = new Random();
            int stopsIn;
            stopsIn = rnd.Next(3000, 7000);//kolku trae eden spin
            
            tbSpinLasts.Text = stopsIn.ToString();
            nudSpeed.Value = rnd.Next(20, 60);//kolku brzo vrti eden spin
            speed = (int)nudSpeed.Value;
            Cursor = Cursors.WaitCursor;

            timerstop.Interval = stopsIn; // Timer will tick every miliseconds
            timerstop.Enabled = true; // Enable the timer
            timerstop.Start(); // Start the timer
        }

        void timerstop_Tick(object sender, EventArgs e)
        {
            timerRefreshRate.Enabled = false;
            timerstop.Enabled = false;
            Cursor = Cursors.Default;
            Spinning = false;
            colorBetButtonsActivate();
            readColor();
            CountCoins();
            highScore.fillList();//smeni ja vrednosta na coins na tekovniot igrac, stavi ja novata
            betColorReset(); //koga ke zavrsi spin postavi gi na false

            checkIfLoserOrWinner();//ako nemas veke pari da igras
        }

        public void colorBetButtonsActivate()
        {
            btnBlack.Enabled = true;
            btnRed.Enabled = true;
            btnGreen.Enabled = true;
        }
        public void colorBetButtonsDeActivate()
        {
            btnBlack.Enabled = false;
            btnRed.Enabled = false;
            btnGreen.Enabled = false;
        }

        public void checkIfLoserOrWinner()
        {
            if (currentPlayer.coins == 0){
                LoserWinner l = new LoserWinner("loser");
                l.ShowDialog();
            }

            if (hitGreen){
                LoserWinner l = new LoserWinner("winner");
                l.ShowDialog();
            }

            hitGreen = false;
        }

        public void readColor()
        {
            if (this.ActiveControl != null)
            {
                //go crta panelot i negovata sodrzina(sto e vidliva za igracot) na bitmapa
                Bitmap currentLookBmap = new Bitmap(this.panel1.Width, this.panel1.Height);

                this.panel1.DrawToBitmap(currentLookBmap, new Rectangle(0, 0, this.panel1.Width, this.panel1.Height));

                //ako sakas da se zacuva momentalnata slika prikazana na panel1
                // currentLookBmap.Save("C:\\Users\\alektoni\\Desktop\\panel1.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

                //pozicija vo centarot na slikata
                int xPos = currentLookBmap.Width / 2;
                int yPos = currentLookBmap.Height / 2;

                curColor = currentLookBmap.GetPixel(xPos, yPos);//zemi ja bojata od sredina na slikata
                                                                      //prikazi ja bojata 
                Graphics showColor = panelToDisplatCurrentColor.CreateGraphics();
                SolidBrush br = new SolidBrush(curColor);
                showColor.FillRectangle(br, panelToDisplatCurrentColor.ClientRectangle);
            }
        }


        public void CountCoins()
        {
            bool green = false;
            bool red = false;
            bool black = false;

            if (curColor.R == 35 && curColor.G == 177 && curColor.B == 77)
                green = true;
             
            if (curColor.R == 237 && curColor.G == 27 && curColor.B == 36)
                red = true;

            if (curColor.R == 0 && curColor.G == 0 && curColor.B == 0)
                black = true;


            if (green && boolBtnGreenClicked){//ako se padnalo na zeleno i igracot igral na zeleno
                currentPlayer.coins += int.Parse(tbBetCoins.Text) * 14;
                hitGreen = true;
            }

            if (red && boolBtnRedClicked)//ako se padnalo na crveno i igracot igral na crveno
                currentPlayer.coins += int.Parse(tbBetCoins.Text) * 2;
              
            if (black && boolBtnBlackClicked)//ako se padnalo na crno i igracot igral na crno
                currentPlayer.coins += int.Parse(tbBetCoins.Text) * 2;

            tbPlayerCoins.Text = currentPlayer.coins.ToString();     
        }

        public bool isBetCoinsOk()
        {
           
            if (checkAllNumbers(tbBetCoins.Text) && int.Parse(tbBetCoins.Text) > 0)
            {
                int betCoins = int.Parse(tbBetCoins.Text);
                if (currentPlayer.coins >= betCoins)
                {
                    errorProvider1.SetError(tbBetCoins, null);
                    return true;
                }
                else {
                    errorProvider1.SetError(tbBetCoins, "You dont have enought coins");
                    return false;
                }
            }
            else {
                errorProvider1.SetError(tbBetCoins, "Enter only numbers greater than 0");
                return false;
            }

        }

        public void PlayerMakesBet(Player currentPlayer,int betCoins)
        {
            currentPlayer.coins = currentPlayer.coins - betCoins;
            tbPlayerCoins.Text = currentPlayer.coins.ToString();
        }

        //proveri dali nekoe kopce e stisnato
        public bool readPlayerBetColor()
        {
            if (boolBtnBlackClicked || boolBtnRedClicked || boolBtnGreenClicked)
            {
                errorProvider1.SetError(btnBlack, null);
                errorProvider1.SetError(btnRed, null);
                errorProvider1.SetError(btnGreen, null);
                return true;
            }

            else {
                errorProvider1.SetError(btnBlack, "Choose color bet");
                errorProvider1.SetError(btnRed, "Choose color bet");
                errorProvider1.SetError(btnGreen, "Choose color bet");
                return false;
            } 
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            boolBtnBlackClicked = true;
            boolBtnRedClicked = false;
            boolBtnGreenClicked = false;

            paintColorBet(Color.Black);
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            boolBtnGreenClicked = true;
            boolBtnBlackClicked = false;
            boolBtnRedClicked = false;

            paintColorBet(Color.Green);
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            boolBtnRedClicked = true;
            boolBtnBlackClicked = false;
            boolBtnGreenClicked = false;

            paintColorBet(Color.Red);
        }



        public void paintColorBet(Color col)
        {
            Graphics showColorBet = panelColorBet.CreateGraphics();
            SolidBrush br = new SolidBrush(col);
            showColorBet.FillRectangle(br, panelColorBet.ClientRectangle);
        }

        private void btnBlack_Paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            SolidBrush drawBrush = new SolidBrush(Color.White); 
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            btnBlack.Text = string.Empty;
            e.Graphics.DrawString("X2", btn.Font, drawBrush, e.ClipRectangle, sf);
        }

        private void btnGreen_Paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            SolidBrush drawBrush = new SolidBrush(Color.White);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            btnGreen.Text = string.Empty;
            e.Graphics.DrawString("X14", btn.Font, drawBrush, e.ClipRectangle, sf);
        }

        private void btnRed_Paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            SolidBrush drawBrush = new SolidBrush(Color.White);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            btnRed.Text = string.Empty;
            e.Graphics.DrawString("X2", btn.Font, drawBrush, e.ClipRectangle, sf);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbPlayerCoins_TextChanged(object sender, EventArgs e)
        {

        }

        public void betColorReset() //na reset panel color bet stavi go na belo
        {
             boolBtnBlackClicked = false;
             boolBtnRedClicked = false;
             boolBtnGreenClicked = false;
            paintColorBet(Color.White);
        }

        public bool checkAllNumbers(string betCoins)
        {
            bool onlyNum = true;
            for (int i = 0; i < betCoins.Length; i++)
                if (!Char.IsDigit(betCoins[i]))
                    onlyNum = false;
            return onlyNum;
        }


    }
}
