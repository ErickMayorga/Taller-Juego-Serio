using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EcuationScript : MonoBehaviour
{
    public Text winLabel;
    // Start is called before the first frame update


    private void OnTriggerEnter2D (Collider2D collision) {
        
        if (collision.tag == "Correct") {
            winLabel.text = "Respuesta Correcta";
        }
        if (collision.tag == "Incorrect") {
            winLabel.text = "Respuesta Incorrecta";
        }
    }
    private void OnTriggerExit2D (Collider2D collision) {
        if ( collision.tag == "Incorrect") {
            winLabel.text = "";
        }
    }
}
