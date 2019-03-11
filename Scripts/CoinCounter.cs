using UnityEngine;
using System.Collections;

public class CoinCounter : MonoBehaviour {

    public static float gscore = 0;
	void OnGUI()
    {
        GUI.Label(new Rect(Screen.width - 70, 10, 100, 25), ("Coins: " + gscore));
    }
}
