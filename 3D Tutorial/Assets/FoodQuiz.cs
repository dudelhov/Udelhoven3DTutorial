using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodQuiz : MonoBehaviour
{
    bool _correctChosen = false;
    [SerializeField] RuntimeData _runtimeData;
    [SerializeField] Dialogue _dialogue;
    [SerializeField] Dialogue _correctChoiceDialogue;
    [SerializeField] Dialogue _incorrectChoiceDialogue;
    [SerializeField] Dialogue _noCorrectChoiceLeftDialogue;

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
        GameEvents.InvokeDialogInitiated(_dialogue);
    }

    public IEnumerator FoodSelected(GameObject food)
    {
        yield return new WaitForEndOfFrame();

        if (!_correctChosen)
        {
            if (food == _correctFood)
            {
                GameEvents.InvokeDialogInitiated(_correctChoiceDialogue);
                _runtimeData.Score++;
                _correctChosen = true;
            }
            else
            {
                GameEvents.InvokeDialogInitiated(_incorrectChoiceDialogue);
                _runtimeData.Score--;
            }
            Destroy(food);
        }
        else
        {
            GameEvents.InvokeDialogInitiated(_noCorrectChoiceLeftDialogue);
        }
    }
}
