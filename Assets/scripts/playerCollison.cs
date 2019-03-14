
using UnityEngine;

public class playerCollison : MonoBehaviour
{

    public player movement;
    void OnCollisionEnter(Collision collisionInfo) {

        if (collisionInfo.collider.tag == "babojodo")
        {

            movement.enabled = false;
        
        }

       

    }
}
