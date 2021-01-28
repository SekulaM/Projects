using ChampionsLeagueKnockout;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace ChampionsLeagueGroupStage
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Groups : Window
    {
        public Groups()
        {
            InitializeComponent();
            DrawTheGroups();
            btnGenerateResults.IsEnabled = false;
        }

        //Pot lists
        List<Team> groupPot1Teams = new List<Team>();
        List<Team> groupPot2Teams = new List<Team>();
        List<Team> groupPot3Teams = new List<Team>();
        List<Team> groupPot4Teams = new List<Team>();
        List<Team> AllTeams = new List<Team>();

        //Groups lists
        List<Team> groupA = new List<Team>();
        List<Team> groupB = new List<Team>();
        List<Team> groupC = new List<Team>();
        List<Team> groupD = new List<Team>();
        List<Team> groupE = new List<Team>();
        List<Team> groupF = new List<Team>();
        List<Team> groupG = new List<Team>();
        List<Team> groupH = new List<Team>();

        //groupRoundsMatches
        List<List<Team>> groupARoundsMatches = new List<List<Team>>();
        List<List<Team>> groupBRoundsMatches = new List<List<Team>>();
        List<List<Team>> groupCRoundsMatches = new List<List<Team>>();
        List<List<Team>> groupDRoundsMatches = new List<List<Team>>();
        List<List<Team>> groupERoundsMatches = new List<List<Team>>();
        List<List<Team>> groupFRoundsMatches = new List<List<Team>>();
        List<List<Team>> groupGRoundsMatches = new List<List<Team>>();
        List<List<Team>> groupHRoundsMatches = new List<List<Team>>();

        //Group fixtures lists
        List<List<Team>> groupAfixtures = new List<List<Team>>();

        //teams which go further
        public static List<Team> pot1FromGroups = new List<Team>();
        public static List<Team> pot2FromGroups = new List<Team>();

        //lists to show score
        List<string> scoreAD = new List<string>();
        List<string> scoreEH = new List<string>();

        //counters
        int roundCounter = 0;
        int currentRound = 0;
        int counter = 0;
        int infiniteDrawingCount = 0;
        public bool restartDrawShown = false;
        
        //random
        Random random = new Random();
        int rndDraw1;
        int rndDraw2;
        int rndDraw3;
        int rndDraw4;

        List<List<Team>> roundMatchesToCopy = new List<List<Team>>();

        private void DrawTheGroups()
        {
            btnCheckthePoints.IsEnabled = false;
            //Populate the lists
            //pot1, the strongest teams
            groupPot1Teams.Add(new Team { Name = "BARCELONA", Country = "Spain", Strength = 8, Points = 0 });
            groupPot1Teams.Add(new Team { Name = "BAYERN", Country = "Germany", Strength = 10, Points = 0 });
            groupPot1Teams.Add(new Team { Name = "REAL", Country = "Spain", Strength = 8, Points = 0 });
            groupPot1Teams.Add(new Team { Name = "LIVERPOOL", Country = "England", Strength = 9, Points = 0 });
            groupPot1Teams.Add(new Team { Name = "CITY", Country = "England", Strength = 9, Points = 0 });
            groupPot1Teams.Add(new Team { Name = "PSG", Country = "France", Strength = 9, Points = 0 });
            groupPot1Teams.Add(new Team { Name = "JUVENTUS", Country = "Italy", Strength = 8, Points = 0 });
            groupPot1Teams.Add(new Team { Name = "ATLETICO", Country = "Spain", Strength = 8, Points = 0 });

            //pot2
            groupPot2Teams.Add(new Team { Name = "CHELSEA", Country = "England", Strength = 8, Points = 0 });
            groupPot2Teams.Add(new Team { Name = "NAPELS", Country = "Italy", Strength = 7, Points = 0 });
            groupPot2Teams.Add(new Team { Name = "DORTMUND", Country = "Germany", Strength = 8, Points = 0 });
            groupPot2Teams.Add(new Team { Name = "MAN UTD", Country = "England", Strength = 8, Points = 0 });
            groupPot2Teams.Add(new Team { Name = "INTER", Country = "Italy", Strength = 7, Points = 0 });
            groupPot2Teams.Add(new Team { Name = "BENFICA", Country = "Portugal", Strength = 7, Points = 0 });
            groupPot2Teams.Add(new Team { Name = "SEVILLA", Country = "Spain", Strength = 7, Points = 0 });
            groupPot2Teams.Add(new Team { Name = "PORTO", Country = "Portugal", Strength = 7, Points = 0 });

            //pot3
            groupPot3Teams.Add(new Team { Name = "LYON", Country = "France", Strength = 6, Points = 0 });
            groupPot3Teams.Add(new Team { Name = "AJAX", Country = "Netherlands", Strength = 6, Points = 0 });
            groupPot3Teams.Add(new Team { Name = "SHAHKTAR", Country = "Ukraine", Strength = 6, Points = 0 });
            groupPot3Teams.Add(new Team { Name = "SALZBURG", Country = "Austria", Strength = 6, Points = 0 });
            groupPot3Teams.Add(new Team { Name = "BAYER", Country = "Germany", Strength = 6, Points = 0 });
            groupPot3Teams.Add(new Team { Name = "GALA", Country = "Turkey", Strength = 6, Points = 0 });
            groupPot3Teams.Add(new Team { Name = "AS ROMA", Country = "Italy", Strength = 7, Points = 0 });
            groupPot3Teams.Add(new Team { Name = "LEIPZIG", Country = "Germany", Strength = 7, Points = 0 });

            //pot4, the weakest teams
            groupPot4Teams.Add(new Team { Name = "SLAVIA", Country = "Czechia", Strength = 5, Points = 0 });
            groupPot4Teams.Add(new Team { Name = "KRASNODAR", Country = "Russia", Strength = 5, Points = 0 });
            groupPot4Teams.Add(new Team { Name = "BRUGGY", Country = "Belgium", Strength = 5, Points = 0 });
            groupPot4Teams.Add(new Team { Name = "MONACO", Country = "France", Strength = 5, Points = 0 });
            groupPot4Teams.Add(new Team { Name = "CSKA", Country = "Russia", Strength = 5, Points = 0 });
            groupPot4Teams.Add(new Team { Name = "PAOK", Country = "Greece", Strength = 5, Points = 0 });
            groupPot4Teams.Add(new Team { Name = "ZAGREB", Country = "Croatia", Strength = 4, Points = 0 });
            groupPot4Teams.Add(new Team { Name = "MALMO", Country = "Sweden", Strength = 4, Points = 0 });

            AllTeams.AddRange(groupPot1Teams);
            AllTeams.AddRange(groupPot2Teams);
            AllTeams.AddRange(groupPot3Teams);
            AllTeams.AddRange(groupPot4Teams);

            infiniteDrawingCount = 0;

            //drawing of the groups, each groups has four teams (one from each pot), there cannot be teams from the same country in one group
            //group A
            while (!DrawGroupStage(groupA))
            {
                lbGroupA.ItemsSource = groupA;
                lbGroupA.DisplayMemberPath = "Country";

            }

            infiniteDrawingCount = 0;
            //group B
            while (!DrawGroupStage(groupB))
            {
                lbGroupB.ItemsSource = groupB;
                lbGroupB.DisplayMemberPath = "Name";

            }

            infiniteDrawingCount = 0;
            //group C
            while (!DrawGroupStage(groupC))
            {
                lbGroupC.ItemsSource = groupC;
                lbGroupC.DisplayMemberPath = "Name";

            }

            infiniteDrawingCount = 0;
            //group D
            while (!DrawGroupStage(groupD))
            {
                lbGroupD.ItemsSource = groupD;
                lbGroupD.DisplayMemberPath = "Name";
            }

            infiniteDrawingCount = 0;
            //group E
            while (!DrawGroupStage(groupE))
            {
                lbGroupE.ItemsSource = groupE;
                lbGroupE.DisplayMemberPath = "Name";
                CheckInfiniteDrawing(infiniteDrawingCount);
                infiniteDrawingCount++;
            }

            infiniteDrawingCount = 0;
            //group F
            while (!DrawGroupStage(groupF))
            {
                lbGroupF.ItemsSource = groupF;
                lbGroupF.DisplayMemberPath = "Name";
                CheckInfiniteDrawing(infiniteDrawingCount);
                infiniteDrawingCount++;
            }

            infiniteDrawingCount = 0;
            //group G
            while (!DrawGroupStage(groupG))
            {
                lbGroupG.ItemsSource = groupG;
                lbGroupG.DisplayMemberPath = "Name";
                CheckInfiniteDrawing(infiniteDrawingCount);
                infiniteDrawingCount++;
            }

            infiniteDrawingCount = 0;
            //group H
            while (!DrawGroupStage(groupH))
            {
                lbGroupH.ItemsSource = groupH;
                lbGroupH.DisplayMemberPath = "Name";
                CheckInfiniteDrawing(infiniteDrawingCount);
                infiniteDrawingCount++;
            }
            UpdateDataBinding();
        }

        private void UpdateDataBinding()
        {
            lbGroupA.ItemsSource = groupA;
            lbGroupA.DisplayMemberPath = "NamePoints";
            lbGroupA.Items.Refresh();
            
            lbGroupB.ItemsSource = groupB;
            lbGroupB.DisplayMemberPath = "NamePoints";
            lbGroupB.Items.Refresh();

            lbGroupC.ItemsSource = groupC;
            lbGroupC.DisplayMemberPath = "NamePoints";
            lbGroupC.Items.Refresh();

            lbGroupD.ItemsSource = groupD;
            lbGroupD.DisplayMemberPath = "NamePoints";
            lbGroupD.Items.Refresh();

            lbGroupE.ItemsSource = groupE;
            lbGroupE.DisplayMemberPath = "NamePoints";
            lbGroupE.Items.Refresh();

            lbGroupF.ItemsSource = groupF;
            lbGroupF.DisplayMemberPath = "NamePoints";
            lbGroupF.Items.Refresh();

            lbGroupG.ItemsSource = groupG;
            lbGroupG.DisplayMemberPath = "NamePoints";
            lbGroupG.Items.Refresh();

            lbGroupH.ItemsSource = groupH;
            lbGroupH.DisplayMemberPath = "NamePoints";
            lbGroupH.Items.Refresh();

        }

        //if there is still a lot of teams from one country (which cannot be in the same group), infinite draw can occur
        private void CheckInfiniteDrawing(int infiniteDrawing)
        {
            if (infiniteDrawing > 5)
            {
                
                if (!restartDrawShown)
                {
                    restartDrawShown = true;

                    //restart the app if infinite drawing
                    Process.Start(Application.ResourceAssembly.Location);
                    Application.Current.Shutdown();

                }
            }
        }

        //rnd numbers used for draw
        private int[] GenerateDrawNumsForGroupStage(int listCount)
        {
            rndDraw1 = random.Next(0, listCount);
            rndDraw2 = random.Next(0, listCount);
            rndDraw3 = random.Next(0, listCount);
            rndDraw4 = random.Next(0, listCount);

            return new int[] { rndDraw1, rndDraw2, rndDraw3, rndDraw4 };
        }

        private bool DrawGroupStage(List<Team> groupTeams)
        {
            List<Team> temporaryList = groupTeams;

            GenerateDrawNumsForGroupStage(groupPot1Teams.Count);
            groupTeams.Add(groupPot1Teams[rndDraw1]);
            groupTeams.Add(groupPot2Teams[rndDraw2]);
            groupTeams.Add(groupPot3Teams[rndDraw3]);
            groupTeams.Add(groupPot4Teams[rndDraw4]);

            //check if there are teams from the same country in the same group
            string[] countriesOfTheTeams = new string[4];
            counter = 0;
            foreach (var item in groupTeams)
            {
                string country = "";
                country = item.Country;
                countriesOfTheTeams[counter] = country;
                counter++;
            }
            counter = 0;

            var countriesGrouped = countriesOfTheTeams.GroupBy(c=> c);
            foreach (var item in countriesGrouped)
            {
                if (item.Count()>1)
                {
                    counter = 0;
                    groupTeams.Clear();
                    return false;
                }
            }

            groupPot1Teams.RemoveAt(rndDraw1);
            groupPot2Teams.RemoveAt(rndDraw2);
            groupPot3Teams.RemoveAt(rndDraw3);
            groupPot4Teams.RemoveAt(rndDraw4);

            return true;
        }

        public void btnDrawFixtures_Click(object sender, RoutedEventArgs e)
        {
            btnGenerateResults.IsEnabled = true;
            btnDrawFixtures.IsEnabled = false;
            ShowRoundFixtures(roundCounter);
            roundCounter++;
            lblRound.Content = roundCounter;
            lbMatchesScoreAD.ItemsSource = null;
            lbMatchesScoreEH.ItemsSource = null;

            scoreAD.Clear();
            scoreEH.Clear();
        }

        public void ShowRoundFixtures(int round)
        {
            //lists for displaying the fixtures
            List<List<Team>> groupARoundsMatches = GroupsFixtures(groupA); //group A matches
            List<List<Team>> groupBRoundsMatches = GroupsFixtures(groupB); //group B matches
            List<List<Team>> groupCRoundsMatches = GroupsFixtures(groupC); //group C matches
            List<List<Team>> groupDRoundsMatches = GroupsFixtures(groupD); //group D matches
            List<List<Team>> groupERoundsMatches = GroupsFixtures(groupE); //group E matches
            List<List<Team>> groupFRoundsMatches = GroupsFixtures(groupF); //group F matches
            List<List<Team>> groupGRoundsMatches = GroupsFixtures(groupG); //group G matches
            List<List<Team>> groupHRoundsMatches = GroupsFixtures(groupH); //group H matches

            switch (round)
            {
                case 1:
                    currentRound = 0;
                    break;
                case 2:
                    currentRound = 2;
                    break;
                case 3:
                    currentRound = 4;
                    break;
                case 4:
                    currentRound = 6;
                    break;
                case 5:
                    currentRound = 8;
                    break;
                case 6:
                    currentRound = 10;
                    break;
                default: 
                    break;
            }
            List<List<Team>> roundMatches = new List<List<Team>>()
            { groupARoundsMatches[currentRound], groupARoundsMatches[currentRound+1], groupBRoundsMatches[currentRound], groupBRoundsMatches[currentRound+1],
              groupCRoundsMatches[currentRound], groupCRoundsMatches[currentRound+1], groupDRoundsMatches[currentRound], groupDRoundsMatches[currentRound+1],
              groupERoundsMatches[currentRound], groupERoundsMatches[currentRound+1], groupFRoundsMatches[currentRound], groupFRoundsMatches[currentRound+1],
              groupGRoundsMatches[currentRound], groupGRoundsMatches[currentRound+1], groupHRoundsMatches[currentRound], groupHRoundsMatches[currentRound+1]
            };

            //display the fixtures
            List<string> roundDisplayAD = new List<string>();
            for (int i = 0; i < 8; i++)
            {
                roundDisplayAD.Add(roundMatches[i][0].Name + " - " + roundMatches[i][1].Name);
            }
            lbRoundsAD.ItemsSource = roundDisplayAD;

            List<string> roundDisplayEH = new List<string>();
            for (int i = 8; i < 16; i++)
            {
                roundDisplayEH.Add(roundMatches[i][0].Name + " - " + roundMatches[i][1].Name);
            }
            lbRoundsEH.ItemsSource = roundDisplayEH;

            currentRound++;
            roundMatchesToCopy = roundMatches;
            
        }

        private List<List<Team>> GroupsFixtures(List<Team> group)
        {
            //lists for Group rounds
            List <Team> round1Match1 = new List<Team> { group[0], group[2] }; //0
            List <Team> round1Match2 = new List<Team> { group[1], group[3] }; //1
            List <Team> round2Match1 = new List<Team> { group[2], group[1] }; //2
            List <Team> round2Match2 = new List<Team> { group[3], group[0] }; //3
            List <Team> round3Match1 = new List<Team> { group[0], group[1] }; //4
            List <Team> round3Match2 = new List<Team> { group[2], group[3] }; //5
            List <Team> round4Match1 = new List<Team> { group[1], group[0] }; //6
            List <Team> round4Match2 = new List<Team> { group[3], group[2] }; //7
            List <Team> round5Match1 = new List<Team> { group[0], group[3] }; //8
            List <Team> round5Match2 = new List<Team> { group[1], group[2] }; //9
            List <Team> round6Match1 = new List<Team> { group[2], group[0] }; //10
            List <Team> round6Match2 = new List<Team> { group[3], group[1] }; //11

            List<List<Team>> groupRoundsMatches = new List<List<Team>>() { 
                round1Match1, round1Match2, round2Match1, round2Match2, round3Match1, round3Match2, 
                round4Match1, round4Match2, round5Match1, round5Match2, round6Match1, round6Match2
            };

            List<string> groupFixturesDisplay = new List<string>();
            for (int i = 0; i < 12; i++)
            {
                    groupFixturesDisplay.Add(groupRoundsMatches[i][0].Name + " - " + groupRoundsMatches[i][1].Name);
            }

            //lbTest.ItemsSource = groupFixturesDisplay;
            return groupRoundsMatches;
        }

        private void btnGenerateResults_Click(object sender, RoutedEventArgs e)
        {
            btnGenerateResults.IsEnabled = false;
            btnDrawFixtures.IsEnabled = true;
            MainWindow mainWindow = new MainWindow();
            string score = "";

            for (int i = 0; i < 16; i++)
            {
                score = mainWindow.DecideTheWinnerAndScore(roundMatchesToCopy[i][0], roundMatchesToCopy[i][1])[1];
                UpdateDataBinding();

                if (i<8)
                {
                    scoreAD.Add(score);
                }
                else if (i<16)
                {
                    scoreEH.Add(score);
                }
            }

            lbMatchesScoreAD.ItemsSource = scoreAD;
            lbMatchesScoreEH.ItemsSource = scoreEH;
            if (roundCounter >=6)
            {
                btnCheckthePoints.IsEnabled = true;
                btnDrawFixtures.IsEnabled = false;
                btnGenerateResults.IsEnabled = false;
            }
        }



        private void btnCheckthePoints_Click(object sender, RoutedEventArgs e)
        {
            GetTheTwoBestTeams(groupA);
            GetTheTwoBestTeams(groupB);
            GetTheTwoBestTeams(groupC);
            GetTheTwoBestTeams(groupD);
            GetTheTwoBestTeams(groupE);
            GetTheTwoBestTeams(groupF);
            GetTheTwoBestTeams(groupG);
            GetTheTwoBestTeams(groupH);


            MainWindow mainWindow = new MainWindow();
            mainWindow.groupStage = false;
            mainWindow.Show();
            mainWindow.InitializeTeams();
        }

        //the two best teams will advance to the knockout stage
        public void GetTheTwoBestTeams(List<Team> group)
        {
            var team1 = (group.OrderByDescending(p => p.Points).FirstOrDefault());
            var team2 = (group.OrderByDescending(p => p.Points).ElementAt(1));

            pot1FromGroups.Add(team1);

            pot2FromGroups.Add(team2);
          
        }

    }
}
