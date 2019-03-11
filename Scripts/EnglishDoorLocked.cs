using UnityEngine;
using System.Collections;

public class EnglishDoorLocked : MonoBehaviour
{

    public GameObject Quest2Closed;
    void Update()
    {
        if (Quest2Closed.activeSelf == false)
            Destroy(gameObject);

    }
}
