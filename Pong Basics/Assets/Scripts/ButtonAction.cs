using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAction : MonoBehaviour
{
    public Text scoreText;

    public void ButtonPressed()
    {
        scoreText.text = "We pressed the button!";
    }
}
