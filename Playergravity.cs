using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playergravity : MonoBehaviour
{
    // Start is called before the first frame update
    //public string currenMapName; // ChangeScene 스크립트에 있는 transferMapName 변수의 값을 저장
    public float jumpPower;
    Animator animator;
    Collider2D col2D;
    Rigidbody2D rigid2D;
    bool isjump;

    void Start()
    {
        //DontDestroyOnLoad(this.gameObject);
        rigid2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        col2D = GetComponent<Collider2D>();
        transform.position = new Vector3((float)2.5, (float)0.5, 0);
        rigid2D.gravityScale = 4;
    }

    // Update is called once per frame
    void Update()
    {
        //Move
        float h = Input.GetAxis("Horizontal");
        if (h > 0)
            transform.localScale = new Vector3(1, 1, 1);
        else if (h < 0)
            transform.localScale = new Vector3(-1, 1, 1);
        transform.Translate(new Vector3(h * (float)1.5, 0, 0) * Time.deltaTime);
        //Jump
        if (Input.GetKeyDown(KeyCode.Space) && isjump)
            rigid2D.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
    }

    void FixedUpdate()
    {
        //Landing Platfrom
        Debug.DrawRay(rigid2D.position, Vector3.down, new Color(0, 1, 0));
        RaycastHit2D rayHit = Physics2D.Raycast(rigid2D.position, Vector3.down, 1, LayerMask.GetMask("Ground"));

        if(rayHit.collider != null)
        {
            if (rayHit.distance < 0.6f)
                isjump = true;
            else
                isjump = false;
        }
    }
}