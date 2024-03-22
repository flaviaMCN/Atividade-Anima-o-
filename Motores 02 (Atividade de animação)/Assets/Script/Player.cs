using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rig;

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rig.velocity = Vector2.right * speed;
            anim.SetBool("EstaCorrendo", true);
            transform.eulerAngles = new Vector2(0f, 0f);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rig.velocity = Vector2.left * speed;
            anim.SetBool("EstaCorrendo", true);
            transform.eulerAngles = new Vector2(0f, 180f);
        }
        else
        {
            anim.SetBool("EstaCorrendo", false);
        }
        

    }
}
