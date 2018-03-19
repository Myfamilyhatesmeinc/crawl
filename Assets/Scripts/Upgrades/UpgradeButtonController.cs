using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeButtonController : MonoBehaviour {

	//going to need to know curernt currency amount
	//going to need the upgrade to upgrade
	public string upgradeName;

	Button button;
	private Text textField;

	UpgradeManager manager;
	Upgrade upgrade;
	CurrencyCounter counter;
	//when clicked, if currency high enough, buy upgrade and deduct amount

	// Use this for initialization
	void Start () {
		button = GetComponent<Button> ();
		button.onClick.AddListener (TaskOnClick);

		textField = gameObject.GetComponentInChildren (typeof(Text)) as Text;

		counter = GameObject.Find ("CurrencyCounter").GetComponent<CurrencyCounter>();
		manager = GameObject.Find ("UpgradeManager").GetComponent<UpgradeManager> ();

		InvokeRepeating ("RefreshTextField", 0.3f, 2.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void TaskOnClick() {
		if (counter.GetCurrency () >= GetUpgrade ().getUpgradeCost ()) {
			counter.AddCurrency (-1 * GetUpgrade ().getUpgradeCost ());
			GetUpgrade ().buyUpgrade ();
			RefreshTextField ();
		}
	}

	Upgrade GetUpgrade() {
		if (upgrade == null) {
			upgrade = manager.getUpgrade (upgradeName);
		}
		return upgrade;
	}

	void RefreshTextField() {
		textField.text = GetUpgrade ().getLevel()
			+ " - "  + GetUpgrade ().getName ().ToUpper ()
			+ " - $" + GetUpgrade ().getUpgradeCost ();
	}
		

}
