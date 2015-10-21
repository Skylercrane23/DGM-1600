using UnityEngine;
using System.Collections;

public class Arrays : MonoBehaviour 
{
 
 	int[] players = new int[3]; 
 	
	void Start ()
	{
		players[0] =1;
		players[1] =2;
		players[2] =3; 
	
	for(int i =0; i < players.Length; i++)
	{
		Debug.Log ("element" +i+ "is" + players[i]);
	}
	
	}	
}		