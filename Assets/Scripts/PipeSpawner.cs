using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public BirdScript bird;
    public GameObject pipe;
    public float spawnRate;
    private float timer = 0;
    public float heightOffSet = 10;
    

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
        bird = GameObject.FindGameObjectWithTag("Player").GetComponent<BirdScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (bird.birdIsAlive == true)
        {
            if (timer < spawnRate)
            {
                timer = timer + Time.deltaTime;
            }
            else
            {
                spawnPipe();
                timer = 0;
            }
        }
    }

    void spawnPipe() {
        float lowestPoint = transform.position.y - heightOffSet;
        float highestPoint = transform.position.y + heightOffSet;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
