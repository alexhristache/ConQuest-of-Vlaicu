using UnityEngine;
using System.Collections;

public class DoorScript : MonoBehaviour {
	public bool open = false;
	public float doorOpenAngle;
	public float doorCloseAngle;
	public float smooth=2f;
	public GameObject isOpen; 
	// Use this for initialization
	void Start () {
	
	}
	public void ChangeDoorState()
	{
		open = !open;
	}
	void Update () {
		
		if (open) {
			Quaternion targetRotation = Quaternion.Euler (0, doorOpenAngle, 0);
			transform.localRotation = Quaternion.Slerp (transform.localRotation, targetRotation, smooth* Time.deltaTime);
			isOpen.gameObject.SetActive (false);
		}
		else {
			Quaternion targetRotation2 = Quaternion.Euler (0, doorCloseAngle, 0);
			transform.localRotation = Quaternion.Slerp (transform.localRotation, targetRotation2, smooth* Time.deltaTime);
			isOpen.gameObject.SetActive (true);
		}

	}
}
