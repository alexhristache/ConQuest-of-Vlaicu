using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour {

    public GameObject theKey;
    private bool keyRange = false;
    public GameObject isOpen;
	
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && keyRange == true && isOpen.activeSelf == false && isOpen != null)
            theKey.SetActive(false);
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            keyRange = true;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            keyRange = false;
        }
    }

}
