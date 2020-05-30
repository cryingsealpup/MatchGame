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
using System.Windows.Threading;

namespace MatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer Timer = new DispatcherTimer();
        int tenthsOfSecondsElapsed;
        int matchesFound;
        public MainWindow()
        {
            Timer.Interval = TimeSpan.FromSeconds(.1);
            Timer.Tick += Timer_Tick;
            
            InitializeComponent();
            SetUpGame();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tenthsOfSecondsElapsed++;
            timeTextBox.Text = (tenthsOfSecondsElapsed / 10F).ToString("0.0s");
            if (matchesFound == 8)
            {
                Timer.Stop();
                timeTextBox.Text = timeTextBox.Text + " - Play again?";
            }
        }

        private void TimeTextBox_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (matchesFound == 8)
            {
                SetUpGame();
            }
        }

        private void SetUpGame()
        {
            List<string> animals = new List<string>()
            {
                "🐛", "🐛",
                "🕷️", "🕷️",
                "🐜", "🐜",
                "🐝", "🐝",
                "🐞", "🐞",
                "🦟", "🦟",
                "🦗", "🦗",
                "🦋", "🦋",
            };

            Random Random = new Random();
            foreach (TextBlock textBlock in MainGrid.Children.OfType<TextBlock>())
            {
                if (textBlock.Name != "timeTextBox") { 
                 int index = Random.Next(animals.Count);
                string nextAnimal = animals[index];
                textBlock.Text = nextAnimal;
                animals.RemoveAt(index);
            }
            }
            Timer.Start();
            tenthsOfSecondsElapsed = 0;
            matchesFound = 0;
        }

        TextBlock LastTextBlockClicked;
        bool FindingMatch = false; 

        private void textBlock0_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock; 
            if (FindingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                LastTextBlockClicked = textBlock;
                FindingMatch = true;
            }
            else if (textBlock.Text == LastTextBlockClicked.Text)
            {
                textBlock.Visibility = Visibility.Hidden;
                FindingMatch = false; matchesFound++;
            }
            else
            {
                LastTextBlockClicked.Visibility = Visibility.Visible;
                FindingMatch = false;
            }
        }

        private void textBlock01_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            if (FindingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                LastTextBlockClicked = textBlock;
                FindingMatch = true;
            }
            else if (textBlock.Text == LastTextBlockClicked.Text)
            {
                textBlock.Visibility = Visibility.Hidden;
                FindingMatch = false; matchesFound++;
            }
            else
            {
                LastTextBlockClicked.Visibility = Visibility.Visible;
                FindingMatch = false;
            }
        }

        private void textBlock02_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            if (FindingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                LastTextBlockClicked = textBlock;
                FindingMatch = true;
            }
            else if (textBlock.Text == LastTextBlockClicked.Text)
            {
                textBlock.Visibility = Visibility.Hidden;
                FindingMatch = false; matchesFound++;
            }
            else
            {
                LastTextBlockClicked.Visibility = Visibility.Visible;
                FindingMatch = false;
            }
        }

        private void textBlock03_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            if (FindingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                LastTextBlockClicked = textBlock;
                FindingMatch = true;
            }
            else if (textBlock.Text == LastTextBlockClicked.Text)
            {
                textBlock.Visibility = Visibility.Hidden;
                FindingMatch = false; matchesFound++;
            }
            else
            {
                LastTextBlockClicked.Visibility = Visibility.Visible;
                FindingMatch = false; 
            }
        }

        private void textBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            if (FindingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                LastTextBlockClicked = textBlock;
                FindingMatch = true;
            }
            else if (textBlock.Text == LastTextBlockClicked.Text)
            {
                textBlock.Visibility = Visibility.Hidden;
                FindingMatch = false; matchesFound++;
            }
            else
            {
                LastTextBlockClicked.Visibility = Visibility.Visible;
                FindingMatch = false; 
            }
        }

        private void textBlock5_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            if (FindingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                LastTextBlockClicked = textBlock;
                FindingMatch = true;
            }
            else if (textBlock.Text == LastTextBlockClicked.Text)
            {
                textBlock.Visibility = Visibility.Hidden;
                FindingMatch = false; matchesFound++;
            }
            else
            {
                LastTextBlockClicked.Visibility = Visibility.Visible;
                FindingMatch = false; 
            }
        }

        private void textBlock_Copy1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            if (FindingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                LastTextBlockClicked = textBlock;
                FindingMatch = true;
            }
            else if (textBlock.Text == LastTextBlockClicked.Text)
            {
                textBlock.Visibility = Visibility.Hidden;
                FindingMatch = false; matchesFound++;
            }
            else
            {
                LastTextBlockClicked.Visibility = Visibility.Visible;
                FindingMatch = false; 
            }
        }

        private void textBlock2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            if (FindingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                LastTextBlockClicked = textBlock;
                FindingMatch = true;
            }
            else if (textBlock.Text == LastTextBlockClicked.Text)
            {
                textBlock.Visibility = Visibility.Hidden;
                FindingMatch = false; matchesFound++;
            }
            else
            {
                LastTextBlockClicked.Visibility = Visibility.Visible;
                FindingMatch = false;
            }
        }

        private void textBlock2222_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            if (FindingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                LastTextBlockClicked = textBlock;
                FindingMatch = true;
            }
            else if (textBlock.Text == LastTextBlockClicked.Text)
            {
                textBlock.Visibility = Visibility.Hidden;
                FindingMatch = false; matchesFound++;
            }
            else
            {
                LastTextBlockClicked.Visibility = Visibility.Visible;
                FindingMatch = false;
            }
        }

        private void textBlock33_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            if (FindingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                LastTextBlockClicked = textBlock;
                FindingMatch = true;
            }
            else if (textBlock.Text == LastTextBlockClicked.Text)
            {
                textBlock.Visibility = Visibility.Hidden;
                FindingMatch = false; matchesFound++;
            }
            else
            {
                LastTextBlockClicked.Visibility = Visibility.Visible;
                FindingMatch = false;
            }
        }

        private void textBlock_Copy12_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            if (FindingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                LastTextBlockClicked = textBlock;
                FindingMatch = true;
            }
            else if (textBlock.Text == LastTextBlockClicked.Text)
            {
                textBlock.Visibility = Visibility.Hidden;
                FindingMatch = false; matchesFound++;
            }
            else
            {
                LastTextBlockClicked.Visibility = Visibility.Visible;
                FindingMatch = false;
            }
        }

        private void textBlock_Copy111_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            if (FindingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                LastTextBlockClicked = textBlock;
                FindingMatch = true;
            }
            else if (textBlock.Text == LastTextBlockClicked.Text)
            {
                textBlock.Visibility = Visibility.Hidden;
                FindingMatch = false; matchesFound++;
            }
            else
            {
                LastTextBlockClicked.Visibility = Visibility.Visible;
                FindingMatch = false;
            }
        }

        private void textBlock222_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            if (FindingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                LastTextBlockClicked = textBlock;
                FindingMatch = true;
            }
            else if (textBlock.Text == LastTextBlockClicked.Text)
            {
                textBlock.Visibility = Visibility.Hidden;
                FindingMatch = false; matchesFound++;
            }
            else
            {
                LastTextBlockClicked.Visibility = Visibility.Visible;
                FindingMatch = false;
            }
        }

        private void textBlock24_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            if (FindingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                LastTextBlockClicked = textBlock;
                FindingMatch = true;
            }
            else if (textBlock.Text == LastTextBlockClicked.Text)
            {
                textBlock.Visibility = Visibility.Hidden;
                FindingMatch = false; matchesFound++;
            }
            else
            {
                LastTextBlockClicked.Visibility = Visibility.Visible;
                FindingMatch = false;
            }
        }

        private void textBlock52_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            if (FindingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                LastTextBlockClicked = textBlock;
                FindingMatch = true;
            }
            else if (textBlock.Text == LastTextBlockClicked.Text)
            {
                textBlock.Visibility = Visibility.Hidden;
                FindingMatch = false; matchesFound++;
            }
            else
            {
                LastTextBlockClicked.Visibility = Visibility.Visible;
                FindingMatch = false;
            }
        }

        private void textBlock53_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            if (FindingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                LastTextBlockClicked = textBlock;
                FindingMatch = true;
            }
            else if (textBlock.Text == LastTextBlockClicked.Text)
            {
                textBlock.Visibility = Visibility.Hidden;
                FindingMatch = false; matchesFound++;
            }
            else
            {
                LastTextBlockClicked.Visibility = Visibility.Visible;
                FindingMatch = false;
            }
        }
    }


}
