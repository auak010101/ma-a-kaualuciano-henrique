using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maça : MonoBehaviour
{
   float bottomY = -6f;

    private void Update()
    {
        if (transform.position.y < bottomY) 
        {
            Destroy(gameObject);
        }
    }
}
