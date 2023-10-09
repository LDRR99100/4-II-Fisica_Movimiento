using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scritp4Movement : MonoBehaviour
{
    public float speed = 1.0F;
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
    float Ytranslation = Input.GetAxis("Vertical") * speed;
    float Xtranslation = Input.GetAxis("Horizontal") * speed;
    Ytranslation *= Time.deltaTime;
    Xtranslation *= Time.deltaTime;
    if (Input.GetKey("up")) {
    transform.Translate(0, 0, Ytranslation);
    }
    if (Input.GetKey("down")) {
      transform.Translate(0, 0, Ytranslation);
    }
    if (Input.GetKey("left")) {
      transform.Translate(Xtranslation, 0, 0);
    }
    if (Input.GetKey("right")) {
      transform.Translate(Xtranslation, 0, 0);
    }
    speed = 5.0f;
    }
}
