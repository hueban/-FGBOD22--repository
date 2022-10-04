using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class textScript : MonoBehaviour
{
    private TextMesh text;
    public void changeText(string textToAdd)
    {
        text.text = textToAdd;
    }
    private void Start()
    {
        text= GetComponent<TextMesh>();
    }
}
