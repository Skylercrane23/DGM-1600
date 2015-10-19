using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour 
{

	int DenverBroncos = 27;
	int KansasChiefs = 16;

	void Start()
	{ 
		if (DenverBroncos < KansasChiefs)
		{	
			Debug.Log ("Denver loses");

		} else if (DenverBroncos > KansasChiefs)

		{
			Debug.Log ("Denver Wins!");
		} 

		else
		{
			Debug.Log ("Tie Game");
		}
	}

}
	