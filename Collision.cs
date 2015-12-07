using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour {
	public enum Changer { Horizontal, Vertical};
	public Changer changer; 
	// Use this for initialization
	void Start () 
	{
		GameManager.OnDuckShot += TurnOff;
		GameManager.OnDuckMiss += TurnOff;
		GameManager.OnSpawnDucks += TurnOn; 
	}
	
	// Update is called once per frame
	//void Update () {
	
	//}

public void onCollisionEnter(Collision hit)
	{
		if(hit.transform.tag == "Duck")
	
		{
			DuckMovements movement = hit.transform.Getcomponet<DuckMovements>();

			if(direction == changer.Horizontal)

			{
			movement.DirectionChanger(new Vector3(-1f, 1f, 0));
			}
					else if(direction == Changer.Vertical)
				{
				movement.DirectionChanger(new Vector3(1f, -1f, 0));
				}
			}		
		}
   public void TurnOff()	
{
	gameObject.SetActive(false);
}

public void TurnOn()
{
	gameObject.SetActive(true);
	}
}