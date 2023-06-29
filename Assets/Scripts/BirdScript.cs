using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public float gravity;
    public Transform myTransform;
    public float lowerBound;
    public float upperBound;
    public LogicScript logic;
    public bool birdIsAlive = true;
    

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        OutOfBounds();
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
    }

    private void OutOfBounds() {
        if (myTransform.position.y <= lowerBound || myTransform.position.y >= upperBound) {
            logic.gameOver();
            birdIsDead();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<AudioManager>().play("PipeCollision");
        logic.gameOver();
        birdIsDead();
    }

    private void birdIsDead() {
        birdIsAlive = false;
        myRigidbody.gravityScale = gravity;
    }
}
