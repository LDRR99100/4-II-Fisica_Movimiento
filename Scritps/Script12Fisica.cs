using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script12Fisica : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        rbc = gameObject.AddComponent<Rigidbody>();
        rbc.constraints = RigidbodyConstraints.FreezeRotation;
        GameObject sphere = GameObject.FindWithTag("sphere");
        rbs = sphere.AddComponent<Rigidbody>();
        rbc.mass = 1;
        rbs.mass = 1;
        rbc.drag = rbc.drag * 2;
    }
    public float speed;
    public Vector3 InputCollector;
    public Rigidbody rbc;
    public Rigidbody rbs;
    public GameObject sphere;
    // Update is called once per frame
    void Update()
    {
        InputCollector = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }
    void FixedUpdate()
    {
        rbc.AddForce(InputCollector * 15);
    }
}        

