using LedCSharp;
using LoginGame;

namespace WF_LogiGame
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LogitechGSDK.LogiLedInit();
            Animations.Start_Animation();
            TicTacToeManager ticTacToeManager = new TicTacToeManager();
            ticTacToeManager.Play();
        }
    }
}
