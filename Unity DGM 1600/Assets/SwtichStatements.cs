using UnityEngine;
using System.Collections;

public class SwtichStatements : MonoBehaviour 
{
	public int level = 3;
	
	void Start ()
	{
		LevelUp();
	}
	
	void LevelUp ()
	{
		switch (level)
		{
			case 3: 
				print ("You are  now level 3!");
				break;
			case 2:
				print ("You are now level 2!");
				break;
			case 1:
				print ("You are now level 1!");
				break; 
			default:
				print ("You have no level!");
				break;			
		}
	}
	
		
}