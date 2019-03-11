using UnityEngine;
using System.Collections;

public class MateDoorLocked : MonoBehaviour {

    public GameObject Quest1Closed;
	void Update () {
        if (Quest1Closed.activeSelf == false)
            Destroy(gameObject);
	}
}
