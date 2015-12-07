using UnityEngine;
using System.Collections;

public class scopesandmods : MonoBehaviour {


		public int easy = 10;

	public int Medium = 20;

	public int Hard = 50;

	private AnotherClass otherclass;

	void start ()
	
	{ 
		Hard = 120;

		otherclass = new nextclass ();
		otherclass.Hard (Hard, otherclass.Hard);

	}
	 
	void Example (int settings, int diffculty) 
	
	{
		int answer;
		answer = settings * diffculty * Hard;
		Debug.Log (answer);
	}
	void Update ()
	{
		Debug.Log ("Hard is set to: " + Hard);
  }

}