using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    float _rotationSpeed = 180f;
    float _dist;
    Transform _camera;

    [SerializeField] GameObject _parentQuiz;

    [SerializeField] RuntimeData _runtimeData;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseEnter()
    {
        _camera = Camera.main.transform;
        _dist = Vector3.Distance(_camera.position, transform.position);

        if (_dist < 2.3)
        {
            transform.Find("Spot Light").gameObject.SetActive(true);
            _runtimeData.CurrentFoodMousedOver = name;
        }
    }

    void OnMouseOver()
    {
        _camera = Camera.main.transform;
        _dist = Vector3.Distance(_camera.position, transform.position);

        if (_dist < 2.3)
        {
            transform.Find("Food Mesh").RotateAround(transform.position, Vector3.up, _rotationSpeed * Time.deltaTime);
        }
    }

    void OnMouseExit()
    {
        _camera = Camera.main.transform;
        _dist = Vector3.Distance(_camera.position, transform.position);

        transform.Find("Spot Light").gameObject.SetActive(false);
        _runtimeData.CurrentFoodMousedOver = "";
    }

    void OnMouseDown()
    {
        if (_runtimeData.CurrentCameplayState == GameplayState.FreeWalk)
        {
            StartCoroutine(_parentQuiz.GetComponent<FoodQuiz>().FoodSelected(gameObject));
            _runtimeData.CurrentFoodMousedOver = "";
        }
    }
}
