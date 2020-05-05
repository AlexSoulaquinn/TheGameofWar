using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TheGameofWar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// author: @Alex Quinn
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }

        private void BtnNewGame_Click(object sender, RoutedEventArgs e)
        {
            int turnCount = 0;


            for(int i = 0; i < 500; i++)
            {
                Game newGame = new Game(txtPlayer1.Text, txtPlayer2.Text);

                while (!newGame.gameOver())
                {
                    newGame.playTurn();
                }

                if (newGame.turnCount < 500)
                {
                    turnCount += newGame.turnCount;
                }
            }
        }
    }
}
