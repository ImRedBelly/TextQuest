using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text choiceContent;
    public Text textContent;
    public Image backgroundImage;
    public Step startStep;
    public Step currentStep;

    void Start()
    {
        currentStep = startStep;
        UpdateText();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ChoiseAnswer(0);
            UpdateText();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ChoiseAnswer(1);
            UpdateText();
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ChoiseAnswer(2);
            UpdateText();
        }
    }
    void ChoiseAnswer(int index)
    {
        currentStep = currentStep.nextSteps[index];
    }
    void UpdateText()
    {
        choiceContent.text = currentStep.choiceContent;
        textContent.text = currentStep.textContent;
        backgroundImage.sprite = currentStep.backgroundSprite;
    }

}
