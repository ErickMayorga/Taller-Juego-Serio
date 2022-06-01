using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    public static bool isGrounded;
    // Start is called before the first frame update

    // ver si esta colisionando en el piso
    private void OnTriggerEnter2D( Collider2D collision )
    {
        isGrounded = true;
        
    }
    // regrese falso si no esta colisionando en el piso
    private void OnTriggerExit2D( Collider2D collision )
    {
        isGrounded = false;
    }
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
