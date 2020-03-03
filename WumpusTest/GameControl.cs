using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WumpusTest
{
    class GameControl
    {
        private String fileName;

        public GameControl(String name)
        {
            fileName = name;
        }
        //code that calls Cave to return the array of connected rooms.
        public Array getConnectedRooms()
        {
            return null; 
        }
        //code that calls GameLocation for current room
        public Array getCurrentRoom() 
        {
            return null;
        }
        //code that calls GameLocation to determine how close Wumpus is, and if it's one room away, returns true. 
        public Boolean isWumpusClose()
        {
            return false;
        }
        //code that calls GameLocation to determine how close bats are. If they are one room away, returns true. 
        public Boolean areBatsClose()
        {
            return false;
        }
        //code that gets High Score from High Score Object.    
        public int getHighScore()
        {
            return 0;
        }
            
    }   
    
}
