using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    public TMP_Text blueText;
    public TMP_Text redText;
    public TMP_Text yellowText;

    public int blue=0;
    public int red=0;
    public int yellow=0;
    void Start()
    {
        
    }


    void Update()
    {
        
    }
    public void StickmanBlueTextUp()
    {
        blue++;
        blueText.text = "" + blue;
    }
    public void StickmanRedTextUp()
    {
        red++;
        redText.text = "" + red;
    }
    public void StickmanYellowTextUp()
    {
        yellow++;
        yellowText.text = "" + yellow;
    }
}
