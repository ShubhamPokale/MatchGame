using System;
using System.Collections.Generic;
using System.Linq;
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

namespace MatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SetUpGame();
        }



        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>()
            {
                "🐙", "🐙",
                "🐡", "🐡",
                "🐘", "🐘",
                "🐳", "🐳",
                "🐪", "🐪",
                "🦕", "🦕",
                "🦘", "🦘",
                "🦔", "🦔",
            };

            Random random = new Random();

            foreach (TextBlock textBlock in mainGird.Children.OfType<TextBlock>())
            {
                if (textBlock.Name != "timeTextBlock")
                {
                    textBlock.Visibility = Visibility.Visible;
                    int index = random.Next(animalEmoji.Count);
                    string nextEmoji = animalEmoji[index];
                    textBlock.Text = nextEmoji;
                    animalEmoji.RemoveAt(index);
                }
            }


        }


        /*
        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>()
    {
        "🐙", "🐙",
        "🐡", "🐡",
        "🐘", "🐘",
        "🐳", "🐳",
        "🐪", "🐪",
        "🦕", "🦕",
        "🦘", "🦘",
        "🦔", "🦔",
    };

            Random random = new Random();

            // Check if there are enough text blocks for the emojis
            if (mainGird.Children.OfType<TextBlock>().Count() < animalEmoji.Count)
            {
                MessageBox.Show("Not enough text blocks for the emojis.");
                return;
            }

            foreach (TextBlock textBlock in mainGird.Children.OfType<TextBlock>())
            {
                if (textBlock.Name != "timeTextBlock")
                {
                    textBlock.Visibility = Visibility.Visible;

                    // Check if there are still emojis in the list
                    if (animalEmoji.Count > 0)
                    {
                        int index = random.Next(animalEmoji.Count);
                        string nextEmoji = animalEmoji[index];
                        textBlock.Text = nextEmoji;
                        animalEmoji.RemoveAt(index);
                    }
                    else
                    {
                        // Handle the case where there are not enough emojis
                        textBlock.Visibility = Visibility.Collapsed;
                    }
                }
            }
        }



        */




    }
}
