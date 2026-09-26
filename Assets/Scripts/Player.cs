using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Vector2 moveDir;
    [SerializeField] float moveSpeed;
    
    void Update()
    {
        Move();
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.W)) moveDir.y = 1;
        else if (Input.GetKey(KeyCode.S)) moveDir.y = -1;
        else moveDir.y = 0;
        if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.S)) moveDir.y = 0;

        if (Input.GetKey(KeyCode.A)) moveDir.x = -1;
        else if (Input.GetKey(KeyCode.D)) moveDir.x = 1;
        else moveDir.x = 0;
        if(Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D)) moveDir.x = 0;
        transform.Translate(moveDir *  moveSpeed * Time.deltaTime);
    }
}
