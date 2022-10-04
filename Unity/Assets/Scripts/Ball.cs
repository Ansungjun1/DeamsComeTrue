using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var Gameplay = GameObject.Find("Canvas_Play").GetComponent<GamePlay>();
        Gameplay.on_BallCol = true;
        Debug.Log("터치");
    }
}
