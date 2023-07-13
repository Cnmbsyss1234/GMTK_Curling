using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Round : MonoBehaviour
{
    public GameObject stone1;
    public GameObject stone2;
    public GameObject stone3;
    public GameObject stone4;
    public GameObject stone5;
    public GameObject stone6;
    public GameObject stone7;
    public GameObject Target;

    public Rigidbody2D rb;


    public int step;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(1))
        {
            DragEnd();
        }
        //GameObject.Find("DragController)").GetComponent<DragController>();
        //stone1.SetActive(true);
        //GameObject.Find("Player2Stones(1)").GetComponent<DragController>().enabled = true;
    }
    private void DragEnd()
    {

        step++;
        if (step == 2)
        {
           stone1.SetActive(true);
        }

        if (step == 4)
        {
            stone2.SetActive(true);
        }

        if (step == 6)
        {
            stone3.SetActive(true);
        }

        if (step == 8)
        {
            stone4.SetActive(true);
        }

        if (step == 10)
        {
            stone5.SetActive(true);
        }

        if (step == 12)
        {
            stone6.SetActive(true);
        }

        if (step == 14)
        {
            stone7.SetActive(true);
        }
    }
}
