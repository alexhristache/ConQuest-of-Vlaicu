using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        float forwardSpeed = Input.GetAxis("Vertical");
        Vector3 speed = new Vector3(0,0,forwardSpeed);
        CharacterController cc = GetComponent<CharacterController>();
        cc.SimpleMove(speed);
	}
}
