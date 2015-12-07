using UnityEngine;
using System.Collections;

public class DuckMovements : MonoBehaviour {


	public float speed;
	public Vector3 Direction;

	private int bounce;
	public int bounceMax;

	void Start () {
		GameManager.OnDuckShot += StopMovement;
		GameManager.OnDuckMiss += Flyaway;
		RandomDirection();

	}
	
	// Update is called once per frame
	void Update () {

		transform.position = transform.position + (Direction = speed);
	
	}
	public void RandomDirection()
	{
		Direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-2f, 1f), 0		                      
	}
		   {
			public void DirectioChanger(Vector3 _dir);
		}

		{
			Direction = new Vector3(Direction.x *_dir.x, Direction.y * _dir.y, 0);

			bounce++;

			if(bounce >= bounceMax)
			{
				direction = new Vector3(0, 1, 0);
				GameManager.OneDuckMiss();
			}
		}

		public void StopMovement()
		{
			direction = new Vector3(0, 0, 0);
		}

		public void startFall()
		{
			direction = new Vector3(0, -1, 0);
		}

		public void Flyaway
		{
			direction = new Vector3(0, 1, 0); 
		}
}