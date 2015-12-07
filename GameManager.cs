using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public delegate void Duckdel();
	public static Duckdel OnSpawnDucks;
	public static Duckdel OnDuckShot;
	public static Duckdel OnDuckDeath;
	public static Duckdel OnDuckFlyAway;
	public static Duckdel OnDuckMiss;


//	void Start () {
	
//	}
	
	// Update is called once per frame
//	void Update () {
	
//	}
}
