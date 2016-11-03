using UnityEngine;
using UnityEngine.Advertisements;
using System.Collections;

public class playat : MonoBehaviour {

	// Use this for initialization
	void Start () {

		InvokeRepeating("LaunchProjectile", 120,120);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void LaunchProjectile () {

		Advertisement.Show ();

	}
}
