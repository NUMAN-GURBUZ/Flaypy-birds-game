using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FlappyBirds
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {


        int pipeSpeed = 10; // Boru (pipe) hızını tanımlar 
        int gravity = 5;    // Yerçekimini tanımlar 
        int score = 0;      // Oyuncunun puanını tutan değişken 

        public Form1()
        {
            InitializeComponent(); // Form bileşenlerini başlatır
        }

        private void gameTimer(object sender, EventArgs e)
        {
            FlappyBırds.Top += gravity; // Kuşun yukarı ya da aşağı hareket etmesini sağlar
            PipeDown.Left -= pipeSpeed;  // Aşağıdaki borunun sola hareket etmesini sağlar
            PipeTop.Left -= pipeSpeed;    // Yukarıdaki borunun sola hareket etmesini sağlar
            scoreText.Text = "Score:" + score; // Güncellenen puanı ekranda gösterir

            // Borular ekranın sol kenarını geçtiğinde (ekran dışına çıktığında) yeniden konumlandır
            if (PipeDown.Left < -150)
            {
                PipeDown.Left = 800; // Aşağıdaki boruyu sağdan başlat
                score++; // Puanı bir artır
            }
            if (PipeTop.Left < -180)
            {
                PipeTop.Left = 950; // Yukarıdaki boruyu sağdan başlat
                score++; // Puanı bir artır
            }

            // Kuşun borularla veya zeminle çarpışması durumunda oyunu sonlandır
            if (FlappyBırds.Bounds.IntersectsWith(PipeDown.Bounds) ||
                FlappyBırds.Bounds.IntersectsWith(PipeTop.Bounds) ||
                FlappyBırds.Bounds.IntersectsWith(ground.Bounds) ||
                FlappyBırds.Top < -25) // Kuş ekranın üst sınırını geçerse
            {
                endGame(); // Oyunu sonlandır
            }

            // Puan 5'i geçerse, boru hızını artır
            if (score > 5)
            {
                pipeSpeed = 15; // Boruların hızı 15 birime çıkar
            }
        }

        private void gameDown(object sender, KeyEventArgs e)
        {
            // Aşağı doğru hareket etmek için boşluk tuşuna basıldığında yerçekimini ters çevir
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5; // Kuşu yukarı itmek için yerçekimini negatif yap
            }
        }

        private void gameTop(object sender, KeyEventArgs e)
        {
            // Yukarı doğru hareket etmek için boşluk tuşuna basıldığında yerçekimini normale döndür
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5; // Yerçekimini normale döndür
            }
        }

        private void endGame()
        {
            Gametimer.Stop(); // Oyun zamanlayıcısını durdur
            scoreText.Text += "   Game Over!"; // Ekranda oyun bitti mesajını göster
        }


    }
}
 