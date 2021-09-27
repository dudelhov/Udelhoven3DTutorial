using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] Dialogue _currentDialogue;
    int _currentSlideIndex = 0;
    [SerializeField] RuntimeData _runtimeData;

    // Start is called before the first frame update
    void Start()
    {
        ShowSlide();
        ShowAvatar();
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
                GetComponent<Canvas>().enabled = false;
                _runtimeData.CurrentCameplayState = GameplayState.FreeWalk;
            }
        }
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
