using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using WMPLib;

namespace bmetGame
{
    public partial class frmScores : Form
    {
        public static ArrayList scores = new ArrayList();     // Array list for all scores for BmetApplea game
        public static ArrayList mazeScores = new ArrayList(); // Array list for all scores for BmetMaze game
        static ArrayList sortedArray = new ArrayList();       // Scores sorted array for BmetApples game
        static ArrayList mazeSortedArray = new ArrayList();   // Scores sorted array for BmetMaze game
        static ArrayList tstArray = new ArrayList();          // Array uses in sorting scores in BmetApplea game
        static ArrayList tstMazeArray = new ArrayList();      // Array uses in sorting scores in BmetMaze game

        public frmScores()
        {
            InitializeComponent();
        }

        private void formScores_Load(object sender, EventArgs e)
        {
            if (scores.Count > 0) 
            {
                sortedArray.Clear();
                tstArray.AddRange(scores);
                sortResults();
                removeRedundancy(sortedArray);
                foreach (string item in sortedArray)
                {
                    rTxtResults.AppendText(item.ToString());
                }
            }

            if (mazeScores.Count > 0) 
            {
                mazeSortedArray.Clear();
                tstMazeArray.AddRange(mazeScores);
                mazeSortResults();
                removeRedundancy(mazeSortedArray);
                foreach (string item in mazeSortedArray)
                {
                    richMazeResult.AppendText(item.ToString());
                }
            }     
        }

        /* Get max score from BmetApple game; this function has applied from two games type
         * when game type = 0, that is mean the max score will be returned
         * when game type = 1, that is mean the minimum time is the max score and will be returned as a max 
        */
        private static int getMaxScore(ArrayList lst, int gameType)
        {
            string str; // string for each score
            int maxScore1 = 0, maxScore2 = 0; // two variables for comapring
            int minScore1 = 0, minScore2 = 0;
            foreach (string item in lst)
            {
                if (gameType == 0)
                {
                    str = item.Remove(0, item.LastIndexOf('=') + 1);
                    maxScore1 = Convert.ToInt32(str);
                    if (maxScore1 >= maxScore2)
                    {
                        maxScore2 = maxScore1;
                    }
                }else if (gameType == 1)    
                {
                    str = item.Remove(0, item.LastIndexOf('=') + 1);
                    minScore1 = Convert.ToInt32(str);
                    if (minScore2 == 0)
                    {
                        minScore2 = minScore1;
                    }
                    if (minScore1 <= minScore2)
                    {
                        minScore2 = minScore1;
                    }
                }        
            }

            if (gameType == 0)
            {
                return maxScore2;
            }else
            {
                return minScore2;
            }
            
        }

        // I have used this function to fill sort array in the BmetApple game
        private static void sortResults()
        {
            int maxScore = 0, currenIindex = 0;
            maxScore = getMaxScore(tstArray,0);
            
            foreach (string item in tstArray)
            {
                if (item.Contains(maxScore.ToString()))
                {
                    sortedArray.Add(item);
                    currenIindex = tstArray.IndexOf(item);
                }

                if (currenIindex > -1)
                {
                    tstArray.RemoveAt(currenIindex);
                }
            }

            if (tstArray.Count > 0)
            {
                sortResults();
            }
        }

        // I have used this function to fill sort array in the BmetMaze game
        private static void mazeSortResults()
        {
            int maxScore = 0, currenIindex = 0;
            maxScore = getMaxScore(tstMazeArray,1);
            foreach (string item in tstMazeArray)
            {
                if (item.Contains(maxScore.ToString()))
                {
                    mazeSortedArray.Add(item);
                    currenIindex = tstMazeArray.IndexOf(item);
                }
            }

            if (currenIindex > -1)
            {
                tstMazeArray.RemoveAt(currenIindex);
            }

            if (tstMazeArray.Count > 0)
            {
                mazeSortResults();
            }
        }

        // I have used the function to remove repeated scores for both games
        private void removeRedundancy(ArrayList lst)
        {
            for (int i = 0; i < lst.Count; i++)
            {
                for (int j = i + 1; j < lst.Count; j++)
                {
                    if (lst[i].ToString() == lst[j].ToString())
                        lst.Remove(lst[j]);
                }
            }
        }
    }
}
