using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    float _rotationSpeed = 180f;
    
    public static string CurrentFoodMousedOver;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseEnter()
    {
        transform.Find("Spot Light").gameObject.SetActive(true);
        CurrentFoodMousedOver = name;
    }

    void OnMouseOver()
    {
        transform.Find("Food Mesh").Rotate(Vector3.up, _rotationSpeed * Time.deltaTime);
    }

    void OnMouseExit()
    {
        transform.Find("Spot Light").gameObject.SetActive(false);
        CurrentFoodMousedOver = "";
    }
}
