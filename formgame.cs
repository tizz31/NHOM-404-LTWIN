using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using System.Reflection;


namespace caro222
{
    public partial class formgame : Form
    {   
        // Biến lưu tên người chơi
        private string player1; 
        private string player2;  

        bool turn = true; // true = lượt của X, false = lượt của O
        int turncount = 0;

        public formgame(string player1Name, string player2Name)
        {
            InitializeComponent();
            //Gán giá trị từ tham số cho biến player
            this.player1 = player1Name; 
            this.player2 = player2Name;  
        }

        
        private void formgame_Load(object sender, EventArgs e)
        {
            lblTurn.Text = "Lượt của X : " + player1; // Đặt ban đầu là lượt của người chơi 1
        }

        // Sự kiện xử lý khi một nút (ô chơi) được nhấn
        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender; 

            if (turn) // Nếu là lượt của X
            {
                b.Text = "X";
                lblTurn.Text = "Lượt của 0 : " + player2; 
            }
            else // Nếu là lượt của O
            {
                b.Text = "O"; 
                lblTurn.Text = "Lượt của X : " + player1; 
            }

            turn = !turn; // Đổi lượt sau khi người chơi nhấn
            turncount++; 
            b.Enabled = false; // Vô hiệu hoá nút sau khi đã nhấn
            check(); 
        }


        // Hàm kiểm tra xem có người thắng hay không
        public void check()
        {
            string winner = ""; // Biến lưu tên người thắng, cài đặt giá trị ban đầu là rỗng 


            // Kiểm tra các hàng ngang
            if ((a1.Text == a2.Text) && (a2.Text == a3.Text) && a1.Text != "")
            {
                if (a1.Text == "X") winner = player1;
                else if (a1.Text == "O") winner = player2;
            }
            else if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && b1.Text != "")
            {
                if (b1.Text == "X") winner = player1;
                else if (b1.Text == "O") winner = player2;
            }
            else if ((c1.Text == c2.Text) && (c2.Text == c3.Text) && c1.Text != "")
            {
                if (c1.Text == "X") winner = player1;
                else if (c1.Text == "O") winner = player2;
            }

            // Kiểm tra các cột dọc
            else if ((a1.Text == b1.Text) && (b1.Text == c1.Text) && a1.Text != "")
            {
                if (a1.Text == "X") winner = player1;
                else if (a1.Text == "O") winner = player2;
            }
            else if ((a2.Text == b2.Text) && (b2.Text == c2.Text) && a2.Text != "")
            {
                if (a2.Text == "X") winner = player1;
                else if (a2.Text == "O") winner = player2;
            }
            else if ((a3.Text == b3.Text) && (b3.Text == c3.Text) && a3.Text != "")
            {
                if (a3.Text == "X") winner = player1;
                else if (a3.Text == "O") winner = player2;
            }

            // Kiểm tra các đường chéo
            else if ((a1.Text == b2.Text) && (b2.Text == c3.Text) && a1.Text != "")
            {
                if (a1.Text == "X") winner = player1;
                else if (a1.Text == "O") winner = player2;
            }
            else if ((a3.Text == b2.Text) && (b2.Text == c1.Text) && a3.Text != "")
            {
                if (a3.Text == "X") winner = player1;
                else if (a3.Text == "O") winner = player2;
            }

            // Nếu đã xác định người thắng
            if (!string.IsNullOrEmpty(winner))
            {
                MessageBox.Show("Người chiến thắng là " + winner + ". Nhấn OK để bắt đầu lại trò chơi.");
                Sound();
                Restart(); 
            }
            // Nếu đã đi hết 9 lượt mà không có người thắng thì hòa
            else if (turncount == 9)
            {
                MessageBox.Show("Trận đấu hòa. Nhấn OK để bắt đầu lại.");
                Restart();
            }
        }
        // Hàm phát nhạc 
        private void Sound ()
        {
            string localPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "chienthang.wav");
            using (SoundPlayer player = new SoundPlayer(localPath))
            {
                player.PlaySync(); 
            }
        }

        // Hàm khởi động lại trò chơi
        private void Restart()
        {
            // Lặp qua các nút trong form để reset lại trạng thái
            foreach (Control c in Controls.OfType<Button>())
            {
                // Loại trừ nút Restart (btnr) không bị reset
                if (c.Name != "btnr")
                {
                    c.Enabled = true;     // Kích hoạt lại nút
                    c.Text = "";          // Xóa chữ trong các nút chơi (X và O)
                }
            }

            turncount = 0; // Đặt lại số lượt
            turn = true;   // Reset lại lượt để bắt đầu với người chơi 1 (X)
            lblTurn.Text = "Lượt của X :" + player1; 
        }
       

        // Sự kiện xử lý khi nút Restart được nhấn
        private void btnr_Click(object sender, EventArgs e)
        {
            Restart(); 
        }

        private void Formgame_FormClosed(object sender, FormClosedEventArgs e)
        {
           Application.Exit(); 
        }
    }
}
