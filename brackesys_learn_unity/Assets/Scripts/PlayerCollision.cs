using UnityEngine;

public class PlayerCollision : MonoBehaviour{
    public PlayerMovement movement;
    
    void OnCollisionEnter(Collision collisionInfo){
        if(collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("Hit");
            //hareketi devedışı bıraktık
            movement.enabled = false;
            //GetComponent<PlayerMovement>.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            
        }
    }
    
}
