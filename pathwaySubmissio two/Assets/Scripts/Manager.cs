using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    private static Manager instance;
    public string playerName;
    public InputField inputName;
    private void Awake()
    {
        if (instance!=null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(gameObject);
    }
    public void SaveName()
    {
        playerName = inputName.text;
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }



}
