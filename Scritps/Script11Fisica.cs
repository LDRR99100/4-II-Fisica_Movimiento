using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script11Fisica : MonoBehaviour
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
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
        gameObject.GetComponent<Rigidbody>().GetComponent<Collider>().isTrigger = true;
        

        sphere.GetComponent<Rigidbody>().MovePosition(gameObject.transform.position);
        cube.GetComponent<Rigidbody>().MovePosition(gameObject.transform.position);         
    }

    void OnTriggerEnter(Collider collider) {
        if(collider.gameObject.name == "Sphere" || collider.gameObject.name == "Cube") {
        Debug.Log("Ha colisionado el objeto: " + collider.gameObject.name);
        }
    }
}
