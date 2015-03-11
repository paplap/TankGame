﻿using UnityEngine;
using System.Collections;

public class Bullet : TempObject {

	public float speed;
	public float maxLifeTime;
	private float lifeTime = 0f;
	public GameObject explosionPrefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void moveBullet()
	{
		float delta = Time.deltaTime;
		transform.Translate (Vector3.forward * speed * delta);
		lifeTime += delta;
		if (lifeTime > maxLifeTime) 
		{
			Destroy(this.gameObject); 
		}
	}
	removeOnImpact()
	{
		Instantiate(explosionPrefab, this.transform.position, this.transform.rotation);
		Destroy (this.gameObject);

	}
	void OnCollisionEnter(Collision coll)
	{
		removeOnImpact ();
	}
}
