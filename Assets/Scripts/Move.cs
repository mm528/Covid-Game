using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject wall;
    public bool hit = false;
    public int counter = 0;
    public float speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "mike" || collision.gameObject.name == "Walls2" )
        {
            Debug.Log("Hit the wall");
            hit = true;
        }
        else
        {
            hit = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (hit == true)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        else
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }

    }
}
