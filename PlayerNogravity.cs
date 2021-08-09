using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNogravity : MonoBehaviour
{
    public static float speed = 1f;

    float h = 0;
    float v = 0;

    BoxCollider2D Box2D;
    Rigidbody2D rigidbd2D;

    // Start is called before the first frame update
    void Start()
    {
        Box2D = GetComponent<BoxCollider2D>();
        rigidbd2D = GetComponent<Rigidbody2D>();
        transform.position = new Vector3((float)2.5, (float)0.5, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        if (h > 0)
            transform.localScale = new Vector3(1, 1, 1);
        else if (h < 0)
            transform.localScale = new Vector3(-1, 1, 1);

        transform.Translate(new Vector3(h * speed, 0, 0) * Time.deltaTime);
        transform.Translate(new Vector3(0, v * speed, 0) * Time.deltaTime);
        //rigidbd2D.velocity = new Vector2(h * speed * 60, 0) * Time.deltaTime;
    }

    void FixedUpdate()
    {   

    }
}