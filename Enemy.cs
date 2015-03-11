using UnityEngine;
using System.Collections;

public class Enemy : DestructableObject {

	public Transform player;
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void determineTarget()
	{

	}
	void checkIfSeesPlayer()
	{
		if (player != null) {
			targetPos = player.position;
			base.Update ();
	}
}
