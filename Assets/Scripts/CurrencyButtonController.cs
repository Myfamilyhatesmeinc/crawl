using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyButtonController : MonoBehaviour {

	CurrencyCounter counter;
	Button button;
	public AudioSource sound;

	// Use this for initialization
	void Start () {
		counter = GameObject.Find ("CurrencyCounter").GetComponent<CurrencyCounter>();

		button = GetComponent<Button> ();
		button.onClick.AddListener (TaskOnClick);
	}
	
	// Update is called once per frame
	void TaskOnClick() {
		counter.AddCurrency (1);
		sound.Play ();
	}
}
