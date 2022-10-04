using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlay : MonoBehaviour
{
    private GameObject Stick;
    private float speed = 0.0f;

    private GameObject Ball;
    private Vector2 BallPosition;

    private bool on_StickRotate = false;
    private bool on_BallShoot = false;
    public bool on_BallCol = false;

    void Awake()
    {
        Stick = GameObject.Find("Stick_move");
        Ball = GameObject.Find("Ball");
    }

    void Start()
    {

    }

    void FixedUpdate()
    {
        if (on_StickRotate)
        {
            if (speed >= 100)
                speed -= speed / 400;

            Stick.transform.Rotate(0.0f, 0.0f, speed * Time.deltaTime);
            Ball.transform.Rotate(0.0f, 0.0f, speed * Time.deltaTime);
        }

        else if (on_BallShoot)
        {
            if (speed >= 50)
            {
                speed -= speed / 80;

                Ball.transform.Translate(Vector3.right * speed/1000 * Time.deltaTime);
            }
        }
    }

    public void Left_SpeedUp_Button()
    {
        if (speed < 2000.0f)
            speed += 100.0f;
        else
            Debug.Log("속도 끝");
    }

    public void Right_Shoot_Button()
    {
        on_StickRotate = false;
        on_BallShoot = true;
    }


    public void Start_button()
    {
        on_StickRotate = true;
        on_BallShoot = false;
    }
}
