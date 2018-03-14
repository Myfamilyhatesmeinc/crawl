using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalMonies : MonoBehaviour {

	public static int MoneyCount;
	public GameObject MoneyDisplay;
	public int InternalMonies;

	void Update () {
		InternalMonies = MoneyCount;
		MoneyDisplay.GetComponent<Text>().text = "Monies: " + InternalMonies;
	}
}
