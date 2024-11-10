using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;

    public float timer = 0;
    public float spawnRate = 3; 
    
    public float offSet = 90;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate){ // if the timer is less then the spawn rate
            timer = timer + Time.deltaTime; // the timer is up
        } else { 
            spawnPipe(); // spawn the pipe
            timer = 0; // and restart the timer

            spawnRate = 3; 
        }
        
    }

    void spawnPipe(){
        float lowPoint = transform.position.y - offSet; // la posición menos 10 px
        float highPoint = transform.position.y + offSet; // la posición mas 10 px

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowPoint, highPoint), 0), transform.rotation);
    }
}

