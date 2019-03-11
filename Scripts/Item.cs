using UnityEngine;
using System.Collections;
public enum ItemType { DOC, Umbrella, USB, DarkCoffee, CoffeeMilk, Tea, Cappuccino, CaffeMacchiato, StrongCoffee, HotChocolate };

public class Item : MonoBehaviour
{

    public ItemType type;
    public Sprite spriteNeutral, spriteHighlighted;
    public static bool isUsed = false;
    public static bool drunk = false;
    public int maxSize;
    public void Use()
    {
        switch (type)
        {
            case ItemType.DOC:
                break;
            case ItemType.USB:
                if (Quest3Text.display)
                    isUsed = true;
                break;
            case ItemType.HotChocolate:
                CoffeMaker.obtion = 7;
                drunk = true;
                break;
            case ItemType.DarkCoffee:
                CoffeMaker.obtion = 1;
                drunk = true;
                break;
            case ItemType.CoffeeMilk:
                CoffeMaker.obtion = 2;
                drunk = true;
                break;
            case ItemType.Tea:
                CoffeMaker.obtion = 3;
                drunk = true;
                break;
            case ItemType.Cappuccino:
                CoffeMaker.obtion = 4;
                drunk = true;
                break;
            case ItemType.CaffeMacchiato:
                CoffeMaker.obtion = 5;
                drunk = true;
                break;
            case ItemType.StrongCoffee:
                CoffeMaker.obtion = 6;
                drunk = true;
                break;

        }

    }
}
