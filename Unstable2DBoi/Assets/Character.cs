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

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float translation = Input.GetAxis("Horizontal") * moveSpeed;
        this.transform.Translate(translation, 0, 0);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0, jumpSize));
        }
    }
}
