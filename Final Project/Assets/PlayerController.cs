using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    //bool jump = false;

    Vector2 move;
    //public LayerMask ground;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        /*var feet = new Vector2(transform.position.x, transform.position.y - 0.5f);
        var box = new Vector2(0.8f, 0.2f);
        var grounded = Physics2D.OverlapBox(feet, box, 0, ground);*/

        move.x = Input.GetAxis("Horizontal");
        move.y = Input.GetAxis("Vertical");

        /*if (Input.GetButtonDown("Jump") && grounded)
        {
            jump = true;
        }*/

        if (move.x > 0)
        {
            gameObject.transform.localScale = new Vector3(1, 1, 1);
        }

        else if (move.x < 0)
        {
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }

    }

    void FixedUpdate()
    {
        rb.AddForce(move * 6);

        /*if (jump)
        {
            jump = false;
            rb.AddForce(transform.up * 7, ForceMode2D.Impulse);
        }*/

    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        /*if (collision.tag == "Diamond")
        {

            Destroy(collision.gameObject);
            GameData.points++;

        }*/
    }

}