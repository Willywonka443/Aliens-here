using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverMenu : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneManager.LoadScene("SampleScene");
    }
    
}
