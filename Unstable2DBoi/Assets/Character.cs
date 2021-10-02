using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float jumpSize = 3f;
    public float unstabilityTime = 20f;
    public float unstabilityVariation = 10f;

    public Rigidbody2D rb;

    public bool canJump = false;

    public Transform cameraTransform;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float translation = Input.GetAxis("Horizontal") * moveSpeed;
        this.transform.Translate(translation, 0, 0);
        rb.AddTorque(-translation);

        if(Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            rb.AddForce(new Vector2(0, jumpSize));
        }

        if(Vector2.Distance(new Vector2(transform.position.x, transform.position.y),
            new Vector2(cameraTransform.position.x, cameraTransform.position.y)) > 10)
        {
            cameraTransform.position = cameraTransform.position += new Vector3(18, 0, 0);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "wall")
        {
            canJump = true;
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            canJump = false;
        }
    }
}
