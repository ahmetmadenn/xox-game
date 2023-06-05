using System.Drawing.Text;

namespace Xoxgame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void XOXtiklama(object sender, EventArgs e)//9 tane butonun click eventini ayný baþvuruya baðladýk
        {
            Button bt = sender as Button;// 9unada ayný anda týklandýgý için ayný anda seçmemize yarýyor
            //bt.Text = "X";
           
            
            
            //sýra x ve o lara geçecek
            
            
            if (label1.Text=="X") 
            {
                bt.Text = "X";
                bt.Enabled = false;//bi basýlan butýna bir daha basýlmasýn diye 
            
               label1.Text = "O";//sýra O lara geçecek.
            
            }

            else
            {
                bt.Text = "O";
                bt.Enabled = false;
                label1.Text ="X";
            
            }


            //X LER ÝÇÝN ÝHTÝMAL 

            if (button1.Text == "X" && button2.Text=="X" && button3.Text =="X") //X LER O LAR ÝÇÝN SEKÝZ ÝHTÝMAL VAR 3 ÝHTÝMAL YATAY 3 ÝHTÝMAL DÝKEY VE 2 ÝHTÝMAL DE ÇAPRAZ
            {
                MessageBox.Show("X ler kazandý ");
                Gameover();
            }

            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                MessageBox.Show("X ler kazandý ");
                Gameover();
            }

            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X ler kazandý ");
                Gameover();
            }

            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("X ler kazandý ");
                Gameover();
            }

            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                MessageBox.Show("X ler kazandý ");
                Gameover();
            }
            
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X ler kazandý ");
                Gameover();
            }
            
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X ler kazandý ");
                Gameover();
            }

           if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
           {
                MessageBox.Show("X ler kazandý ");
                Gameover();
           }
           
            
        



           //O LAR ÝÇÝN ÝHTÝMAL 


            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("O lar kazandý ");
                Gameover();
            }

            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                MessageBox.Show("O lar kazandý ");
                Gameover();
            }

            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O lar kazandý ");
                Gameover();
            }

            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("O lar kazandý ");
                Gameover();
            }
            
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                MessageBox.Show("O lar kazandý ");
                Gameover();
            }

            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O lar kazandý ");
                Gameover();
            }

            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show(" O lar kazandý ");
                Gameover();
            }

            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("O lar kazandý ");
                Gameover();
            }

            
            
            
            
            //BERABERE ÝHÝMMALÝ

            if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != ""  )
            {
                MessageBox.Show("berabere");
               Gameover();
            }

        }

        
        
        
        
        private void Gameover()//OYUNUN TEKRAR BASLAMASI ÝÇÝN
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