using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WumpusTest
{
    class GraphicUI
    {
        // Instance Variables
        private String fileName; // to open or save GraphicUI
        // Constructors
        public GraphicUI(String name)
        {
            fileName = name;
        }

        // getHighScore - gets highscore from Game Control, updates the score on screen
        public void getHighScore(int highScore)
        {
            int myHS = 0;
            
            // stub
            // Prints text somewhere on screen, updates text
        }


        // Gets where doors are so that the drawing program knows where to indicate doors
        public void getDoors(int[] doors)
        {
            //show where doors are. 0 means no door, other numbers are doors that lead to those rooms.

            
            // stub - draws doors wherever there are doors, 0 means no door drawn on that side
        }

        // gets roomNumber you are in currently, displays that room to user
        public int roomNumber(int roomNumber)
        {
            // stub
            // display room
            return 1;
        }

    }
}
