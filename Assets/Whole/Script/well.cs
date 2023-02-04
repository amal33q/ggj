using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class well : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject deadExplosion;
    Rigidbody rb;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void win (){
        Instantiate(deadExplosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
   private void OnTriggerEnter(Collider collision){
        if(collision.tag == "Win" ){
win();            //collision.gameObject.setActive(false);
        }
    }

   // void onTriggerEnter(Collider other){
       // if ( other.gameObject.tag == "Cube"){
            //Destroy(other.gameObject);
       // }
   // }
}
