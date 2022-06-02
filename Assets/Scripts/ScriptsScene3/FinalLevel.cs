using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class FinalLevel : MonoBehaviour
{
    public Text InstructionText;
    // Start is called before the first frame update
    private void OnTriggerEnter2D( Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if(Score.winLevel)
            {
                SceneManager.LoadScene(3);
            }else{
                InstructionText.text = "Tienes que destruir la caja correcta para ganar";
            }
        }
    }

    // Update is called once per frame
    private void OnTriggerExit2D(Collider2D collision)
    {
        InstructionText.text = "";
    }
}
