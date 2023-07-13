using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StonesController : MonoBehaviour
{
    public GameObject controller;

    public Vector3 initialPositon;

    private string player;

    public Sprite player1_stones, player2_stones;

    public void Activate()
    {
        controller = GameObject.FindGameObjectWithTag("DragController");

        switch (this.name)
        {
            case "player1_stones1": this.GetComponent<SpriteRenderer>().sprite = player1_stones; break;
            case "player1_stones2": this.GetComponent<SpriteRenderer>().sprite = player1_stones; break;
            case "player1_stones3": this.GetComponent<SpriteRenderer>().sprite = player1_stones; break;
            case "player1_stones4": this.GetComponent<SpriteRenderer>().sprite = player1_stones; break;
            case "player2_stones1": this.GetComponent<SpriteRenderer>().sprite = player2_stones; break;
            case "player2_stones2": this.GetComponent<SpriteRenderer>().sprite = player2_stones; break;
            case "player2_stones3": this.GetComponent<SpriteRenderer>().sprite = player2_stones; break;
            case "player2_stones4": this.GetComponent<SpriteRenderer>().sprite = player2_stones; break;

        }
        this.transform.position = new Vector3(0f, -13f, 0f);

    }
}
