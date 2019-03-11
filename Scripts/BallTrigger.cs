using UnityEngine;
using System.Collections;

public class BallTrigger : MonoBehaviour {

    private bool isInRange = false;
    private bool isTriggered = false;
    public GameObject ball;
	void Update () {
        if (Input.GetKeyDown(KeyCode.E) && isInRange && isTriggered == false)
        {
            GameObject.Find("batramp").GetComponent< Animation > ().Play("RampDown");
            ball.GetComponent< Rigidbody > ().useGravity = true;
            isTriggered = true;
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            isInRange = true;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            isInRange = false;
        }
    }
   void OnGUI()
    {
        if (isInRange && isTriggered == false)
            GUI.Box(new Rect(Screen.width / 2, Screen.height / 2, 200, 25), "Press 'E' to press the button");
    }
}
