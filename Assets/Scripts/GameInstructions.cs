using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInstructions : MonoBehaviour
{
    public string message = "Use W, A, S, D to control the character. Go through the maze and collect the key!";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(message);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
