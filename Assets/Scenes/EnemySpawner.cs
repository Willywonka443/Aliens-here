using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemyToSpawn;
    
    public int count = 0;
    public float timeToSpawn;
    private bool hasReached;
    private float currentTimeToSpawn;
    private bool spawn;



    // Start is called before the first frame update
    void Start()
    {
       hasReached = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentTimeToSpawn > 0)
        {
            currentTimeToSpawn -= Time.deltaTime;
            
        }
        else if ( hasReached == false)
        {
            SpawnObject();
            currentTimeToSpawn = timeToSpawn;
            spawn = true;
            count++;
            
        }
    }

    public void SpawnObject()
    {
        Instantiate(enemyToSpawn, transform.position, transform.rotation);
       
        if(count == 9 && spawn == true){
            hasReached = true;
            StopSpawning();
        }
    }
    public void StopSpawning()
      {
          spawn = false;
      }
    
}
