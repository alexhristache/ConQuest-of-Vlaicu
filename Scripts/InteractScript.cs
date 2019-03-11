using UnityEngine;
using System.Collections;

public class InteractScript : MonoBehaviour {
	public float interactDistance = 10f;
	void Update () {
		
		if (Input.GetKeyDown ("e")) {
			Ray ray = new Ray (transform.position,transform.forward);
			RaycastHit hit;
			if(Physics.Raycast(ray,out hit,interactDistance))
			{ if (hit.collider.CompareTag ("Door"))
					hit.collider.transform.parent.GetComponent<DoorScript> ().ChangeDoorState ();
			}
		}
	}

}
