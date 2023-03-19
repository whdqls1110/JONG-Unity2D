using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteControll2 : MonoBehaviour
{
    float strpos;
    float speed = 0;
    float length = 0;
    public bool move = false;
    public int resuelt = 0;
    // Update is called once per frame
    void Update()
    {
        if (speed < 0.01)
        {
            speed = 0;
            if (Input.GetMouseButtonDown(0))
            {
                strpos = Input.mousePosition.x;
            }
            if (Input.GetMouseButtonUp(0))
            {
                float endPos = Input.mousePosition.x;
                length = endPos - strpos;
                speed = length * 0.003f;
                move = true;
            }
        }
        if (speed < 0.01 && move)
        {
            if (transform.rotation.eulerAngles.z + 30 % 360 <= 60)
            {
                resuelt = 2;
            }
            else if (transform.rotation.eulerAngles.z + 30 % 360 <= 120)
            {
                resuelt = 6;
            }
            else if (transform.rotation.eulerAngles.z + 30 % 360 <= 180)
            {
                resuelt = 1;
            }
            else if (transform.rotation.eulerAngles.z + 30 % 360 <= 240)
            {
                resuelt = 4;
            }
            else if (transform.rotation.eulerAngles.z + 30 % 360 <= 300)
            {
                resuelt = 3;
            }
            else
            {
                resuelt = 5;
            }
        }
        transform.Rotate(0, 0, speed);
        speed *= 0.9985f;
    }
}
