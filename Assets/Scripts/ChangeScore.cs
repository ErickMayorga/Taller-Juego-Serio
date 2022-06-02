using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeScore : MonoBehaviour
{

    //public Text textScore;
    // Start is called before the first frame update
    
    // activamos el trigger de la caja 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log(collision.tag);
        if (collision.tag == "Player") {
            GetComponent <SpriteRenderer>().enabled = false;
            gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = true;
            Destroy(gameObject, 0.2f);
        }
    }
}
