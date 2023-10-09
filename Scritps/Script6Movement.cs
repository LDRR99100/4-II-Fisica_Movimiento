using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script6Movement : MonoBehaviour
{
    public float speed = 1.0F;
    private Vector3 direction;
    // Update is called once per frame
    void Start()
    {
    }
    void Update()
    {
       GameObject sphere = GameObject.FindWithTag("sphere");
       direction = sphere.transform.position - gameObject.transform.position;
        if (Input.GetKey("up")) {
            transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("down")) {
            transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("left")) {
            transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("right")) {
            transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
        }
        speed = 1.0F;
    }
}

