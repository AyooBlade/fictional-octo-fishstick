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
           Button bt = sender as Button;
           bt.Enabled = false; 
           bt.BackColor= Color.Red;
           if (who== 'o')
            {
                bt.Text = "o";
            } 
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}