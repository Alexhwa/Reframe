using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interable_objects : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GameDecision = false;
    public GameObject decisionMenuUI;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("h"))
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
    public void Decide()
    {
        GameDecision = false;
        Debug.Log("Bad");
    }
    public void Decide2()
    {
        GameDecision = true;
        Debug.Log("Good");
    }
}
