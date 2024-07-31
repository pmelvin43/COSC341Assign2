using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChangingScript : MonoBehaviour
{

    SpriteRenderer _spriteRenderer;
    public int score = 0;

    public InputHandler inputHandler;
    public dataLoggerScript dataLoggerScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeColor(GameObject g)
    {
        if (g.name == "background")
        {
            dataLoggerScript.wrong = 1;
        }

        dataLoggerScript.WriteCSV();

        _spriteRenderer = g.GetComponent<SpriteRenderer>();

        _spriteRenderer.color = new Color(1f, 0f, 0f, 1f);
    }
}
