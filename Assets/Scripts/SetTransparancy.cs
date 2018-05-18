using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetTransparancy : MonoBehaviour
{
    public Button playButton;
    public Button optionsButton;
    public Button exitButton;
    // Use this for initialization
    void Start()
    {
        playButton.image.color = new Color(255f, 0f, 0f, .5f);
        exitButton.image.color = new Color(255f, 0f, 0f, .5f);
        optionsButton.image.color = new Color(255f, 0f, 0f, .5f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}