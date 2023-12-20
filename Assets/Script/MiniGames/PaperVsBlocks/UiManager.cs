using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UiManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject child;
    private void Awake()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        Time.timeScale = 1;
    }

    public void Activate()
    {
        child.SetActive(true);
    }
    public void Inactive()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
}
