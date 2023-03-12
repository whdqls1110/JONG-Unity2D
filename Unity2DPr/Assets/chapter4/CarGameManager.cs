using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;

public class CarGameManager : MonoBehaviour
{
    CarController carController;

    GameObject car;
    GameObject flag;
    GameObject distanceText;
    public bool gameEnd = true;
    // Start is called before the first frame update
    void Start()
    {
        car = GameObject.Find("car");
        flag = GameObject.Find("flag");
        distanceText = GameObject.Find("Distance");

        carController=GameObject.Find("car").GetComponent<CarController>();
    }

    // Update is called once per frame
    void Update()
    {
        float length = flag.transform.position.x - car.transform.position.x;
        if (gameEnd)
        {
            distanceText.GetComponent<TMP_Text>().text = "Distance : " + length.ToString("F2") + "m";
        }
        if (carController.speed < 0.001)
        {
            if (length < 0 && gameEnd == true)
            {
                distanceText.GetComponent<TMP_Text>().text = "Lose";
                gameEnd = false;
            }
            else if (length <= 0.5 && gameEnd == true)
            {
                distanceText.GetComponent<TMP_Text>().text = "Win";
                gameEnd = false;
            }
        }
        if (carController.times > 4 && (length > 0.5 || length < 0))
        {
            distanceText.GetComponent<TMP_Text>().text = "Lose";
            gameEnd = false;
        }
    }
}
