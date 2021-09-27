using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameHolder : MonoBehaviour
{
    private string playerName;
    public Text playerNameBox;
    // Start is called before the first frame update
    void Start()
    {
        playerName = FindObjectOfType<Manager>().playerName;
        playerNameBox.text = playerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
