using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLocation
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    class GameLocation
    {
        private int wumpusLocation;
        private int playerLocation;
        private int bat1Location;
        private int bat2Location;
        private int pit1Location;
        private int pit2Location;
        private int arrowsLeft;
        private String behaviour;

        //constructors
        public GameLocation(int wL, int pL, int b1L, int b2L, int p1L, int p2L, int aL, String b)
        {
            wumpusLocation = wL;
            playerLocation = pL;
            bat1Location = b1L;
            bat2Location = b2L;
            pit1Location = p1L;
            pit2Location = p2L;
            arrowsLeft = aL;
            behaviour = b;

        }
        public void setWumpusLocation(int wL)
        {
            wumpusLocation = wL;
        }
        public void setplayerLocation(int pL)
        {
            playerLocation = pL;
        }
        public void setbat1Location(int b1L)
        {
            bat1Location = b1L;
        }
        public void setbat2Location(int b2L)
        {
            bat2Location = b2L;
        }
        public void setpit1Location(int p1L)
        {
            pit1Location = p1L;
        }
        public void setpit2Location(int p2L)
        {
            pit2Location = p2L;
        }
        public void setarrowsLeft(int aL)
        {
            arrowsLeft = aL;
        }
        public void setbehaviour(int b)
        {
            behaviour = b;
        }
        public int getWumpusLocation()
        {
            return wumpusLocation;
        }
        public int getplayerLocation()
        {
            return playerLocation;
        }
        public int getbat1Location()
        {
            return bat1Location;
        } 
        public int getbat2Locationg()
        {
            return bat2Location;
        }
        public int getpit1Location()
        {
            return pit1Location;
        }
        public int getpit2Locationg()
        {
            return pit2Location;
        }
        public int getarrowsLeft()
        {
            return arrowsLeft;
        }
        public String getbehaviour()
        {
            return behaviour;
        }
        public String getWarning()
        {
            if (nearbyWumpus(wumpusLocation, playerLocation) == true)
            {
                return "I smell a Wumpus!";
            }
            int[] pits = new int[2];
            pits[0] = pit1Location;
            pits[1] = pit2Location;
            if (nearbyPits(pits, playerLocation))
            {
                return "I feel a draft";
            }
            int[] bats = new int[2];
            bats[0] = bat1Location;
            bats[1] = bat2Location;
            if(nearbyBats(bats, playerLocation))
            {
                return "Bats nearby..";
            }
        }
    }
}
