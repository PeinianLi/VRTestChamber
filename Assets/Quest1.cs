using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Quest1 : MonoBehaviour
{
    public TextMeshProUGUI text;
    
    public void OnComplete()
    {
        text.text = "Quest1 Completed!";
    }
}
