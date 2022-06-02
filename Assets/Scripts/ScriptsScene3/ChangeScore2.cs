using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeScore2 : MonoBehaviour
{

    public Text textScore;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Correct") {
            Score.winLevel = true;
            Score.points = Score.points + (4 - Score.numWrong);
            textScore.text = Score.points.ToString(); // obtenga el puntaje
        }

        if (collision.tag == "Incorrect") {
            Score.numWrong = Score.numWrong + 1;
        }
    }
}
