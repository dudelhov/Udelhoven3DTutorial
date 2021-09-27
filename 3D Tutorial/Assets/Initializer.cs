using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initializer : MonoBehaviour
{

    [SerializeField] RuntimeData _runtimeData;
    // Start is called before the first frame update
    void Awake()
    {
        _runtimeData.CurrentFoodMousedOver = "";
        _runtimeData.CurrentCameplayState = GameplayState.InDialog;
    }
}
