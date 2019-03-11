using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class DisplayImage : MonoBehaviour
{
    public Texture aTexture;
    public Texture bTexture;
    public static float dim = 110;
    private float scale = 0.55f;
    void Start()
    {
        dim = 110;
    }
    void Update()
    {
        if (dim > 5) dim -= scale * Time.deltaTime;
        else {
            SceneManager.LoadScene("something");
            CoinCounter.gscore = 0;
        }
    }
    void OnGUI()
    {

        GUI.DrawTexture(new Rect(Screen.width - 120, 30, 110, 13), aTexture, ScaleMode.ScaleAndCrop, true, 10.0F);
        GUI.DrawTexture(new Rect(Screen.width - 120, 30, dim, 13), bTexture, ScaleMode.ScaleAndCrop, true, 10.0F);
        if (dim < 20)
            GUI.Box(new Rect(Screen.width / 2, Screen.height / 2, 200, 25), "You should drink a coffee");
    }
}
