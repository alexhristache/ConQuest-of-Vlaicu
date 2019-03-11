using UnityEngine;
using System.Collections;

public class RotesteBanca : MonoBehaviour {

    private bool Banca = false;
    private bool isTorn = false;

	void Update () {
        if (Input.GetKeyDown(KeyCode.E) && Banca == true && isTorn == false)
        {
            GameObject.Find("Banca").GetComponent< Animation > ().Play("RotireMasa");
            isTorn = true;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            Banca = true;
        }

    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            Banca = false;
        }
    }
    void OnGUI()
    {
        
        if (Banca == true)
            GUI.Box(new Rect(Screen.width / 2, Screen.height / 2, 200, 25), "Press 'E' to flip desk");
    }
}
