using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.cyan;
            // Debug.Log("something hit me");
            gameObject.tag = "Hit";
        }
    }    
}
