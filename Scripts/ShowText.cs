using UnityEngine;
using System.Collections;

public class ShowText : MonoBehaviour {

    private bool guiShow;
   void OnControllerColliderHit(ControllerColliderHit hit) 
    {
        if (hit.gameObject.tag == "Door")
            guiShow = true;
        else guiShow = false;
    }
    void OnGUI()
    {
        if (guiShow == true)
            GUI.Box(new Rect(Screen.width / 2, Screen.height / 2, 100, 25), "Press 'E' to open/close the door");
    }
}
