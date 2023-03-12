using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    CarGameManager carGameManager;

    bool gamemove = true;

    public int times = 0;
    public float speed = 0;
    Vector2 startPos;
    void Start()
    {
        carGameManager = GameObject.Find("Main Camera").GetComponent<CarGameManager>();
    }
    // Update is called once per frame
    void Update()
    {
        if (gamemove)
        {
            if (Input.GetMouseButtonDown(0))
            {
                startPos = Input.mousePosition;
            }
            else if (Input.GetMouseButtonUp(0))
            {
                if (speed < 0.001)
                {
                    Vector2 endPos = Input.mousePosition;
                    float swichPos = endPos.x - startPos.x;
                    speed = swichPos / 1000f;
                    GetComponent<AudioSource>().Play();
                    times++;
                }
            }
        }
        transform.Translate(speed, 0, 0);
        speed *= 0.98f;
        if (times > 4||carGameManager.gameEnd==false)
        {
            gamemove = false;
        }
    }
}
