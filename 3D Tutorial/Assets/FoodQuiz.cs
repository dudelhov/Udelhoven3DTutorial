using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodQuiz : MonoBehaviour
{
    [SerializeField] Dialogue _dialogue;
    [SerializeField] Dialogue _correctChoiceDialogue;
    [SerializeField] Dialogue _incorrectChoiceDialogue;

    [SerializeField] GameObject _correctFood;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter()
    {
        GameEvents.InvokeDialogIntiated(_dialogue);
    }

    public IEnumerator FoodSelected(GameObject food)
    {
        yield return new WaitForEndOfFrame();

        if (food == _correctFood)
        {
            GameEvents.InvokeDialogIntiated(_correctChoiceDialogue);
        }
        else
        {
            GameEvents.InvokeDialogIntiated(_incorrectChoiceDialogue);
        }

        Destroy(food);

    }
}
