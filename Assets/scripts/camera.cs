
using UnityEngine;

public class camera : MonoBehaviour
{


    public Transform player;
    public Vector3 poistion;
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + poistion;
    }
}
