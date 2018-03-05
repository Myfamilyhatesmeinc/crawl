using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour {

	public float countdown = 5f;
	public Text textComponent;

	private float startTime;

	// Use this for initialization
	void Start () {
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		textComponent.text = GetRemainingTime ().ToString();

		if (GetRemainingTime () <= 0) {
			SceneManager.LoadScene (1); //Loads game scene...
		}
	}

	private int GetRemainingTime() {
		return Mathf.CeilToInt (countdown - GetElapsedTime());
	}

	private float GetElapsedTime() {
		return Time.time - startTime;
	}
}
