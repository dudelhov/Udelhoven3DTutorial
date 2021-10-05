using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initializer : MonoBehaviour
{

    [SerializeField] RuntimeData _runtimeData;
    [SerializeField] Dialogue _startingDialogue;
    // Start is called before the first frame update
    void Awake()
    {
        _runtimeData.CurrentFoodMousedOver = "";
        _runtimeData.CurrentCameplayState = GameplayState.InDialog;
        _runtimeData.Score = 0;
    }
    void Start()
    {
        GameEvents.InvokeDialogInitiated(_startingDialogue);
    }
}
