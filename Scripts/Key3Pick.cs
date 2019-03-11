using UnityEngine;
using System.Collections;

public class Key3Pick : MonoBehaviour {

    public GameObject theKey;
    private bool keyRange=false;
 
	void Update () {
        if (Input.GetKeyDown(KeyCode.Q) && keyRange == true)
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
    void OnGUI()
    {
        if (keyRange == true)
            GUI.Box(new Rect(Screen.width / 2, Screen.height / 2, 200, 25), "Press 'Q' to pick up the key");
    }
}
