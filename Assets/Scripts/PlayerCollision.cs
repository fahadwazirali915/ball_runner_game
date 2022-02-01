using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public playerMovement moveplayer;

    void OnCollisionEnter(Collision CollisionInfo)
    {
        if(CollisionInfo.collider.tag == "Object"){
            
            moveplayer.enabled = false;
            FindObjectOfType<GameManager>().endGame();

        }
        
    }

}
