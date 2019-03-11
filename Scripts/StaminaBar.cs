using UnityEngine;
using System.Collections;

public class StaminaBar : MonoBehaviour {

	private int startSize = 100,minSize=5, maxSize=100, currScale ;
	private float speed= 2.0f;
	private Vector3 targetScale, baseScale ;
	void Start () {
		baseScale = transform.localScale;
		transform.localScale = baseScale * startSize;
		currScale = startSize;
		targetScale = baseScale * startSize;
	}

	void Update () {
		transform.localScale = Vector3.Lerp (transform.localScale, targetScale, speed * Time.deltaTime);
		if(Input.GetKeyDown(KeyCode.UpArrow)) 
			ChangeSize(true);
		if (Input.GetKeyDown (KeyCode.DownArrow))
			ChangeSize (false);
	}
	public void ChangeSize(bool bigger){
		if (bigger)
			currScale++;
		else
			currScale--;
		currScale = Mathf.Clamp (currScale, minSize, maxSize + 1);
		targetScale = baseScale * currScale;
	}
}
