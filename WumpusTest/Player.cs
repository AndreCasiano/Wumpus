using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

public class Player
{
	private int goldCoins;
	private int arrows;
	private int turns;
	private int score;
	private Boolean killWumpus;
	public Player(int goldCoins, int arrows, int turns)
	{
		this.goldCoins = goldCoins;
		this.arrows = arrows;
		this.turns = turns;
	}
	public int getgoldCoins()
    {
		return goldCoins;
    }
	public int getarrows()
    {
		return arrows;
    }
	public int getturns()
    {
		return turns;
    }
	public Boolean getkillWumpus()
    {
		return killWumpus; 
    }
	public void setgoldCoins(int goldCoins)
    {
		this.goldCoins = goldCoins;
    }
	public void setarrows(int arrows)
    {
		this.arrows = arrows;
    }
	public void setturns(int turns)
    {
		this.turns = turns;
    }
	public void setkillWumpus(Boolean killWumpus)
    {
		this.killWumpus = killWumpus;
    }
	public int calculateScore()
    {
		int w = 0;
        if (killWumpus)
        {
			w = 50;
        }
		return 100 - turns + goldCoins + (5 * arrows) + w; 
    }
}
