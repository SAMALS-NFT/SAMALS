using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMovement : MonoBehaviour
{
    public float t;
    public float movementSpeed = 1.5f;
    public float rotationSpeed = 20f;
    public bool isGrounded = false;

    private bool isWandering = false;
    private bool isRotatingLeft = false;
    private bool isRotatingRight = false;
    private bool isWalking = false;
    public Rigidbody rb;
    public Animator animator;
    float h, v;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        animator.SetBool("walk", true);
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
        // float inputX = 0f;
        // float inputZ = 0.3f;
        // float inputY = rb.transform.localRotation.y;
        
        // Vector3 velocity = new Vector3(inputX, 0, inputZ);
        // velocity *= movementSpeed;
        if(isGrounded)
        {
            if(isWandering == false)
        {
            StartCoroutine(Wander());
        }
        if(isRotatingRight == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * rotationSpeed);
        }
        if(isRotatingLeft == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * rotationSpeed * -1);
        }
        if(isWalking == true)
        {
            animator.SetBool("walk", true);
            rb.velocity = transform.forward * movementSpeed;
        }
        if(isWalking == false)
        {
            animator.SetBool("walk", false);
            rb.velocity = new Vector3(0, 0, 0);
        }
        }

        if(isGrounded == false)
        {
            rb.velocity = new Vector3(0, 1, 0);
        }
        
       

        
    }

    IEnumerator Wander()
    {
        float rotationTime = Random.Range(1.0f, 3.0f);
        float rotateWait = Random.Range(1.0f, 3.0f);
        int rotateDirection = Random.Range(1, 2);
        float walkWait = Random.Range(1.0f, 3.0f);
        float walkTime = Random.Range(1.0f, 3.0f);

        isWandering = true;

        isWalking = true;

        yield return new WaitForSeconds(walkTime);

        isWalking = false;

        yield return new WaitForSeconds(rotateWait);

        isWalking = true;

        if(rotateDirection == 1)
        {
            isRotatingLeft = true;
            yield return new WaitForSeconds(rotationTime);
            isRotatingLeft = false;
        }

        if(rotateDirection == 2)
        {
            isRotatingRight = true;
            yield return new WaitForSeconds(rotationTime);
            isRotatingRight = false;
        }

        isWandering = false;
    }
}
