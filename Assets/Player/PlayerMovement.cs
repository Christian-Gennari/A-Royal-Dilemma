using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    private float horizontalInput;

    public bool facingRight = true;

    public Animator SM_Chr_King_01;

    // Start is called before the first frame update
    void Start()
    {
        SM_Chr_King_01.GetComponent<Animator>();
    }

    // Update is called once per frame

    void Update()
    {



    }

    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if (horizontalInput != 0)
        {
            SM_Chr_King_01.SetBool("isWalking", true);
        }
        else
        {
            SM_Chr_King_01.SetBool("isWalking", false);
        }

        // Flips player
        if ((horizontalInput < 0 && facingRight) || (horizontalInput > 0 && !facingRight))
        {
            facingRight = !facingRight;
            transform.Rotate(new Vector3(0, 180, 0));
        }

        // Moves player
        transform.Translate(transform.right * horizontalInput * Time.deltaTime * speed);
    }
}
