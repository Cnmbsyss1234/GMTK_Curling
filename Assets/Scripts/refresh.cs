using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class refresh : MonoBehaviour
{
    public GameObject stones1;
    public GameObject stones2;
    public Transform initialPosition;

    //private GameObject[] player1stones = new GameObject[4];
    //private GameObject[] player2stones = new GameObject[4];

    //private string currentPlayer = "player1";
    //private bool gameOver = false;
    private void Start()
    {

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
                GameObject.Instantiate(stones1, initialPosition);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            GameObject.Instantiate(stones2, initialPosition);
        }
            
        }


    }
