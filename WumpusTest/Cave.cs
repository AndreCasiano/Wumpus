using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WumpusTest
{
    class Cave
    {
        //instance variable 
        private String fileName;

        //constructor
        public Cave(String name)
        {
            fileName = name;
        }

        //methods
        public Boolean nearbyWumpus(int[] wumpus, int currentRoom)
        {
            //GameLocation calls nearbyWumpus with an integer array of all Wumpus locations
            //nearbyWumpus returns boolean based on if there is a Wumpus is an nearby room
            //calls the nearbyRooms method
            return true;
        }

        public Boolean nearbyBats(int[] bats, int currentRoom)
        {
            //GameLocation calls nearbyBats with an integer array of all Bat locations
            //nearbyBats returns boolean based on if there is a Pit is an nearby room
            //calls the nearbyRooms method
            return true;
        }

        public Boolean nearbyPits(int[] pits, int currentRoom)
        {
            //GameLocation calls nearbyPits with an integer array of all Pit locations
            //nearbyPits returns boolean based on if there is a Pit is an nearby room
            //calls the nearbyRooms method
            return true;
        }
        public int[] connectedRooms(int currentRoom)
        {
            //GameLoocation calls connectedRoooms with an int of the current room
            //connectedRooms returns an array of all rooms tha tcan be moved to
            //calls the nearbyRooms method
            int[] array= new int[3];
            return array;
        }
        public int[] nearbyRooms(int currentRoom)
        {
            //called within the cave object to find nearby hazards
            int[] array = new int[6];
            return array;
        }
    }
}
