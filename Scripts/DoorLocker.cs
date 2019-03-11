using UnityEngine;
using System.Collections;

public class DoorLocker : MonoBehaviour {
    public bool isLocked = false;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
            isLocked = true;
     }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
            isLocked = false;
    }
   public void OnGUI()
    {
        if(isLocked==true)
          GUI.Box(new Rect(Screen.width / 2, Screen.height / 2, 200, 25), "Door is locked!");
    }
}
