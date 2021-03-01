using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Step : MonoBehaviour
{
    [TextArea(15, 50)]
    public string choiceContent;

    [TextArea(15, 50)]
    public string textContent;

    public Sprite backgroundSprite;
    public Step[] nextSteps;
}
