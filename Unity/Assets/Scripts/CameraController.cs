using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(500.0f, 150.0f, 500.0f);
    }

    // Update is called once per frame
    void Update()
    {
        moveObjectFunc();    
    }

    private float speed_move = 10.0f;
    private float speed_rota = 2.0f;

    void moveObjectFunc()
    {
        float keyH = Input.GetAxis("Horizontal");
        float keyV = Input.GetAxis("Vertical");
        keyH = keyH * speed_move * Time.deltaTime;
        keyV = keyV * speed_move * Time.deltaTime;
        transform.Translate(Vector3.right * keyH);
        transform.Translate(Vector3.forward * keyV);

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        transform.Rotate(Vector3.up * speed_rota * mouseX);
        transform.Rotate(Vector3.left * speed_rota * mouseY);
    }
}
