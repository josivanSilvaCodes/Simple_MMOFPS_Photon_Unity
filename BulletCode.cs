using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCode : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 20;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.forward * speed;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            GameObject objplayer = collision.gameObject;
            objplayer.GetComponent<PlayerControllerAndCam>().lifebar -= 5;

            Debug.Log("life: " + objplayer.GetComponent<PlayerControllerAndCam>().lifebar);
        }
    }


}
