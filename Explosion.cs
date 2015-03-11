using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {

	public float maxLifeTime;
	private float lifeTime;
	public float lightFade;
	private Light light;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void fadeExplosion()
	{
		light.intensity -= lightFade;
		
		lifeTime += Time.deltaTime;
		if (lifeTime > maxLifeTime)
		{
			Destroy(this.gameObject);
		}
	}
}
