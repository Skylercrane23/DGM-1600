using UnityEngine;
using System.Collections;

public class Enumerations : MonoBehavior 
{

	enum FootballPlayer {Player1, Player2, Player3, Player4};

	
	void Start () 
	{
		FootballPlayer myplayer; 
		
		myplayer = FootballPlayer.Player1;
	
	}
	
	FootballPlayer reversefootballplayer (FootballPlayer foot)
	{
		if(foot == FootballPlayer.Player1)
			foot= FootballPlayer.Player2;
		
		return foot;		
	}
	
	
	// Update is called once per frame
	void Update () {
	
	}
}
