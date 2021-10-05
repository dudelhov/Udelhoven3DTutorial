using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreLabel : MonoBehaviour
{
    [SerializeField] RuntimeData _runtimeData;
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = "Score: " + _runtimeData.Score;
    }
}
