using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageSpinner : MonoBehaviour {

	public float speed = 180f;	//degree rotation per second

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.forward * speed * Time.deltaTime);
	}
}
