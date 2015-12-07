using UnityEngine;
using System.Collections;

public class DuckHealth : MonoBehaviour {


	Animator anim;

	bool isInvincible;
	// Use this for initialization
	void Start () {
	
		GameManager.OnDuckMiss += MakeInvincible;
		GameManager.OnDuckShot += MakeInvincible;

	}
	
	// Update is called once per frame
	//void Update () {

	void OnTriggerEnter (Collider blam)
	{
			if(blam.tag == "KillzoneTag")
			{

	}

		{
		if (blam.tag == "flyzone")
			{
				GameManager.OnDuckFlyAway();

			}
		}

			public void KillDuck()
			{
				if(isInvincible == false)
				{
					anim.Play("DuckDead");
					GameManager.OnDuckShot();
				}
					public void MakeInvincible()
				{
					isInvincible = true;
			}

		}
