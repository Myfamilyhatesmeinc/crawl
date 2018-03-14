using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyCounter : MonoBehaviour {

	public static readonly string MAX_CURRENCY_READOUT = "9999999999";

	private long currency = 0L;
	private Text textField;

	// Use this for initialization
	void Start () {
		textField = GetComponent<Text> ();
		textField.text = GetCurrencyReadout ();
	}
	
	// Update is called once per frame
	void Update () {
	}

	public long GetCurrency() {
		return currency;
	}

	public void AddCurrency(long value) {
		currency += value;
		textField.text = GetCurrencyReadout();
	}

	public string GetCurrencyReadout() {
		//if less than ten digits, pad to ten.
		//if more than ten digits, set to max readout value.

		string currencyString = GetCurrency().ToString();
		if (currencyString.Length < 10) {
			return currencyString.PadLeft (10,'0');
		} else if (currencyString.Length > 10) {
			return currencyString = MAX_CURRENCY_READOUT;
		} else {
			return currencyString;
		}
	}
}
