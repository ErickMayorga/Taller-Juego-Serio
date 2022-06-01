using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 2f;
    public float jumpSpeed = 4f;
    Rigidbody2D body;
    Animator animations;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        animations = GetComponent<Animator>();// invoco al animator
 
    }

    private void FixedUpdate()
    {
        // voy a la izquierda
        if (Input.GetKey("a") || Input.GetKey("left")) {
            body.velocity = new Vector2(-speed, body.velocity.y);
            // cuando este en el ejeX cambio la mirada del personaje si se mueve en -x
            GetComponent<SpriteRenderer>().flipX = true;
            // a mi parámetro run del animator le pongo el valor de  true
            animations.SetBool("Run", true); 

            // voy a la derecha
        } else if (Input.GetKey("d") || Input.GetKey("right"))
        {
            body.velocity = new Vector2(speed, body.velocity.y);
            // como voy a la derecha no es necesario renderizar el eje X
            GetComponent<SpriteRenderer>().flipX = false;
            // a mi parámetro run del animator le pongo el valor de  true
            animations.SetBool("Run", true);

            // no me estoy moviendo en el eje X
        } else {
            // si no hace nada debe estar quieto
            body.velocity = new Vector2(0, body.velocity.y);
            // como no estoy corriendo 
            animations.SetBool("Run", false);
        }
            
        // si esta en el piso y se presiona la barra espaciadora salta
        if (CheckGround.isGrounded && Input.GetKey("space")) {
            // salta
            body.velocity = new Vector2(body.velocity.x, jumpSpeed);
        }
    }
}
