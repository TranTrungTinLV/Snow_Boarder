using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float toquerAmount = 1f;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] private float baseSpeed = 20f;
    Rigidbody2D rb2d;

    SurfaceEffector2D surfaceEffector2D;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        RespondBoosts();
    }

    void RespondBoosts()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = boostSpeed;
        }else
        {
            surfaceEffector2D.speed = baseSpeed;
        }
        //if we push up, then speed up 
        // otherwise stay at normal speed
        // access the surfaceEffect2d and change its speed
        
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(toquerAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-toquerAmount);
        }
    }
}
