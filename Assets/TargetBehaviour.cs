using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class Target : MonoBehaviour
{
    public float maxHeight = 7.0f;
    public float minHeight = 2.5f;
    public float velocity = 1.5f;

    public int points = 1;
    //public GameObject particles;

    void Start()
    {
        Debug.Log("Something");
    }

    void Update()
    {   
        float range = maxHeight - minHeight;
        float newY = minHeight + Mathf.PingPong(Time.time * velocity, range);
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision!");
        if (collision.gameObject.CompareTag("Grabbable"))
        {
            Debug.Log("Something");
            Destroy(collision.gameObject);
            Destroy(gameObject);

            ScoreManager.Instance.AddScore(points);
        }
    }
    void OnTriggeronEnter(Collider other)
   {
        Debug.Log("Trigger!");
        if (other.gameObject.CompareTag("grabbable")) 
        {
            Debug.Log("Something");
            //Destroy(other.gameObject);
            //Destroy(gameObject);
        }
   }
}
