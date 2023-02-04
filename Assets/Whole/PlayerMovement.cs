using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    Vector3 moveVector = Vector3.zero;
    public float MovementSpeed = 10;
    public float JumpForce = 10;
    private Rigidbody _rigidbody;
    public GameObject deadExplosion;
    CharacterController CharacterController;
    public float jumpSpeed;
    public float gravity;
    // private Rigidbody2D _rigidbody;
        private float ySpeed;
    private bool isGrounded = true;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        CharacterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        // var movement = Input.GetAxis("Horizontal");
        // transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
        /////////////
        
        //  movement = Input.GetAxis("Vertical");
        // transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        _rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal") * MovementSpeed , _rigidbody.velocity.y, 0);

        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)// && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode.Impulse);
            //isGrounded = false;
        }
        // if(CharacterController.isGrounded && Input.GetButton("Jump")){
        //     moveVector.y = jumpSpeed;
        // }
        // moveVector.y -= gravity * Time.deltaTime;

        
    }


    void dead (){
        Instantiate(deadExplosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

   
   private void OnTriggerEnter(Collider collision){
        if(collision.tag =="Spike" ){
             dead();            //collision.gameObject.setActive(false);
        }
    }
}
