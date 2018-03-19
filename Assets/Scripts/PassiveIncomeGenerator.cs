using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassiveIncomeGenerator : MonoBehaviour {

	public float baseIncome = 0F; //Income per second
	float currencyBank = 0F;

	CurrencyCounter counter;
	Upgrade passiveUpgrade;

	// Use this for initialization
	void Start () {
		counter = GameObject.Find ("CurrencyCounter").GetComponent<CurrencyCounter>();
	}
	
	// Update is called once per frame
	void Update () {
		//Since I set the currency up as a long, we can't send fractions of a cookie that way...
		//instead I'll keep a bank here and send whole cookies

		currencyBank += (baseIncome + GetUpgrade().getLevel()) * Time.smoothDeltaTime;

		if (currencyBank >= 1f) {
			int wholeNumber = (int) Mathf.Floor (currencyBank);

			counter.AddCurrency (wholeNumber);
			currencyBank -= wholeNumber;
		}
	}

	Upgrade GetUpgrade() {
		if (passiveUpgrade == null) {
			passiveUpgrade = GameObject.Find ("UpgradeManager").GetComponent<UpgradeManager> ().getUpgrade (Constants.UPGRADE_PASSIVE_AMOUNT);
		}

		return passiveUpgrade;
	}
}
