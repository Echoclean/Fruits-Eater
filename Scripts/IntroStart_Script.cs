using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroStart_Script : MonoBehaviour
{
    public void SceneLoader(string _sceneName)
    {
        SceneManager.LoadScene(_sceneName);
    }
}
