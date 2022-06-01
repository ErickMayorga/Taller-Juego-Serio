using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    public static bool isGrounded;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D colision)
    {
        isGrounded = true;
    }
    private void OnTriggerExit2D(Collider2D colision)
    {
        isGrounded = false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
