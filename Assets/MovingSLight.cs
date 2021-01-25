using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSLight : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Fire1") * Time.deltaTime * speed;
        float vertical = Input.GetAxis("Fire2") * Time.deltaTime * speed;
        float third = Input.GetAxis("Fire3") * Time.deltaTime * speed;

        transform.Translate(horizontal, third, vertical);
    }
}
