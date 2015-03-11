using UnityEngine;
using System.Collections;

public class Tank : DestructableObject {

	public Camera camera;
	public GameObject bulletPrefab;
	private GameObject Turret;
	private GameObject Nozzle;
	// Use this for initialization
	void Start () {
	
	}
	void findNozzleTurret ()
	{
		Transform[] transforms = GetComponentsInChildren<Transform> ();
		foreach (Transform t in transforms) 
		{
			if(t.gameObject.name == "Turret")
			{
				Turret = t.gameObject;
			}
			if(t.gameObject.name == "Nozzle")
			{
				Nozzle = t.gameObject;
			}
		}
	}
	void Aim () 
	{
		Vector3 mousePos = Input.mousePosition;
		mousePos.z = camera.transform.position.y - turret.transform.position.y;
		
		Vector3 worldPos = camera.ScreenToWorldPoint(mousePos);
		
		targetPos = worldPos;
		
		base.Update();
	}
	void aimTurret()
	{
		Aim ();
	}
	void reload()
	{

	}
	void fireBullet()
	{
		if(Input.GetButtonDown("Fire1"))
		{
			Quaternion rotation = Quaternion.Euler(Vector3.up * Turret.transform.rotation.eulerAngles.y);
			
			Instantiate(bulletPrefab, Nozzle.transform.position, rotation);
		}
	}
	}
}
