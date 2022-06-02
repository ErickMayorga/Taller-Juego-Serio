using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EcuationScript : MonoBehaviour
{
    public Text winLabel;
    public AudioSource winSound;
    public AudioSource wrongSound;
    // Start is called before the first frame update


    private void OnTriggerEnter2D (Collider2D collision) {
        if (collision.tag == "Correct") {
            winLabel.text = "Respuesta Correcta";
            winSound.Play();
        }
        if (collision.tag == "Incorrect") {
            winLabel.text = "Respuesta Incorrecta";
            wrongSound.Play();
        }
    }

    private void OnTriggerExit2D (Collider2D collision) {
        if (collision.tag == "Incorrect") {
            winLabel.text = "";
        }
    }
}
