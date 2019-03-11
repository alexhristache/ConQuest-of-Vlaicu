using UnityEngine;
using System.Collections;

public class Drawer1Open : MonoBehaviour {

    public GameObject Key;
    private bool isOpen = false;
    public GameObject openClosed;
    public GameObject isQuest2;
    public GameObject allClues;
    private bool Drawer = false;
	void Update () {
        if (Input.GetKeyDown(KeyCode.E) && Drawer == true && allClues.activeSelf == false && Key.active == false && isOpen == false)
        {
            GameObject.Find("Drawer2").GetComponent< Animation > ().Play("Drawer2Open");
            isOpen = true;
            isQuest2.gameObject.SetActive(false);
            openClosed.gameObject.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.E) && Drawer == true && Key.active == false && isOpen == true)
        {
            GameObject.Find("Drawer2").GetComponent< Animation > ().Play("Drawer2Close");
            isOpen = false;
            openClosed.gameObject.SetActive(true);
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            Drawer = true;
        }

    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            Drawer = false;
        }
    }
    void OnGUI()
    {
        if (Drawer == true && Key.active == true && allClues.activeSelf == false)
            GUI.Box(new Rect(Screen.width / 2, Screen.height / 2, 100, 25), "Find the key");
        else if (Drawer == true && Key.active == false && allClues.activeSelf == true)
            GUI.Box(new Rect(Screen.width / 2, Screen.height / 2, 200, 25), "You cannot open it at the moment");
        else if (Drawer == true && Key.activeSelf == false && isOpen == false)
            GUI.Box(new Rect(Screen.width / 2, Screen.height / 2, 150, 25), "Press 'E' to open");
        else if (Drawer == true && isOpen == true)
            GUI.Box(new Rect(Screen.width / 2, Screen.height / 2, 150, 25), "Press 'E' to close");
    }
}
