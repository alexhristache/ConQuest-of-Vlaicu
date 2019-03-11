using UnityEngine;
using System.Collections;

public class AllCluesFound : MonoBehaviour {

	public GameObject c1;
	public GameObject c2;
	public GameObject c3;
	public GameObject c4;
	public GameObject c5;
	public GameObject allFound;
	void Update () {
		if (c1.activeSelf == false && c2.activeSelf == false &&c3.activeSelf == false&&c4.activeSelf == false &&c5.activeSelf == false)
				allFound.SetActive (false);
	}
}
