using UnityEngine;
using System.Collections;

public class OnUpgradeButton : MonoBehaviour {

	int bank;
	int UpgradeVal;
	int UpgradeVal2;

	// Use this for initialization
	void Start () {
		bank = PlayerPrefs.GetInt("totalCoins");
		UpgradeVal = PlayerPrefs.GetInt("speedUpgradeVal");
	}

	public void OnSpeedDepress (){
		bank = PlayerPrefs.GetInt("totalCoins");
		UpgradeVal = PlayerPrefs.GetInt("speedUpgradeVal");
				if (UpgradeVal == 0){
					if (bank > 1500){
						PlayerPrefs.SetInt("speedUpgradeVal", 1);
						bank = bank - 1500;
						PlayerPrefs.SetInt("totalCoins",bank);
					}
				}
				
				if (UpgradeVal == 1){
					if (bank > 7500){
						PlayerPrefs.SetInt("speedUpgradeVal", 2);
						bank = bank - 7500;
						PlayerPrefs.SetInt("totalCoins",bank);
					}
				}
				
				if (UpgradeVal == 2) {
					if (bank > 10000) {
						PlayerPrefs.SetInt("speedUpgradeVal", 3);
						bank = bank - 10000;
						PlayerPrefs.SetInt("totalCoins",bank);
					}
				}
	}

	public void OnLivesDepress (){
		bank = PlayerPrefs.GetInt("totalCoins");
		UpgradeVal2 = PlayerPrefs.GetInt("livesUpgradeVal");
				if (UpgradeVal2 == 0){
					if (bank > 1500){
						PlayerPrefs.SetInt("livesUpgradeVal", 1);
						bank = bank - 1500;
						PlayerPrefs.SetInt("totalCoins",bank);
					}
				}
				if (UpgradeVal2 == 1){
					if (bank > 7500){
						PlayerPrefs.SetInt("livesUpgradeVal", 2);
						bank = bank - 7500;
						PlayerPrefs.SetInt("totalCoins",bank);
					}
				}
				if (UpgradeVal2 == 2) {
					if (bank > 10000) {
						PlayerPrefs.SetInt("livesUpgradeVal", 3);
						bank = bank - 10000;
						PlayerPrefs.SetInt("totalCoins",bank);
					}
		}
	}

}
