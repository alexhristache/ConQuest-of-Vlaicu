using UnityEngine;
using System.Collections;

public class Umbrella : MonoBehaviour {

    private bool isRange;
    public GameObject umbrella;
	void Update () {
	    if(Player.umbPicked==true && isRange)
        {
            umbrella.SetActive(false);
            isRange = false;
            Player.isRange = false;
        }
	}
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
            isRange = true;
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
            isRange = false;
    }
}
