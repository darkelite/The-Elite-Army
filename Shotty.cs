using UnityEngine;
using System.Collections;

public class Shotty : MonoBehaviour {

	RaycastHit blam;

	private int bulletAmt;
	public int maxBullets;

	// Use this for initialization
	void Start () {
	
		GameManager.OnSpawnDucks += resetBullets;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
		{
			bulletAmt--;

			if(bulletAmt <= 0)
			{
				GameManager.OnDuckMiss();
			}

			Vector3 mousePos = Input.mousePosition;
			mousePos.z = Camera.main.transform.position.z;

			if(Physics.Raycast(Camera.main.ScreenToWorldPoint(mousePos),Camera.main.transform.forward,out blam, Mathf.Infinity))
			{
				if(blam.transform.tag == "Duck")
					} 
				}
			}
		}
	}
}