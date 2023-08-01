using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rtan : MonoBehaviour
{
    float direction = 0.05f;
    float toward = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 theScale = transform.localScale;

        if (Input.GetMouseButtonDown(0))
        {
            theScale.x *= -1;
            direction *= -1;
        }

        if (transform.position.x > 2.8f)
        {
            direction = -0.05f;
            theScale.x *= -toward;
        }
        if (transform.position.x < -2.8f)
        {
            direction = 0.05f;
            theScale.x *= -toward;
        }
        transform.position += new Vector3(direction, 0, 0);
        transform.localScale = theScale;
    }
}
