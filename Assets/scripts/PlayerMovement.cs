using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 2f;
    private Rigidbody2D rb;
    private float xInput = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        UserInput();
        Movement();
    }

    private void UserInput()
    {
        xInput = Input.GetAxis("Horizontal");
    }

    private void Movement()
    {
        if (xInput < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        Vector2 tempPos = transform.position;
        tempPos += new Vector2(xInput, 0) * speed * Time.deltaTime;
        rb.MovePosition(tempPos);
    }
}
