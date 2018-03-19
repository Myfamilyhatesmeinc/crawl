using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Upgrade : MonoBehaviour {

	private new string name = "";
	private int level = 0;
	private int baseCost = 1;

	public Upgrade(string name, int baseCost) {
		this.name = name;
		this.baseCost = baseCost;
	}

	public string getName() {
		return name;
	}

	public int getLevel () { 
		return level;
	}

	public int getBaseCost () {
		return baseCost;
	}

	public void buyUpgrade () {
		level += 1;
	}

	// all upgrades have the same formula (for now)
	// Base cost * 1.15 * (Buildings_of_this_type + 1)
	public int getUpgradeCost() {
		double nextCost = Convert.ToDouble(getBaseCost ()) * // base cost
			1.15 * 
			Convert.ToDouble(getLevel ()); // buildings of type + 1

		return Convert.ToInt32 (nextCost);
	}

}
