using System.Drawing.Text;

namespace Xoxgame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void XOXtiklama(object sender, EventArgs e)//9 tane butonun click eventini ayn� ba�vuruya ba�lad�k
        {
            Button bt = sender as Button;// 9unada ayn� anda t�kland�g� i�in ayn� anda se�memize yar�yor
            //bt.Text = "X";
           
            
            
            //s�ra x ve o lara ge�ecek
            
            
            if (label1.Text=="X") 
            {
                bt.Text = "X";
                bt.Enabled = false;//bi bas�lan but�na bir daha bas�lmas�n diye 
            
               label1.Text = "O";//s�ra O lara ge�ecek.
            
            }

            else
            {
                bt.Text = "O";
                bt.Enabled = false;
                label1.Text ="X";
            
            }


            //X LER ���N �HT�MAL 

            if (button1.Text == "X" && button2.Text=="X" && button3.Text =="X") //X LER O LAR ���N SEK�Z �HT�MAL VAR 3 �HT�MAL YATAY 3 �HT�MAL D�KEY VE 2 �HT�MAL DE �APRAZ
            {
                MessageBox.Show("X ler kazand� ");
                Gameover();
            }

            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                MessageBox.Show("X ler kazand� ");
                Gameover();
            }

            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X ler kazand� ");
                Gameover();
            }

            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("X ler kazand� ");
                Gameover();
            }

            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                MessageBox.Show("X ler kazand� ");
                Gameover();
            }
            
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X ler kazand� ");
                Gameover();
            }
            
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X ler kazand� ");
                Gameover();
            }

           if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
           {
                MessageBox.Show("X ler kazand� ");
                Gameover();
           }
           
            
        



           //O LAR ���N �HT�MAL 


            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("O lar kazand� ");
                Gameover();
            }

            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                MessageBox.Show("O lar kazand� ");
                Gameover();
            }

            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O lar kazand� ");
                Gameover();
            }

            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("O lar kazand� ");
                Gameover();
            }
            
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                MessageBox.Show("O lar kazand� ");
                Gameover();
            }

            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O lar kazand� ");
                Gameover();
            }

            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show(" O lar kazand� ");
                Gameover();
            }

            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("O lar kazand� ");
                Gameover();
            }

            
            
            
            
            //BERABERE �H�MMAL�

            if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != ""  )
            {
                MessageBox.Show("berabere");
               Gameover();
            }

        }

        
        
        
        
        private void Gameover()//OYUNUN TEKRAR BASLAMASI ���N
        {

            label1.Text = "X";
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            

           

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        
        
        }




    }
}