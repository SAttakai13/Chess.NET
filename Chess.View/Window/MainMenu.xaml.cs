using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;


namespace Chess.View.Window
{
    using Chess.Model.Game;
    using Chess.View.Selector;
    using Chess.ViewModel.Game;
    using System;
    using System.Collections.Generic;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
            
        }

        private void NineSixty_Click(object sender, RoutedEventArgs e)
        {
            var MainWin = new MainWindow();
            MainWin.RuleGame = "Chess960";
            MainWin.Show();
            this.Close();
        }

        private void Classic_Click(object sender, RoutedEventArgs e)
        {
            var MainWin = new MainWindow();
            MainWin.RuleGame = "Classic";
            MainWin.Show();
            this.Close();
        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
