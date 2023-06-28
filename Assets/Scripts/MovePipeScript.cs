using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipeScript : MonoBehaviour
{
    public BirdScript bird;
    public float deadzone = -45;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        bird = GameObject.FindGameObjectWithTag("Player").GetComponent<BirdScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (bird.birdIsAlive == true)
        {
            transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        }

        if (transform.position.x < deadzone) { 
        Destroy(gameObject);
        }
    }

}
