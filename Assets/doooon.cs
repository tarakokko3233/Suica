using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doooon : MonoBehaviour
{
    public GameObject circle1;
    public GameObject circle2;
    public GameObject circle3;
    public GameObject circle4;
    public Rigidbody2D circle1_g;
    public Rigidbody2D circle2_g;
    public Rigidbody2D circle3_g;
    public Rigidbody2D circle4_g;

    void Update()
    {
        if (transform.position.y > 8.0f)
        {
            ApplyGravityScale(-1);
        }
        if(transform.position.y > 20.0f)
        {
            ApplyDestroy();
        }
    }

    void ApplyGravityScale(float scale)
    {
        circle1_g.gravityScale = scale;
        circle2_g.gravityScale = scale;
        circle3_g.gravityScale = scale;
        circle4_g.gravityScale = scale;
    }

    void ApplyDestroy()
    {
        Destroy(circle1);
        Destroy(circle2);
        Destroy(circle3);
        Destroy(circle4);
    }
}
