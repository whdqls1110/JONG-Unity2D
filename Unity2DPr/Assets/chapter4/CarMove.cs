using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    RouletteControll2 roulette;
    // Start is called before the first frame update
    void Start()
    {
        roulette = GameObject.Find("roulette").GetComponent<RouletteControll2>();
    }

    // Update is called once per frame
    void Update()
    {
        if (roulette.move)
        {
            transform.Translate(roulette.resuelt, 0, 0);
            if (roulette.resuelt > 0)
            {
                roulette.move = false;
                roulette.resuelt = 0;
            }
        }
    }
}
