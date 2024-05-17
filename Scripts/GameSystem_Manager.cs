using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSystem_Manager : MonoBehaviour
{
    public static GameSystem_Manager Instance;
    private int score;

    //[SerializeField] private SoundSystem_Manager soundSystem_Manager = null;
    //[SerializeField] private DataBase_Manager dataBase_Manager = null;

    [SerializeField] private float maxTime = 30f;
    [SerializeField] private GameObject gameOverObj = null;
    [SerializeField] private GameObject gameScoreObj = null;
    [SerializeField] private GameObject restartButton = null;
    [SerializeField] private GameObject gameClearGroup = null;

    public bool isGameDone => this.gameOverObj.activeSelf == true;

    void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        this.gameOverObj.SetActive(false);
        this.gameScoreObj.SetActive(false);
        this.restartButton.SetActive(false);
        this.gameClearGroup.SetActive(false);

        UI_Manager.Instance.OnScore_Func(this.score);
        StartCoroutine(this.OnTimer_Cor());
    }

    IEnumerator OnTimer_Cor()
    {
        float _currentTime = 0f;
        while (_currentTime < this.maxTime)
        {
            _currentTime += Time.deltaTime;
            UI_Manager.Instance.OnTimer_Func(_currentTime, this.maxTime);
            yield return null;
        }

        //GameOver
        this.gameOverObj.SetActive(true);
        this.gameScoreObj.SetActive(true);
        this.restartButton.SetActive(true);
        this.gameClearGroup.SetActive(true);
    }

    public void scoreUp_Func()
    {
        score++;
        UI_Manager.Instance.OnScore_Func(this.score);
    }

    public void scoreDown_Func() 
    {
        score--;
        if(score <= 0)
        {
            score = 0;
        }
        UI_Manager.Instance.OnScore_Func(this.score);
    }  
    
    public void CallBtn_Restart_Func()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public void CallBtn_BackIntro_Func(string _sceneName)
    {
        SceneManager.LoadScene(_sceneName);
    }
}
