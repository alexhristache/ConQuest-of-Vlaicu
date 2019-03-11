using UnityEngine;
using System.Collections;

public class CoffeMaker : MonoBehaviour {

    public static int obtion = 0,i;
    private bool coffeeRange = false, guiShow;
    private bool chosenObtion = false;
    public static bool isTaken = false;
    public TextAsset textFile;
	private string text;
    public GUISkin customSkin;
    public static GameObject[] v;
  	private float [] value={0f,2.5f,1f,0.5f,1.5f,2f,5f,3f};
	private float [] energy = {0f,45f,25f,15f,30f,30f,60f,40f};
	private KeyCode[] keyCodes = {
		KeyCode.Alpha0, 
		KeyCode.Alpha1,
		KeyCode.Alpha2,
		KeyCode.Alpha3,
		KeyCode.Alpha4,
		KeyCode.Alpha5,
		KeyCode.Alpha6,
		KeyCode.Alpha7
	};
    public GameObject empty;
    public GameObject DarkCoffee;
    public GameObject CoffeeMilk;
    public  GameObject Tea;
    public  GameObject Cappuccino;
    public  GameObject CaffeMacchiato;
    public  GameObject StrongCoffee;
    public  GameObject HotChocolate;
    void Start()
	{
		text = textFile.text;
        v = new GameObject[8];
            v[0] = empty;
            v[1] = DarkCoffee;
            v[2]= CoffeeMilk;
            v[3]= Tea;
            v[4]= Cappuccino;
            v[5]=CaffeMacchiato;
            v[6]=StrongCoffee;
            v[7]=HotChocolate;
    }
	void Update () {
		if(coffeeRange)
		{
			if (chosenObtion == false)
				for (i = 1; i <= 7; i++)
					if (Input.GetKeyDown (keyCodes [i])) {
						obtion = i;
						chosenObtion = true;
					}
			if (CoinCounter.gscore>=value[obtion] && Input.GetKeyDown(KeyCode.E)){
                v[obtion].SetActive(true);
   				CoinCounter.gscore -= value [obtion];
                chosenObtion = false;
			}

		}
        if(obtion!=0 && Item.drunk)
        {
            if (DisplayImage.dim + energy[obtion] > 110)
                DisplayImage.dim = 110;
            else
                DisplayImage.dim += energy[obtion];
            obtion = 0;
            Item.drunk = false; 
        }
        if (v[obtion].activeSelf && Input.GetKeyDown(KeyCode.Q) && isTaken==true)
        {
            v[obtion].SetActive(false);
            obtion = 0;
            Player.isRange = false;
            isTaken = false;
        }
    }				
	void OnTriggerEnter(Collider col){
		if (col.tag == "Player")
			coffeeRange = true;
	}
	void OnTriggerExit(Collider col){
		if (col.tag == "Player") {
			coffeeRange = false;
			chosenObtion = false;
           if(isTaken== true) obtion = 0;
		}
	}
	void OnGUI()
	{
        GUI.skin = customSkin;

        if (coffeeRange) {
            if (CoinCounter.gscore < value[obtion])
                GUI.Box(new Rect(Screen.width / 2, Screen.height / 2, 600, 100), "You don't have enough money");
            else
                if (chosenObtion)
                GUI.Box(new Rect(Screen.width / 2, Screen.height / 2, 600, 100), "Press 'E' to get your drink"); 
                    else GUI.Box(new Rect(Screen.width * 1 / 5, Screen.height * 1 / 5, Screen.width * 5 / 7, Screen.height * 5 / 7), text);
		}
	}
}
