using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script7Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    public float speed = 1.0F;
    private Vector3 direction;
    // Update is called once per frame
    void Update()
    {   
        GameObject sphere = GameObject.FindWithTag("sphere");
        direction = sphere.transform.position - gameObject.transform.position;

        if (Input.GetKey("up")) {
            transform.LookAt(sphere.transform);
            transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("down")) {
            transform.LookAt(sphere.transform);
            transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("left")) {
            transform.LookAt(sphere.transform);
            transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("right")) {
            transform.LookAt(sphere.transform);
            transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
        }   
        speed = 5.0F;
    }
}
