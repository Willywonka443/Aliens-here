using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System;

public class Collision : MonoBehaviour
{
    
    public static event Action OnPlayerDeath;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void  OnCollisionEnter2D(Collision2D other) {
        
        if(other.gameObject.tag == "Enemy"){
            Debug.Log("Game Over"); 
            SceneManager.LoadScene("GameOverScreen");
            
            OnPlayerDeath?.Invoke();
        } else{
            Debug.Log("OUCH!!!");
        }
    }

    
}
