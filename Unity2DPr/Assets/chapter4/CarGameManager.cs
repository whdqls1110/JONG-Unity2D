using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CarGameManager : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distanceText;
    float distance;
    // Start is called before the first frame update
    void Start()
    {
        car = GameObject.Find("car");
        flag = GameObject.Find("flag");
        distanceText = GameObject.Find("Distance");
    }

    // Update is called once per frame
    void Update()
    {
        distance = flag.transform.position.x - car.transform.position.x;
        distanceText.GetComponent<TMP_Text>().text = "Distance : " + distance.ToString("F2");
        if (distance <= 0.5)
        {
            distanceText.GetComponent<TMP_Text>().text = "Win";
            Time.timeScale = 0;
        }
        else if (distance < 0)
        {
            distanceText.GetComponent<TMP_Text>().text = "Loss";
            Time.timeScale = 0;
        }
    }
}
