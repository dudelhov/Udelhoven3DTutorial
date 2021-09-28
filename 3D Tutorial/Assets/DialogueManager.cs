using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class DialogueManager : MonoBehaviour
{
    Dialogue _currentDialogue;
    int _currentSlideIndex = 0;
    [SerializeField] RuntimeData _runtimeData;

    void Awake()
    {
        GameEvents.DialogFinished += OnDialogFinished;
        GameEvents.DialogInitiated += OnDialogInitiated;
    }
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_currentSlideIndex < _currentDialogue.DialogSlides.Length - 1)
            {
                _currentSlideIndex++;
                ShowSlide();
            }
            else
            {
                GameEvents.InvokeDialogFinished();
            }
        }
    }

    void OnDialogInitiated(object sender, DialogueEventArgs args)
    {
        _currentDialogue = args.dialoguePayload;
        _currentSlideIndex = 0;
        ShowSlide();
        ShowAvatar();
        GetComponent<Canvas>().enabled = true;
        _runtimeData.CurrentCameplayState = GameplayState.InDialog;
    }
    void OnDialogFinished(object sender, EventArgs args)
    {
        GetComponent<Canvas>().enabled = false;
        _runtimeData.CurrentCameplayState = GameplayState.FreeWalk;
    }

    void ShowSlide()
    {
        GameObject textObj = transform.Find("DialogText").gameObject;
        TextMeshProUGUI textComponent = textObj.GetComponent<TextMeshProUGUI>();
        textComponent.text = _currentDialogue.DialogSlides[_currentSlideIndex];
    }

    void ShowAvatar()
    {
        GameObject avatarObj = transform.Find("Avatar").gameObject;
        avatarObj.GetComponent<RawImage>().texture = _currentDialogue.NPCAvatar;
    }
}
