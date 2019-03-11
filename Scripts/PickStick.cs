using UnityEngine;
using System.Collections;

public class PickStick : MonoBehaviour
{
    private bool clueRange = false;
    public static bool canPick = false, isPicked = false;
    private bool display=false;
    private bool isInRange = false;
    public GameObject isOpen;
    public GameObject quest2Closed;
    public GameObject stick;
    private string questText;
    public TextAsset textFile;
    public GUISkin customSkin;
    void Start()
    {
        questText = textFile.text;
    }
    void Update()
    {
        if (isOpen.activeSelf == false && isInRange == true && stick.activeSelf == true && display == false)
            display = true;
        if (Input.GetKeyDown(KeyCode.Q) && isOpen.activeSelf == false && isInRange == true && display == true)
            canPick = true;
        if (Input.GetKeyDown(KeyCode.Q) && isOpen.activeSelf == false && isInRange == true && display == true && isPicked)
        {
             quest2Closed.SetActive(false);
             stick.SetActive(false);
             Player.isRange = false;     
             canPick = false;
        }
                
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
            isInRange = true;
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
            isInRange = false;
    }
    void OnGUI()
    {
        GUI.skin = customSkin;
        if(display==true)
         GUI.Box(new Rect(Screen.width * 1 / 5, Screen.height * 1 / 5, Screen.width * 5 / 7, Screen.height * 5 / 7), questText);
    }
}
