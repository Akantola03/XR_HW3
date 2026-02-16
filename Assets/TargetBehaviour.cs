using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class Target : MonoBehaviour
{
    public float maxHeight = 5.5f;
    public float minHeight = 2.5f;
    public float duration = 4f;
    public float velocity = 1.0f;
    public Vector3 targetPosition;

    //public GameObject particles;

    void Start()
    {
        //transform.position = new Vector3(-2.5f, 2.6f, 0);
        
    }

    void Update()
    {
        Vector3 temp = transform.position;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, velocity * Time.deltaTime);
        
        /*
        transform.Translate(Vector3.forward * velocity * Time.deltaTime);
        
        
        if (temp.y < maxHeight || temp.y < minHeight) 
        {
            transform.Translate(Vector3.back * velocity * Time.deltaTime);
        }
        transform.position = temp;
        */
    }

    private void OnCollisionEnter(Collision collision)
    {
        //GameObject clone = Instantiate(particles, transform.position, transform.rotation);
        //Destroy(clone.gameObject, 2);

        Destroy(gameObject);
        Destroy(collision.gameObject);
    }
}
