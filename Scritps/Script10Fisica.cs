using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script10Fisica : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject sphere = GameObject.FindWithTag("sphere");
        GameObject cube = GameObject.FindWithTag("cube");

        gameObject.AddComponent<Rigidbody>();
        cube.AddComponent<Rigidbody>();
        sphere.AddComponent<Rigidbody>();
        sphere.GetComponent<Rigidbody>().isKinematic = true;
        
        sphere.GetComponent<Rigidbody>().MovePosition(gameObject.transform.position);
        cube.GetComponent<Rigidbody>().MovePosition(gameObject.transform.position);

    }

    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.name == "Cube" || collision.gameObject.name == "Sphere") {
        Debug.Log("Ha colisionado el objeto: " + collision.gameObject.name);
        }
    }
}
