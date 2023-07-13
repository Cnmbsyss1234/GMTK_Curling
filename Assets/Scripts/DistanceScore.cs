using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceScore : MonoBehaviour
{
    public int ScoreValue = 0;

    public int p1 = 0;
    public int p2 = 0;
    public int p3 = 0;
    public int p4 = 0;


    [SerializeField] Transform point1;
    [SerializeField] Transform point2;
    [SerializeField] Transform point3;
    [SerializeField] Transform point4;
    [SerializeField] Transform point5;

    [SerializeField] Text PlayerScore;

    float distance1;
    float distance2;
    float distance3;
    float distance4;

    //bool five;


    private void Start()
    {
        
    }

    void Update()
    {
        distance1 = (point1.transform.position - point5.transform.position).magnitude;
        distance2 = (point2.transform.position - point5.transform.position).magnitude;
        distance3 = (point3.transform.position - point5.transform.position).magnitude;
        distance4 = (point4.transform.position - point5.transform.position).magnitude;

        if (distance1 <= 5.5f && distance1>3.0f)
        {
            p1 = 5;
        }

        else if (distance1 <= 3.0f)
        {
            p1 = 10;
        }



        if (distance2 <= 5.5f && distance2 > 3.0f)
        {
            p2 = 5;
        }

        else if (distance2 <= 3.0f)
        {
            p2 = 10;
        }



        if (distance3 <= 5.5f && distance3 > 3.0f)
        {
            p3 = 5;
        }
        else if (distance3 <= 3.0f)
        {
            p3 = 10;
        }



        if (distance4 <= 5.5f && distance4 > 3.0f)
        {
            p4 = 5;
        }

        else if (distance4 <= 3.0f)
        {
            p4 = 10;
        }




        ScoreValue = p1+p2+p3+p4; 

        PlayerScore.text = "Score:" +ScoreValue;


        //PlayerScore.text = "Score:"+distance.ToString("F1");
    }
}
