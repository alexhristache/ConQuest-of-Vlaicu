using UnityEngine;
using System.Collections;

public class DrawerOpen : MonoBehaviour {

    public GameObject Key;
    public GameObject q1Closed;
    private bool isOpen = false;
    public GameObject openClosed;
    private bool Drawer = false;

	void Update () {
        if (Input.GetKeyDown(KeyCode.E) && Drawer == true && Key.activeSelf == false && isOpen == false)
        {
            GameObject.Find("Drawer").GetComponent< Animation > ().Play("DrawerOpen");
            isOpen = true;
            q1Closed.gameObject.SetActive(false);
            openClosed.gameObject.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.E) && Drawer == true && Key.activeSelf == false && isOpen == true)
        {
            GameObject.Find("Drawer").GetComponent< Animation > ().Play("DrawerClose");
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
        if (Drawer == true && Key.activeSelf == true)
            GUI.Box(new Rect(Screen.width / 2, Screen.height / 2, 100, 25), "Find the key");
        else if (Drawer == true && Key.activeSelf == false && isOpen == false)
            GUI.Box(new Rect(Screen.width / 2, Screen.height * 6 / 7, 200, 25), "Press 'E' to open");
        else if (Drawer == true && isOpen == true)
            GUI.Box(new Rect(Screen.width / 2, Screen.height * 6 / 7, 200, 25), "Press 'E' to close");
    }
}
