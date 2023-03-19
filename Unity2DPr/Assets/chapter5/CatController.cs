using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    public bool bulink = false;
    bool isOn = false;
    float time;
    int times;
    SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = this.GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {

            transform.Translate(-5f * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(5f * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 5f * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -5f * Time.deltaTime, 0);
        }
        if (bulink)
        {
            time += Time.deltaTime;
            if (time > 0.2f)
            {
                time = 0;
                spriteRenderer.enabled = isOn;
                isOn = !isOn;
                times++;
            }
            if (times > 5)
            {
                bulink = false;
                isOn = false;
                times = 0;
                time = 0;
            }
        }
    }
    public void LButtonDown()
    {
        transform.Translate(-3, 0, 0);
    }
    public void RButtonDown()
    {
        transform.Translate(3, 0, 0);
    }
}
