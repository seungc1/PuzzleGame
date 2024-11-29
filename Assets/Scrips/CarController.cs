using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    
    float speed = 0;
    Vector2 startPos;

    void Update()
    {
        if(Input.GetMouseButtonDown(0)) {
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0)) {
            Vector2 endPos = Input.mousePosition;
            float swipeLenght = endPos.x - startPos.x;

            this.speed = swipeLenght / 500f;

            GetComponent<AudioSource>().Play();
        }

        transform.Translate(this.speed, 0f, 0f);
        this.speed *= 0.98f;
    }
}
