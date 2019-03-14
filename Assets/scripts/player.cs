
using UnityEngine;

public class player : MonoBehaviour {
    public Rigidbody rb;

    // Start is called before the first frame update

    public float forwardForse = 2000f;
    public float sideWayForse = 500f;
    // Update is called once per frame
    void FixedUpdate()
    {
       
        rb.AddForce(0, 0, forwardForse * Time.deltaTime);
        
        if ( Input.GetKey("d"))
        {
            rb.AddForce(sideWayForse * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideWayForse * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
       
        }
    }
}
