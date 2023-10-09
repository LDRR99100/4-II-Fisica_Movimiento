using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script8Movement : MonoBehaviour
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
            transform.Translate(transform.forward.normalized * speed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("down")) {
            transform.Translate(transform.forward.normalized * speed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("left")) {
            transform.Translate(transform.forward.normalized * speed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey("right")) {
            transform.Translate(transform.forward.normalized * speed * Time.deltaTime, Space.World);
        }   
        speed = 10.0F;        
    }
}
