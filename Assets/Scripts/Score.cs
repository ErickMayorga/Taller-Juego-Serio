using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    // aqui se guarda el puntaje
    public static int points = 0;

    // aqui se guarda cuantas cajas ha roto antes de romper la correcta
    public static int numBoxes = 0;

    // aqui se guarda si se rompió la caja correcta
    public static bool winLevel = false;

    // aqui se guarda el nivel actual
    public static int currentLevel = 1;

}
