using UnityEngine;
using System.Collections;

public class MenuAppearScript : MonoBehaviour
{

    public GameObject menu; // Assign in inspector
    private bool isShowing = false;
  

    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            isShowing = !isShowing;
            if (isShowing)
                Time.timeScale = 0f;
            else
                Time.timeScale = 1.0f;
            
            menu.SetActive(isShowing);
        }
    }
}