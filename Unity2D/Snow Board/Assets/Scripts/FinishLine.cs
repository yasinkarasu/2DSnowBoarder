using UnityEngine;

public class FinishLine : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
            Debug.Log("You Finished!");
        }
    }
}
