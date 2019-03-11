using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public static bool isRange = false, canUse = false,umbPicked=false;
    private bool isOpen = false;
     public static bool usbRange=false;
	public GameObject chestie, inventar;
	public Inventory inventory;
	
    void Update()
    {
        if (isOpen == false && Input.GetKeyDown(KeyCode.I))
        {
            inventar.SetActive(false);
            isOpen = true;
        }
        else if (isOpen == true && Input.GetKeyDown(KeyCode.I))
        {
            inventar.SetActive(true);
            isOpen = false;
        }
        if(usbRange && isRange)
        {
            if (Input.GetKeyDown(KeyCode.Q) && PickStick.canPick)
            {
                inventory.AddItem(chestie.GetComponent<Item>());
                PickStick.isPicked = true;
                usbRange = false;
            }
        }
        else 
        if (isRange && Input.GetKeyDown(KeyCode.Q))
        {
            inventory.AddItem(chestie.GetComponent<Item>());
            CoffeMaker.isTaken = true;
            if(chestie.name=="umbrella" ) umbPicked = true;
        }
    }
	private void OnTriggerEnter(Collider col){
		if (col.tag == "Item") {
			isRange = true;
			chestie = col.gameObject;
		}
        if (col.name == "usb1") usbRange = true;
        if (col.name == "Quest3") canUse = true;
	}
	private void OnTriggerExit(Collider col){
        if (col.tag == "Item")
        {
            isRange = false;
            usbRange = false;
        }
        if (col.name == "Quest3") canUse = false;
    }
}
