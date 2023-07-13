using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class CEvent : UnityEvent { }
public class DragController : MonoBehaviour
{
    private static GameObject whoWinText, player1MoveText, player2MoveText;
    public static bool gameOver = false;

    public LineRenderer line;

    public Rigidbody2D rb;
    public GameObject stone1;
    public GameObject stone2;
    public GameObject stone3;
    public GameObject stone4;
    public GameObject stone5;
    public GameObject stone6;
    public GameObject stone7;
    public GameObject Target;

    [SerializeField] Text wintext;
    [SerializeField] Text roundnum;

    public int step;

    public float dragLimit = 3f;
    public float forceToAdd = 10f;

    private Camera cam;
    private bool isDragging;

    public DistanceScore score1;
    public DistanceScore score2;

    Vector3 MousePosition
    {
        get
        {
            Vector3 pos = cam.ScreenToWorldPoint(Input.mousePosition);
            pos.z = 0f;
            return pos;

        }
    }


    private void Start()
    {
        whoWinText = GameObject.Find("WhoWinText");
        player1MoveText = GameObject.Find("Player1Move");
        player2MoveText = GameObject.Find("Player2Move");

        whoWinText.SetActive(false);
        player1MoveText.SetActive(true);
        player2MoveText.SetActive(false);

        


        cam = Camera.main;
        line.positionCount = 2;
        line.SetPosition(0, Vector2.zero);
        line.SetPosition(1, Vector2.zero);
        line.enabled = false;
        isDragging = false;
    }

    private void Update()
    {
        if(Input.GetMouseButton(1)&&!isDragging)
        {
            DragStart();
        }

        if(isDragging)
        {
            Drag();
        }

        if(Input.GetMouseButtonUp(1)&&isDragging)
        {
            DragEnd();
            step++;

            if (step == 1)
            {
                rb = Target.GetComponent<Rigidbody2D>();
                player1MoveText.SetActive(false);
                player2MoveText.SetActive(true);
            }

            if (step == 2)
            {

                rb = stone1.GetComponent<Rigidbody2D>();
                //rb = GameObject.Find("Player2Stones(1)").GetComponent<Rigidbody2D>();


            }

            if (step == 3)
            {
                rb = Target.GetComponent<Rigidbody2D>();
                player1MoveText.SetActive(true);
                player2MoveText.SetActive(false);
            }

            if (step == 4)
            {
                rb = stone2.GetComponent<Rigidbody2D>();
                roundnum.text = "Round 2";

            }

            if (step == 5)
            {
                rb = Target.GetComponent<Rigidbody2D>();
                player1MoveText.SetActive(false);
                player2MoveText.SetActive(true);
            }

            if (step == 6)
            {
                rb = stone3.GetComponent<Rigidbody2D>();

            }

            if (step == 7)
            {
                rb = Target.GetComponent<Rigidbody2D>();
                player1MoveText.SetActive(true);
                player2MoveText.SetActive(false);
            }

            if (step == 8)
            {
                rb = stone4.GetComponent<Rigidbody2D>();
                roundnum.text = "Round 3";
            }

            if (step == 9)
            {
                rb = Target.GetComponent<Rigidbody2D>();
                player1MoveText.SetActive(false);
                player2MoveText.SetActive(true);
            }

            if (step == 10)
            {
                rb = stone5.GetComponent<Rigidbody2D>();
            }

            if (step == 11)
            {
                rb = Target.GetComponent<Rigidbody2D>();
                player1MoveText.SetActive(true);
                player2MoveText.SetActive(false);
            }

            if (step == 12)
            {
                rb = stone6.GetComponent<Rigidbody2D>();
                roundnum.text = "Round 4";
            }

            if (step == 13)
            {
                rb = Target.GetComponent<Rigidbody2D>();
                player1MoveText.SetActive(false);
                player2MoveText.SetActive(true);
            }

            if (step == 14)
            {
                rb = stone7.GetComponent<Rigidbody2D>();
            }

            if (step == 15)
            {
                rb = Target.GetComponent<Rigidbody2D>();
                player1MoveText.SetActive(true);
                player2MoveText.SetActive(false);
                
            }

            if (step == 16)
            {
                whoWinText.SetActive(true);
                if (score1.ScoreValue > score2.ScoreValue)
                {
                    wintext.text = "PLAYER1 WIN";
                }
                else if(score1.ScoreValue < score2.ScoreValue)
                {
                    wintext.text = "PLAYER2 WIN";
                }
                else
                {
                    wintext.text = "DRAW";
                }
                //judge who win
                //display end UI
                
            }

        }





    }
    void DragStart()
    {
        line.enabled = true;
        isDragging = true;
        line.SetPosition(0, MousePosition);
    }
    void Drag()
    {
        Vector3 startPos = line.GetPosition(0);
        Vector3 currentPos = MousePosition;

        Vector3 distance = currentPos - startPos;
        
        if(distance.magnitude<=dragLimit)
        {
            line.SetPosition(1, currentPos);
        }
        else
        {
            Vector3 LimitVector = startPos + (distance.normalized * dragLimit);
            line.SetPosition(1, currentPos);
        }

    }

    private void DragEnd()
    {
        isDragging = false;
        line.enabled = false;

        Vector3 startPos = line.GetPosition(0);
        Vector3 currentPos = line.GetPosition(1);

        Vector3 distance = currentPos - startPos;
        Vector3 finalForce = distance * forceToAdd;

        rb.AddForce(finalForce, ForceMode2D.Impulse);

       



    }
}
