using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    int score = 0;
    float time;
    GameObject scoreText;
    GameObject hpGauage;
    // Start is called before the first frame update
    void Start()
    {
        hpGauage = GameObject.Find("hpGauage");
        scoreText = GameObject.Find("Score");
    }
    void Update()
    {
        scoreText.GetComponent<TMP_Text>().text = "Score : " + score.ToString();
        time += Time.deltaTime;
        if (time > 1)
        {
            score++;
            time = 0;
        }
    }
    // Update is called once per frame
    public void DecreaseHP()
    {
        hpGauage.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
