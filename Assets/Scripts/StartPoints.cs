using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartPoints : MonoBehaviour
{
    public Text initialScore;
    
    // Start is called before the first frame update
    void Start()
    {
        initialScore.text = Score.points.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
