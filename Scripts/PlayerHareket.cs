using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHaraket : MonoBehaviour
{
    public float hiz;

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-hiz*Time.deltaTime,0f,0f);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(hiz*Time.deltaTime,0f,0f);
        }
    }
}
