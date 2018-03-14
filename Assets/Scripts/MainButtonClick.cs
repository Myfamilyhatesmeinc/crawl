using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButtonClick : MonoBehaviour {

	public GameObject textBox;
	private int ClickMultiplier = 1;
	public bool FirstUpgradeBought = false;
	public bool SecondUpgradeBought = false;
	public bool ThirdUpgradeBought = false;
	public bool FourthUpgradeBought = false;
	public bool FifthUpgradeBough = false;

	public void ClickTheButton() {
		GlobalMonies.MoneyCount += (1*ClickMultiplier);	
	}

	public void BuyFirstUpgrade() {
		FirstUpgradeBought = true;
		ClickMultiplier += 1;
	}

	public void BuySecondUpgrade() {
		SecondUpgradeBought = true;
		ClickMultiplier += 2;
	}

	public void BuyThirdUpgrade() {
		ThirdUpgradeBought = true;
		ClickMultiplier += 3;
	}

	public void BuyFourthUpgrade() {
		FourthUpgradeBought = true;
		ClickMultiplier += 4;
	}

	public void BuyFifthUpgrade() {
		FifthUpgradeBough = true;
		ClickMultiplier += 5;
	}
}
