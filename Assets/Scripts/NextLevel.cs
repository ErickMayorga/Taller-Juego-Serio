using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class NextLevel : MonoBehaviour
{
    public Text InstructionText;
    // Start is called before the first frame update
    private void OnTriggerEnter2D( Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if(Score.points==1)
            {
                SceneManager.LoadScene(1);
            }else{
                InstructionText.text = "Tienes que Destruir todas las cajas y ganas puntos";
            }
        }
    }

    // Update is called once per frame
    private void OnTriggerExit2D(Collider2D collision)
    {
        InstructionText.text = "";
    }
}
