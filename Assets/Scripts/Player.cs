using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Joystick inputStick;
    private float horizontal;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //   horizontal = inputStick.Horizontal;

        horizontal = inputStick.Horizontal;

        //   horizontal = Input.GetAxis("Horizontal");
        horizontal *= speed * Time.deltaTime;

        transform.Translate(new Vector3(horizontal, 0f, 0f));
    }
}
