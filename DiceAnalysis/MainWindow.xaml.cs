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

namespace DiceAnalysis
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        Dictionary<int, string> RollOptions = new Dictionary<int, string>()
        {
            {0,"one 15, 4d6 drop lowest" },
            {1,"One 16, roll 5d6 - drop highest & lowest" },
            {2,"One 17, roll 3d6" },
            {3,"One 18, roll 4d6 drop highest" }
        };
        int[] DiceRollSet = new int[6];
        List<int[]> DiceSetList = new List<int[]>();

        public MainWindow()
        {
            InitializeComponent();
            DiceConfigComboBox.ItemsSource = RollOptions;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GenerateDiceRolls(DiceRollCountTextBox.Text, DiceConfigComboBox.SelectedIndex);
        }

        private List<AbilityRolls> GenerateDiceRolls(string text, int selectedIndex)
        {
            List<AbilityRolls> CurrentDiceSetList = new List<AbilityRolls>();

            CurrentDiceSetList = RollAbilityScores(text, selectedIndex);
            return CurrentDiceSetList;
        }

        private List<AbilityRolls> RollAbilityScores(string numberOfRolls, int typeOfRoll)
        {
            
            List<AbilityRolls> CurrentDiceSetList = new List<AbilityRolls>();
            int numOfRolls = 0;

            int.TryParse(numberOfRolls, out numOfRolls);
            numOfRolls = numOfRolls * 1000;
            for (int j = 0; j < numOfRolls; j++)
            {
                AbilityRolls currentAbilityRolls = new AbilityRolls();
                currentAbilityRolls = RollAbilitySet(typeOfRoll);
                CurrentDiceSetList.Add(currentAbilityRolls);
            }
            return CurrentDiceSetList;
        }

        private AbilityRolls RollAbilitySet(int typeOfRoll)
        {
            AbilityRolls currentAbilityRoll = new AbilityRolls();
            //if (typeOfRoll == 0)
            //{
            //    currentAbilityRoll = RollTypeZero();
            //}
            if (typeOfRoll == 1)
            {
                currentAbilityRoll = RollTypeOne();
            }
            if (typeOfRoll == 2)
            {
                currentAbilityRoll = RollTypeTwo();
            }
            if (typeOfRoll == 3)
            {
                currentAbilityRoll = RollTypeThree();
            }

            currentAbilityRoll = RollTypeZero();
            return currentAbilityRoll;
        }

        private AbilityRolls RollTypeThree()
        {



            return null;
        }

        private static List<int> FillSet(DSix d6rollStuff, List<int> rollSet)
        {
            rollSet.Add(d6rollStuff.RollDSix());
            rollSet.Add(d6rollStuff.RollDSix());
            rollSet.Add(d6rollStuff.RollDSix());
            rollSet.Add(d6rollStuff.RollDSix());

            rollSet.Sort();

            return null;
        }

        private AbilityRolls RollTypeTwo()
        {

            return null;
        }

        private AbilityRolls RollTypeOne()
        {

            return null;
        }

        private AbilityRolls RollTypeZero()
        {
            AbilityRolls currentRolls = new AbilityRolls();

            DSix d6rollStuff = new DSix();
            List<int> rollSet = new List<int>();
            currentRolls.AbilityOne = 15;
            for (int i = 0; i < 5; i++)
            {
                FillSet(d6rollStuff, rollSet);

            }
            return null;
        }
    }
}
