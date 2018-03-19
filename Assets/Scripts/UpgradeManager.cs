using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour {

	private Dictionary<string, Upgrade> upgradeList;

	// Use this for initialization
	void Start () {
		upgradeList = new Dictionary<string, Upgrade> ();
		upgradeList.Add(Constants.UPGRADE_CLICK_AMOUNT, 	new Upgrade(Constants.UPGRADE_CLICK_AMOUNT, 20));
		upgradeList.Add(Constants.UPGRADE_PASSIVE_AMOUNT, 	new Upgrade(Constants.UPGRADE_PASSIVE_AMOUNT, 200));
		upgradeList.Add(Constants.UPGRADE_3_NAME, 			new Upgrade(Constants.UPGRADE_3_NAME, 2000));
		upgradeList.Add(Constants.UPGRADE_4_NAME, 			new Upgrade(Constants.UPGRADE_4_NAME, 20000));
		upgradeList.Add(Constants.UPGRADE_5_NAME, 			new Upgrade(Constants.UPGRADE_5_NAME, 200000));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public Upgrade getUpgrade(string name) {
		if (upgradeList != null && upgradeList.ContainsKey (name)) {
			return upgradeList [name];
		}
		// doesn't exist, return null I guess? we should probably clean this up
		return null;
	}
}
