using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1Speed : MonoBehaviour
{
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput =  Input.GetAxis("Vertical");
        if(Input.GetKeyDown(KeyCode.UpArrow)) {
            Debug.Log("Flecha arriba: " + speed * verticalInput);
        }   else if(Input.GetKeyDown(KeyCode.DownArrow)) {
                Debug.Log("Flecha abajo: " + speed * verticalInput);
            }   else if(Input.GetKeyDown(KeyCode.LeftArrow)) {
                Debug.Log("Flecha izquierda:" + speed * horizontalInput);
                }   else if(Input.GetKeyDown(KeyCode.RightArrow)) {
                    Debug.Log("Flecha derecha:" + speed * horizontalInput);
                }
    }
}
