using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caro222
{
    public partial class formmenu : Form
    {
        public formmenu()
        {
            InitializeComponent();
        }

        // Hiển thị nhãn khi con trỏ dừng lại trên TextBox
        private void TxtPlayer_MouseHover(object sender, EventArgs e)
        {
            ShowHoverMessage((Control)sender, "Nhập tên người chơi (3-9 ký tự)"); // Gọi hàm hiển thị thông báo
        }

        // Ẩn nhãn khi con trỏ rời khỏi TextBox
        private void TxtPlayer_MouseLeave(object sender, EventArgs e)
        {
            hideme();
        }

        // Hàm hiển thị nhãn thông báo
        private void ShowHoverMessage(Control control, string message)
        {
            lblH1.Text = message; // Đặt nội dung thông báo
            lblH1.Visible = true;// Hiển thị nhãn
            lblH1.Location = new Point(control.Location.X, control.Location.Y - 15);// Đặt vị trí nhãn phía trên TextBox
        }

        // Hàm ẩn nhãn thông báo
        private void hideme()
        {
            lblH1.Visible = false;// Ẩn nhãn
        }
        private void btnp_Click(object sender, EventArgs e)
        {
            string player1Name = txtPlayer1.Text;
            string player2Name = txtPlayer2.Text;

            if (string.IsNullOrWhiteSpace(player1Name) || player1Name.Length < 3 || player1Name.Length >= 10)
            {
                MessageBox.Show("Tên người chơi 1 phải có từ 3 đến 9 ký tự.");// Hiển thị thông báo nếu không hợp lệ
                return; // Dừng lại nếu tên không hợp lệ
            }

            if (string.IsNullOrWhiteSpace(player2Name) || player2Name.Length < 3 || player2Name.Length >= 10)
            {
                MessageBox.Show("Tên người chơi 2 phải có từ 3 đến 9 ký tự.");
                return;
            }

            formgame game = new formgame(player1Name, player2Name);
            game.ShowDialog();
        }
    }
}