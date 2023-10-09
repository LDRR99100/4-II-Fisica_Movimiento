using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script9Fisica : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<Rigidbody>();
        GameObject sphere = GameObject.FindWithTag("sphere");
        GameObject cube = GameObject.FindWithTag("cube");
        cube.transform.position = gameObject.transform.position;
        sphere.transform.position = gameObject.transform.position;      
    }

    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.name == "sphere " || collision.gameObject.name == "Cube") {
        Debug.Log("Ha colisionado el objeto: " + collision.gameObject.name);
        }
    }
}
