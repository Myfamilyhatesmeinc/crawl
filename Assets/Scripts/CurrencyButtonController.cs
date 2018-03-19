using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyButtonController : MonoBehaviour {

	CurrencyCounter counter;
	UpgradeManager upgradeManager;
	Upgrade buttonUpgrade;
	Button button;
	public AudioSource sound;

	// Use this for initialization
	void Start () {
		counter = GameObject.Find ("CurrencyCounter").GetComponent<CurrencyCounter>();
		upgradeManager = GameObject.Find ("UpgradeManager").GetComponent<UpgradeManager> ();
		buttonUpgrade = upgradeManager.getUpgrade (Constants.UPGRADE_CLICK_AMOUNT);

		button = GetComponent<Button> ();
		button.onClick.AddListener (TaskOnClick);
	}
	
	// Update is called once per frame
	void TaskOnClick() {
		//Debug.Log ("Button upgrade level: " + buttonUpgrade.getLevel ());
		counter.AddCurrency (1 + buttonUpgrade.getLevel());
		sound.Play ();
	}
}
