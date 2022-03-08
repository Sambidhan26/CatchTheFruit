using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatMovement : MonoBehaviour
{
    Rigidbody2D hatRB;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        hatRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");


        if(moveX > 0)
        {
            hatRB.velocity = Vector2.right * speed;
        }
        else if(moveX < 0)
        {
            hatRB.velocity = Vector2.left * speed;
        }
        else
        {
            hatRB.velocity = Vector2.zero;
        }

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -2.5f, 2.5f), transform.position.y);
        
    }
}
