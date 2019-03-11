using UnityEngine;
using System.Collections;

public class Drawer3Open : MonoBehaviour {

    public GameObject Key;
    private bool isOpen = false;
    public GameObject openClosed;
    public GameObject isQuest2;
    private bool Drawer;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && Drawer == true && isQuest2.activeSelf == false && Key.activeSelf == false && isOpen == false)
        {
            GameObject.Find("Drawer3").GetComponent< Animation > ().Play("drawer3Open");
            isOpen = true;
            isQuest2.gameObject.SetActive(false);
            openClosed.gameObject.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.E) && Drawer == true && Key.activeSelf == false && isOpen == true)
        {
            GameObject.Find("Drawer3").GetComponent< Animation > ().Play("drawer3Close");
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
        if (Drawer == true && Key.activeSelf == true && isQuest2.activeSelf == false)
            GUI.Box(new Rect(Screen.width / 2, Screen.height / 2, 100, 25), "Find the key");
        else if (Drawer == true && Key.activeSelf == false && isQuest2.activeSelf == true)
            GUI.Box(new Rect(Screen.width / 2, Screen.height / 2, 200, 25), "You cannot open it at the moment");
        else if (Drawer == true && Key.activeSelf == false && isOpen == false)
            GUI.Box(new Rect(Screen.width / 2, Screen.height / 2, 150, 25), "Press 'E' to open");
        else if (Drawer == true && isOpen == true)
            GUI.Box(new Rect(Screen.width / 2, Screen.height / 2, 150, 25), "Press 'E' to close");
    }
}
