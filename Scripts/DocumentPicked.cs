using UnityEngine;
using System.Collections;

public class DocumentPicked : MonoBehaviour {

    public GameObject doc;
    public GameObject open;
    public GameObject q1Closed;
    private bool docRange = false;

    void Update () {
        if (Input.GetKeyDown(KeyCode.Q) && docRange == true && open.active == false)
        {
            doc.active = false;
            q1Closed.active = false;
            Player.isRange = false;
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            docRange = true;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            docRange = false;
        }
    }
    void OnGUI()
    {
        if (docRange == true && open.active == false)
            GUI.Box(new Rect(Screen.width /2, Screen.height* 4 / 5, 200, 25), "Press 'Q' to pick up the schedule");
    }

}
