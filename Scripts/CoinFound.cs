using UnityEngine;
using System.Collections;

public class CoinFound : MonoBehaviour {

    public float value;
    private bool coinRange = false;
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Z) && coinRange)
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
