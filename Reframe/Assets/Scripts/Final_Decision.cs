using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Final_Decision : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GameDecision = false;
    public static bool FinalDecision = false;
    public GameObject decisionMenuUI;
    public GameObject doors;
    public GameObject bed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("j"))
        {
            if (GameDecision)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        decisionMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameDecision = false;
    }
    void Pause()
    {
        decisionMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameDecision = true;
    }
    public void Final()
    {
        FinalDecision = false;
        Debug.Log("Bad");
    }
    public void Final2()
    {
        FinalDecision = true;
        Debug.Log("Good");
    }
    public void End()
    {
        if (FinalDecision)
        {
            SceneManager.LoadScene("Good_Ending");
        }
        else
        {
            SceneManager.LoadScene("Bad_Ending");
        }
    }
}
