using UnityEngine;
using System.Collections;

public class ClassesandDataTypes : MonoBehaviour 
{
	public class AFCwest
	{
		public int Broncos;
		public int Chiefs;
		public int Raiders;
		public int Chargers;
	

		// Default - Constructor is used to give vales to int, the 2 paranthasesis mean its a constructor
		
		public AFCwest()
	{
		Broncos =1;
		Chiefs =4;
		Raiders =2;
		Chargers =3;
	}

		//Creating our own Constructor (parameterized constructor)
		
		public AFCwest(int Den, int Kan, int Oak, int San)
		{ 
			Broncos =Den;
			Chiefs =Kan;
			Raiders =Oak;
			Chargers =San;
		}

	}

	// Creating an instance of a class (or Object), Used for setting default values
	public AFCwest AFCstandings = new AFCwest (1,4,2,3);


	void Start () 
	{
		Debug.Log(AFCstandings);

		int num1 = 5;
		int num2 = num1;
		num2 = 10;

		AFCwest afc2 = AFCstandings;
		afc2.Broncos = 5;
	}

	


	// Use this for initialization

	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
