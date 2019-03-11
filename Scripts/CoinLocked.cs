using UnityEngine;
using System.Collections;

public class CoinLocked : MonoBehaviour {

    public float value;
    public GameObject canPick;
    private bool coinRange = false;
	void Update () {
        if (Input.GetKeyDown(KeyCode.Z) && coinRange && canPick.active == false)
        {
            Destroy(gameObject);
            CoinCounter.gscore += value;
        }
    }
   void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            coinRange = true;
        }
    }
    void OnTriggerExit(Collider col) 
    {
        if (col.tag == "Player")
        {
            coinRange = false;
        }
    }
}
