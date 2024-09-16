using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{

    private void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float mouseX = mousePosition.x;
        mouseX = Mathf.Clamp(mouseX, -7.5f, 7.5f);
        transform.position = new Vector3(mouseX, -3,-3 );
    }

    void OnTriggerEnter2D(Collider2D collision) 
    {
        print("collided");
    }
}
