using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CONTROLS : MonoBehaviour
{
    float Rotation = 80f;
    float Displacement = 8f;
    float Boost = 15f;
    float Bump = 3f;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "BOOST")
        {
            Displacement = Boost;
        }
        if (other.tag == "BUMP")
        {
            Displacement = Bump;
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        Displacement = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        float TurningSpeed = Input.GetAxis("Horizontal") * Rotation * Time.deltaTime;
        float Movement = Input.GetAxis("Vertical") * Displacement * Time.deltaTime;
        transform.Rotate(0, 0, -TurningSpeed);
        transform.Translate(0, Movement, 0);

    }
}
