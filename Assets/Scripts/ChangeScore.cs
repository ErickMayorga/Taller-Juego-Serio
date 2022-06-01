using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeScore : MonoBehaviour
{

    public Text textScore;
    // Start is called before the first frame update
    
    // activamos el trigger de la caja 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // si la colisión es  con el jugador
        if (collision.tag == "Player") {
            Score.points = Score.points + 1;
            textScore.text = Score.points.ToString(); // obtenga el puntaje
            GetComponent <SpriteRenderer>().enabled = false;
            gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = true;
            Destroy(gameObject, 0.2f);

        }
    }
}
