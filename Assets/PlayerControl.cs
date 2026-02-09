using UnityEngine;
using UnityEngine.InputSystem;



public class PlayerControls : MonoBehaviour
{
    //define the player variables like the rigidbody2d and move speed
  

    [SerializeField] public float moveSpeed = 5;
    Rigidbody2D rb2d;
    public Sprite moveSprite;
    private Rigidbody2D body;
    private bool FPressed = false;
    private Animator anim;
    InputAction move;
    private bool isMovingDiagonolly;
    private bool isMovingUpandDown;

    
    private void Start()
    {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();   
        //call the anim and rdb2d 
    }
     private void OnMove(InputValue value)//creaats a function only called once of the value on the input
    {
        
        
        Vector2 v = value.Get<Vector2>();
       //gets the value from the player input as a vector2
        rb2d.linearVelocity = v * moveSpeed;
        
        
        //sets the rigidbody2d velocity to the vector2 value multipled by the move


        
        //player can only move in one direction using a bool and mutipling the vector2 values
        
        

        
    }




    
        
        
        /*
           1.Arrow keys or WASD to control chatter to move horizontally NOT diagonally. Can only move one direction at a time.   
           2. if player presses F they initiate a talk to another npc. this is from the other code script 
           


        */
   
    
        
    
}
