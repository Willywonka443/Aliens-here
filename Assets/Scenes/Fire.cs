using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject explosion;
    public Transform bullet;
    private void OnCollisionEnter2D(Collision2D collision)
    {
    
            Destroy(gameObject);
       
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Enemy"){
            Debug.Log("Kill Confirmed");
            Destroy(other.gameObject, 0.10f);
            Instantiate(explosion, bullet.position, transform.rotation = Quaternion.identity);
            Destroy(gameObject);
           
    }
    }
}
