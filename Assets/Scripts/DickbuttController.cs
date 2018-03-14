using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DickbuttController : MonoBehaviour {

	CurrencyCounter counter;

	// Use this for initialization
	void Start () {
		counter = GameObject.Find ("CurrencyCounter").GetComponent<CurrencyCounter>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown () {
		//Debug.Log ("You clicked the dick");
		counter.AddCurrency(Mathf.CeilToInt(Random.value * 1000000));
	}

}
