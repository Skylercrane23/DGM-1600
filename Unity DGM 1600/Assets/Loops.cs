using UnityEngine;
using System.Collections;

public class Loops : MonoBehaviour 
{

	//While Loop 

	public int ShotsMade = 4;

	private VariableFunction FarFunc;

	void Start()
	{
		whilelooptest ();
		dowhilelooptest ();
		forlooptest ();
		foreachlooptest ();
	}

	 void whilelooptest()
	{
		while (ShotsMade > 0)
		{
			Debug.Log ("You've Made a Shot");
			ShotsMade--;
		}
	}



	// Do while Loop

	void dowhilelooptest ()
	{
		bool Broncoswin = false;

		do 
		{ 
			print ("Broncos Win!");
		} while (Broncoswin == true);
	
	}

	//For Loop

	int NumberofWins = 13;

	void forlooptest()
	{
		for (int Wins = 0; Wins < NumberofWins; Wins++) 
		{
			Debug.Log ("Denver Broncos earn Victory Number " + Wins); 
		}	 

	} 


	//foreach Loop

	void foreachlooptest ()
	{
		string[] Weapons = new string [3];

		Weapons [0] = "sword";
		Weapons [1] = "bow";
		Weapons [2] = "axe";

		foreach (string item in Weapons) 
		{
			Debug.Log (item);
		}
	}
}


