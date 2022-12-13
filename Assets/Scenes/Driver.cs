using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
   
    [SerializeField] float currentSpeed = 0.01f;
    public Weapon weapon1;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float speedAmount = Input.GetAxis("Horizontal") * Time.deltaTime;
        
        transform.Translate(speedAmount * currentSpeed, 0,0);
        
        if(Input.GetKeyDown("space"))
        {
            weapon1.Fire();

        }
    }
}
