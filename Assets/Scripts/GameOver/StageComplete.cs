using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageComplete : MonoBehaviour
{
    // Start is called before the first frame update
    public void Activate()
    {
        gameObject.SetActive(true);
    }

    public void Retry()
    {
        SceneManager.LoadScene("Game");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
