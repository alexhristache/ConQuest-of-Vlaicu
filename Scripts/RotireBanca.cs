using UnityEngine;
using System.Collections;

public class RotireBanca : MonoBehaviour {

    private bool guiShow = false;
    private bool isOpen = false;
    public GameObject banca;
    private int rayLength = 10;
	void Update () {
      RaycastHit hit;
       Vector3 fwd = transform.TransformDirection(Vector3.forward);
        if (Physics.Raycast(transform.position, fwd,out hit, rayLength))
        {
            if (hit.collider.gameObject.tag == "Banca")
            {
                guiShow = true;
                if (Input.GetKeyDown("e") && isOpen == false)
                {
                    banca.GetComponent< Animation > ().Play("RostogolireBanca");
                    isOpen = true;
                    guiShow = false;
                }
            }

        }
        else { guiShow = false; }
    }
    void OnGUI()
    {
        if (guiShow == true && isOpen == false)
            GUI.Box(new Rect(Screen.width / 2, Screen.height / 2, 100, 25), "Press 'E' to flip the table.");
    }
}
