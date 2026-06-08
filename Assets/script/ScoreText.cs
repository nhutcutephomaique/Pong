using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI text;
    public void SetScore(int value)
    {
        text.text = value.ToString();
    }


}
