using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipeScript : MonoBehaviour
{
    public float deadzone = -45;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

               transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x < deadzone) { 
        Destroy(gameObject);
        }
    }

}
