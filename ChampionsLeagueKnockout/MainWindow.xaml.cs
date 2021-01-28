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
using System.IO;
using ChampionsLeagueGroupStage;


namespace ChampionsLeagueKnockout
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");
            btnDecideMatches.IsEnabled = false;
        }
        
        static Random random = new Random();
        int rnd1;
        int rnd2;
        int rndDraw1;
        int rndDraw2;
        string[] pot1Teams = new string[8];
        string[] pot2Teams = new string[8];
        string[] pot1Country = new string[8];
        string[] pot2Country = new string[8];
        int[] pot1Strength = new int[8];
        int[] pot2Strength = new int[8];
        public string finalScore;
        public string finalWinner;

        //Booleans to determine the stage of the competition
        public bool groupStage = true;
        bool quarterfinal = false;
        bool semifinal = false;
        bool final = false;
        /// <summary>
        /// Lists for listing the teams
        /// </summary>
        List<Team> pot1List = new List<Team>();
        List<Team> pot2List = new List<Team>();
        List<Team> allTeams = new List<Team>();
        //temporary lists
        List<Team> pot1ListTemp = new List<Team>();
        List<Team> pot2ListTemp = new List<Team>();
        //8finale matches
        string[] fin8scores = new string[8];
        List<Team> fin8match1 = new List<Team>();
        List<Team> fin8match2 = new List<Team>();
        List<Team> fin8match3 = new List<Team>();
        List<Team> fin8match4 = new List<Team>();
        List<Team> fin8match5 = new List<Team>();
        List<Team> fin8match6 = new List<Team>();
        List<Team> fin8match7 = new List<Team>();
        List<Team> fin8match8 = new List<Team>();
        //4finale matches
        string[] fin4TeamsStringArray = new string[8];
        List<Team> fin4teams = new List<Team>();
        List<Team> fin4teamsTemp = new List<Team>();
        List<Team> fin4match1 = new List<Team>();
        List<Team> fin4match2 = new List<Team>();
        List<Team> fin4match3 = new List<Team>();
        List<Team> fin4match4 = new List<Team>();
        //2final matches
        string[] fin2TeamsStringArray = new string[4];
        List<Team> fin2teams = new List<Team>();
        List<Team> fin2teamsTemp = new List<Team>();
        List<Team> fin2match1 = new List<Team>();
        List<Team> fin2match2 = new List<Team>();
        //final match
        string[] fin1TeamsStringArray = new string[2];
        //Lists to display results
        List<string> finmatchesString = new List<string>();
        List<string> fin8matchesStringScore = new List<string>();
        List<string> fin4matchesString = new List<string>();
        List<string> fin4matchesStringScore = new List<string>();
        List<string> fin2matchesString = new List<string>();
        List<string> fin2matchesStringScore = new List<string>();
        public void InitializeTeams()
        {
            //if (!groupStage)
            //{
            //    Groups groups = new Groups();
            //    pot1List.AddRange(groups.pot1FromGroups);
            //    pot2List.AddRange(groups.pot2FromGroups);

            //    lboxPot1.ItemsSource = pot1List;
            //    lboxPot1.DisplayMemberPath = "Name";
            //    lboxPot2.ItemsSource = pot2List;
            //    lboxPot2.DisplayMemberPath = "Name";
            //}
            //else
            //{
            //    //Read from the files
            //    // Pot1
            //    var streamReader = new StreamReader("pot1.txt");
            //    int counter = 0;
            //    bool finished = false;

            //    while (!finished)
            //    {
            //        string line = streamReader.ReadLine();
            //        if (line == null)
            //        {
            //            finished = true;
            //        }
            //        else
            //        {
            //            //add to the teams array
            //            pot1Teams[counter] = line;
            //            //add to the countries array
            //            line = streamReader.ReadLine();
            //            pot1Country[counter] = line;
            //            //add to the strength array
            //            line = streamReader.ReadLine();
            //            pot1Strength[counter] = int.Parse(line);
            //            counter++;
            //        }
            //    }

            //    // Pot2
            //    var streamReader2 = new StreamReader("pot2.txt");
            //    int counter2 = 0;
            //    bool finished2 = false;

            //    while (!finished2)
            //    {
            //        string line2 = streamReader2.ReadLine();
            //        if (line2 == null)
            //        {
            //            finished2 = true;
            //        }
            //        else
            //        {
            //            //add to the teams array
            //            pot2Teams[counter2] = line2;
            //            //add to the countries array
            //            line2 = streamReader2.ReadLine();
            //            pot2Country[counter2] = line2;
            //            //add to the strength array
            //            line2 = streamReader2.ReadLine();
            //            pot2Strength[counter2] = int.Parse(line2);
            //            counter2++;
            //        }
            //    }

            //    //Populate the lists
            //    for (int i = 0; i < pot1Teams.Length; i++)
            //    {
            //        pot1List.Add(new Team { Name = pot1Teams[i], Country = pot1Country[i], Strength = pot1Strength[i] });
            //        pot1ListTemp.Add(new Team { Name = pot1Teams[i], Country = pot1Country[i], Strength = pot1Strength[i] });
            //    }
            //    for (int i = 0; i < pot2Teams.Length; i++)
            //    {
            //        pot2List.Add(new Team { Name = pot2Teams[i], Country = pot2Country[i], Strength = pot2Strength[i] });
            //        pot2ListTemp.Add(new Team { Name = pot2Teams[i], Country = pot2Country[i], Strength = pot2Strength[i] });
            //    }
            //}


            //make the temp lists the same as the original ones, so they can be deleted later
            //pot1ListTemp = pot1List;
            //pot2ListTemp = pot2List;
            //Show the lists inside of the Listboxes
            


            
        }

        private void btnDrawEightFinal_Click(object sender, RoutedEventArgs e)
        {
            btnDrawEightFinal.IsEnabled = false;
            btnDecideMatches.IsEnabled = true;
            groupStage = false;
            //Groups groups = new Groups();
            pot1List.AddRange(Groups.pot1FromGroups);
            pot2List.AddRange(Groups.pot2FromGroups);

            //populate the all teams list for further use
            for (int i = 0; i < 8; i++)
                {
                    allTeams.Add(pot1List[i]);
                    allTeams.Add(pot2List[i]);

                }

            DrawForAll();
        }

        private void DrawForAll()
        {
            Draw(fin8match1);
            Draw(fin8match2);
            Draw(fin8match3);
            Draw(fin8match4);
            Draw(fin8match5);
            Draw(fin8match6);
            Draw(fin8match7);
            Draw(fin8match8);
            lboxMatches.ItemsSource = finmatchesString;
        }

        public void btnDecideMatches_Click(object sender, RoutedEventArgs e)
        {
            btnDecideMatches.IsEnabled = false;
            DecideTheWinerAndScoreForAll();
            btnGoToQuarterfinals.IsEnabled = true;
        }
        private void DecideTheWinerAndScoreForAll()
        {
            fin4TeamsStringArray[0] = DecideTheWinnerAndScore(fin8match1[0], fin8match1[1])[0];
            fin4TeamsStringArray[1] = DecideTheWinnerAndScore(fin8match2[0], fin8match2[1])[0];
            fin4TeamsStringArray[2] = DecideTheWinnerAndScore(fin8match3[0], fin8match3[1])[0];
            fin4TeamsStringArray[3] = DecideTheWinnerAndScore(fin8match4[0], fin8match4[1])[0];
            fin4TeamsStringArray[4] = DecideTheWinnerAndScore(fin8match5[0], fin8match5[1])[0];
            fin4TeamsStringArray[5] = DecideTheWinnerAndScore(fin8match6[0], fin8match6[1])[0];
            fin4TeamsStringArray[6] = DecideTheWinnerAndScore(fin8match7[0], fin8match7[1])[0];
            fin4TeamsStringArray[7] = DecideTheWinnerAndScore(fin8match8[0], fin8match8[1])[0];

            lboxwinners.ItemsSource = fin4TeamsStringArray;
            lboxMatchesScore.ItemsSource = fin8matchesStringScore;
            
        }
        private void Draw(List<Team> finXmatchX)
        {
            GenerateDrawNums(pot1List.Count);
            finXmatchX.Add(pot1List[rndDraw1]);
            finXmatchX.Add(pot2List[rndDraw2]);
            pot1List.RemoveAt(rndDraw1);
            pot2List.RemoveAt(rndDraw2);
            finmatchesString.Add(finXmatchX[0].Name + " - " + finXmatchX[1].Name);
            //lboxMatches.ItemsSource = finmatchesString;
        }

        public string [] DecideTheWinnerAndScore(Team team1, Team team2)
        {
            string winner = "";
            string score = "";
            GenerateTwoRandomNums();
            //prevent draw during knockout stages, generate rnd num again
            if (!groupStage)
            {
                while ((team1.Strength + rnd1) == (team2.Strength + rnd2))
                {
                    GenerateTwoRandomNums();
                }
            }
            
            //Decide the winner
            //first team wins
            if ((team1.Strength + rnd1) > (team2.Strength + rnd2))
            {
                //Decide the score
                if ((team1.Strength + rnd1) - (team2.Strength + rnd2) > 2)
                {
                    int rndScore = random.Next(1, 4);
                    switch (rndScore)
                    {
                        case 1:
                            score = " 3 : 0";
                            break;
                        case 2:
                            score = " 4 : 1";
                            break;
                        case 3:
                            score = " 5 : 2";
                            break;
                    }
                }
                else if ((team1.Strength + rnd1) - (team2.Strength + rnd2) <= 2 && (team1.Strength + rnd1) - (team2.Strength + rnd2) > 0)
                {
                    int rndScore = random.Next(1, 4);
                    switch (rndScore)
                    {
                        case 1:
                            score = " 3 : 2";
                            break;
                        case 2:
                            score = " 2 : 1";
                            break;
                        case 3:
                            score = " 1 : 0";
                            break;
                    }
                }
                
                winner = team1.Name;

                if (groupStage)
                {
                    team1.Points += 3;
                }
            }
            //second team wins
            else if ((team1.Strength + rnd1) < (team2.Strength + rnd2))
            {
                //score
                if ((team2.Strength + rnd2) - (team1.Strength + rnd1) > 2)
                {
                    int rndScore = random.Next(1, 4);
                    switch (rndScore)
                    {
                        case 1:
                            score = " 0 : 3";
                            break;
                        case 2:
                            score = " 2 : 5";
                            break;
                        case 3:
                            score = " 1 : 4";
                            break;
                    }
                }
                else if ((team2.Strength + rnd2) - (team1.Strength + rnd1) <= 2 && (team2.Strength + rnd2) - (team1.Strength + rnd1) > 0)
                {
                    int rndScore = random.Next(1, 4);
                    switch (rndScore)
                    {
                        case 1:
                            score = " 2 : 3";
                            break;
                        case 2:
                            score = " 1 : 2";
                            break;
                        case 3:
                            score = " 0 : 1";
                            break;
                    }
                }

                winner = team2.Name;

                if (groupStage)
                {
                    team2.Points += 3;
                }
            }
            //draw (only during group stage)
            else if ((team1.Strength + rnd1) == (team2.Strength + rnd2))
            {
                int rndScore = random.Next(1, 5);
                switch (rndScore)
                {
                    case 1:
                        score = " 0 : 0";
                        break;
                    case 2:
                        score = " 1 : 1";
                        break;
                    case 3:
                        score = " 2 : 2";
                        break;
                    case 4:
                        score = " 3 : 3";
                        break;
                }
                if (groupStage)
                {
                    team1.Points += 1;
                    team2.Points += 1;
                }
            }


                if (quarterfinal)
            {
                fin4matchesStringScore.Add(score);
            }
            else if (semifinal)
            {
                fin2matchesStringScore.Add(score);
            }
            else if (final)
            {
                finalScore = score;
                finalWinner = winner;
            }
            else //eightfinal
            {
                fin8matchesStringScore.Add(score);
            }

            

            return new string[] { winner, score };
        }

        private int[] GenerateTwoRandomNums()
        {
            rnd1 = random.Next(0, 6);
            rnd2 = random.Next(0, 6); 
            return new int[] { rnd1, rnd2 };
        }

        private int[] GenerateDrawNums(int potsCount) //count is length for lists
        {
            
            if (quarterfinal)
            {
                //quarterfinals have only one list to take from, numbers cannot be the same
                rndDraw1 = random.Next(0, potsCount);
                rndDraw2 = random.Next(0, potsCount);
                while (rndDraw1==rndDraw2)
                {
                    rndDraw2 = random.Next(0, potsCount);
                }
                
            }
            else if (semifinal)
            {
                //semifinals have only one list to take from, numbers cannot be the same
                rndDraw1 = random.Next(0, potsCount);
                rndDraw2 = random.Next(0, potsCount);
                while (rndDraw1 == rndDraw2)
                {
                    rndDraw2 = random.Next(0, potsCount);
                }

            }
            else
            {
                rndDraw1 = random.Next(0, potsCount);
                rndDraw2 = random.Next(0, potsCount);
            }

            return new int[] { rndDraw1, rndDraw2 };
        }

        private void btnGoToQuarterfinals_Click(object sender, RoutedEventArgs e)
        {
            btnGoToQuarterfinals.IsEnabled = false;
            quarterfinal = true;
            finmatchesString.Clear();
            lboxMatches.ItemsSource = null;
            lboxMatchesScore.ItemsSource = null;
            lboxwinners.ItemsSource = null;

            lboxMatches.ItemsSource = finmatchesString;
            lboxMatchesScore.ItemsSource = fin4matchesStringScore;
            //lboxwinners.ItemsSource = fin4TeamsStringArray;
            if (quarterfinal)
            {
                Quarterfinals();
            }
            btnGoToSemifinals.IsEnabled = true;
        }

        private void Quarterfinals()
        {
            for (int i = 0; i < 8; i++)
            {
                fin4teams.Add(allTeams.Find(t => t.Name.Equals(fin4TeamsStringArray[i])));
                fin4teamsTemp.Add(allTeams.Find(t => t.Name.Equals(fin4TeamsStringArray[i])));
            }

            DrawQuarterAndSemifinals(fin4match1);
            DrawQuarterAndSemifinals(fin4match2);
            DrawQuarterAndSemifinals(fin4match3);
            DrawQuarterAndSemifinals(fin4match4);

            lboxMatches.ItemsSource = finmatchesString;
            lboxMatchesScore.ItemsSource = fin4matchesStringScore;

            //winner and score
            fin2TeamsStringArray[0] = DecideTheWinnerAndScore(fin4match1[0], fin4match1[1])[0];
            fin2TeamsStringArray[1] = DecideTheWinnerAndScore(fin4match2[0], fin4match2[1])[0];
            fin2TeamsStringArray[2] = DecideTheWinnerAndScore(fin4match3[0], fin4match3[1])[0];
            fin2TeamsStringArray[3] = DecideTheWinnerAndScore(fin4match4[0], fin4match4[1])[0];
            lboxMatchesScore.ItemsSource = fin4matchesStringScore;
            lboxwinners.ItemsSource = fin2TeamsStringArray;
        }

        private void DrawQuarterAndSemifinals(List<Team> finXmatchX)
        {
            if (quarterfinal)
            {
                GenerateDrawNums(fin4teamsTemp.Count);
                finXmatchX.Add(fin4teamsTemp[rndDraw1]);
                finXmatchX.Add(fin4teamsTemp[rndDraw2]);
                fin4teamsTemp.RemoveAt(rndDraw1);
                if (rndDraw1 > rndDraw2)
                {
                    fin4teamsTemp.RemoveAt(rndDraw2);
                }
                else if (rndDraw1 < rndDraw2)
                {
                    fin4teamsTemp.RemoveAt(rndDraw2 - 1);
                }
                finmatchesString.Add(finXmatchX[0].Name + " - " + finXmatchX[1].Name);
                //lboxMatches.ItemsSource = finmatchesString;
            }
            else if (semifinal)
            {
                GenerateDrawNums(fin2teamsTemp.Count);
                finXmatchX.Add(fin2teamsTemp[rndDraw1]);
                finXmatchX.Add(fin2teamsTemp[rndDraw2]);
                fin2teamsTemp.RemoveAt(rndDraw1);
                if (rndDraw1 > rndDraw2)
                {
                    fin2teamsTemp.RemoveAt(rndDraw2);
                }
                else if (rndDraw1 < rndDraw2)
                {
                    fin2teamsTemp.RemoveAt(rndDraw2 - 1);
                }
                finmatchesString.Add(finXmatchX[0].Name + " - " + finXmatchX[1].Name);
                //lboxMatches.ItemsSource = finmatchesString;
            }
            
            
        }

        private void btnGoToSemifinals_Click(object sender, RoutedEventArgs e)
        {
            btnGoToSemifinals.IsEnabled = false;
            semifinal = true;
            quarterfinal = false;
            finmatchesString.Clear();
            lboxMatches.ItemsSource = null;
            lboxMatchesScore.ItemsSource = null;
            lboxwinners.ItemsSource = null;

            lboxMatches.ItemsSource = finmatchesString;
            lboxMatchesScore.ItemsSource = fin4matchesStringScore;
            
            if (semifinal)
            {
                Semifinals();
            }
        }

        private void Semifinals()
        {
            for (int i = 0; i < 4; i++)
            {
                fin2teams.Add(allTeams.Find(t => t.Name.Equals(fin2TeamsStringArray[i])));
                fin2teamsTemp.Add(allTeams.Find(t => t.Name.Equals(fin2TeamsStringArray[i])));
            }

            DrawQuarterAndSemifinals(fin2match1);
            DrawQuarterAndSemifinals(fin2match2);

            //winner and score
            fin1TeamsStringArray[0] = DecideTheWinnerAndScore(fin2match1[0], fin2match1[1])[0];
            fin1TeamsStringArray[1] = DecideTheWinnerAndScore(fin2match2[0], fin2match2[1])[0];
            List<string> testlist = new List<string>();
            testlist.Add(finmatchesString[0]);
            testlist.Add(finmatchesString[1]);
            lboxMatches.ItemsSource = testlist;
            lboxMatchesScore.ItemsSource = fin2matchesStringScore;
            lboxwinners.ItemsSource = fin1TeamsStringArray;
            btnGoToFinal.IsEnabled = true;
        }

        private void btnGoToFinal_Click(object sender, RoutedEventArgs e)
        {
            btnGoToFinal.IsEnabled = false;
            semifinal = false;
            quarterfinal = false;
            final = true;
            MessageBox.Show(fin1TeamsStringArray[0] + " - " + fin1TeamsStringArray[1]);
            List<Team> finalList = new List<Team>();
            for (int i = 0; i < 2; i++)
            {
                finalList.Add(allTeams.Find(t => t.Name.Equals(fin1TeamsStringArray[i])));
            }
            
            DecideTheWinnerAndScore(finalList[0], finalList[1]);
            MessageBox.Show(fin1TeamsStringArray[0] + " - " + fin1TeamsStringArray[1] + finalScore);

            MessageBox.Show("The winner is " + finalWinner);

            Application.Current.Shutdown();
            
        }

       
    }
}

