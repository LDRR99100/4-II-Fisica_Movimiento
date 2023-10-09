using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script2Cube : MonoBehaviour
{
    public Vector3 moveDirection = new Vector3(1.0f, 2.0f, 1.5f);
    public float speed = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
     gameObject.GetComponent<Transform>().position = new Vector3(gameObject.transform.position[0], 0.0f, gameObject.transform.position[2]);   
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(moveDirection * Time.deltaTime * speed);
    }
}
