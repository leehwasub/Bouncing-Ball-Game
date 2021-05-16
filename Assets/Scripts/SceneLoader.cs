using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader
{
    public static void LoadScene(string sceneName = "")
    {
        if(sceneName == "")
        {
            //씬 네임이 입력되지않으면 현재씬 다시로드
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
