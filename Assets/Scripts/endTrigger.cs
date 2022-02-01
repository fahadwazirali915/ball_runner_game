using UnityEngine;

public class endTrigger : MonoBehaviour
{
    public GameManager gameManager;

    public void OnTriggerEnter(){
        gameManager.CompleteLevel();
    }
}
