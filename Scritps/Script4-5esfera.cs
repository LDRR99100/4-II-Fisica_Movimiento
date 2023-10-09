using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script345Movement : MonoBehaviour
{
   public float speed = 1.0f;

    // Update is called once per frame
    void Update()
    {
    float Ytranslation = Input.GetAxis("Vertical") * speed;
    float Xtranslation = Input.GetAxis("Horizontal") * speed;
    Ytranslation *= Time.deltaTime;
    Xtranslation *= Time.deltaTime;
    if (Input.GetKey("w")) {
    transform.Translate(0, 0, Ytranslation);
    }
    if (Input.GetKey("s")) {
      transform.Translate(0, 0, Ytranslation);
    }
    if (Input.GetKey("a")) {
      transform.Translate(Xtranslation, 0, 0);
    }
    if (Input.GetKey("d")) {
      transform.Translate(Xtranslation, 0, 0);
    }
    speed = 5.0f;
    }

}
