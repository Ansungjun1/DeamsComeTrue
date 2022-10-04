using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject target;
    private float moveSpeed;
    private Vector3 targetPosition;

    void Awake()
    {
        target = GameObject.Find("Ball");
    }

    void Start()
    {
        moveSpeed = 5.0f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        targetPosition.Set(target.transform.position.x, target.transform.position.y, this.transform.position.z);

        this.transform.position = Vector3.Lerp(this.transform.position, targetPosition, moveSpeed * Time.deltaTime);
    }
}
