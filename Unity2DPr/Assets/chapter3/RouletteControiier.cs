using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteControiier : MonoBehaviour
{
    float rotSpeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            rotSpeed = 10;
        }
        rotSpeed *= 0.995f;
        transform.Rotate(0, 0, rotSpeed);//회전속도만큼 룰렛 회전
        if (rotSpeed < 0.01f)
        {
            if(transform.rotation.eulerAngles.z > -30 && transform.rotation.eulerAngles.z < 30)
            {
                Debug.Log("운수 나쁨");
            }
            else if (transform.rotation.eulerAngles.z < 90)
            {
                Debug.Log("운수 대통");
            }
            else if (transform.rotation.eulerAngles.z < 150)
            {
                Debug.Log("운수 매우나쁨");
            }
            else if (transform.rotation.eulerAngles.z < 210)
            {
                Debug.Log("운수 보통");
            }
            else if (transform.rotation.eulerAngles.z < 270)
            {
                Debug.Log("운수 조심");
            }
            else if(transform.rotation.eulerAngles.z < 330)
            {
                Debug.Log("운수 좋음");
            }
        }
    }
}
