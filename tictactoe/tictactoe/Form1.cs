using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        char who = 'o';
        short movement = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
           Button? bt = sender as Button;
           bt.Enabled = false; 
           bt.BackColor= Color.Red;
           if (who== 'o')
            {
                bt.Text = "o";
                if ((b1.Text == b2.Text && b2.Text == b3.Text && b2.Text != "")||
                    (b4.Text == b5.Text && b5.Text == b6.Text && b5.Text != "")||
                    (b7.Text == b8.Text && b8.Text == b9.Text && b8.Text != "")||
                    (b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "")||
                    (b2.Text == b5.Text && b5.Text == b8.Text && b5.Text != "")||
                    (b3.Text == b6.Text && b6.Text == b9.Text && b5.Text != "")||
                    (b1.Text == b5.Text && b5.Text == b9.Text && b5.Text != "")||
                    (b3.Text == b5.Text && b5.Text == b7.Text && b5.Text != ""))
                {
                    MessageBox.Show($"Nyert a {who.ToString().ToUpper()} játékos"); 
                }

                who = 'x';
            } 

           else if (who== 'x')
            {
                bt.Text = "x";
                if ((b1.Text == b2.Text && b2.Text == b3.Text && b2.Text != "") ||
                    (b4.Text == b5.Text && b5.Text == b6.Text && b5.Text != "") ||
                    (b7.Text == b8.Text && b8.Text == b9.Text && b8.Text != "") ||
                    (b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "") ||
                    (b2.Text == b5.Text && b5.Text == b8.Text && b5.Text != "") ||
                    (b3.Text == b6.Text && b6.Text == b9.Text && b5.Text != "") ||
                    (b1.Text == b5.Text && b5.Text == b9.Text && b5.Text != "") ||
                    (b3.Text == b5.Text && b5.Text == b7.Text && b5.Text != ""))
                {
                    MessageBox.Show($"Nyert a {who.ToString().ToUpper()} játékos");
                }
                who = 'o';
            }
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Új játék indul!");
        }
    }
}