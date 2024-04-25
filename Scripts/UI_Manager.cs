using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    public static UI_Manager Instance;
    [SerializeField] private Image timerImg = null;
    [SerializeField] private TextMeshProUGUI timerTmp = null;
    [SerializeField] private TextMeshProUGUI scoreTmp = null;
    [SerializeField] private TextMeshProUGUI gameScoreTmp = null;

    private void Awake()
    {
        Instance = this;
    }

    public void OnTimer_Func(float _currnetTimer, float _maxTimer)
    {
        string _currentTimerStr = string.Format("{0:N1}", _currnetTimer);
        this.timerTmp.text = $"{_currentTimerStr}/{_maxTimer}";
        this.timerImg.fillAmount = (float)_currnetTimer / _maxTimer;
    }

    public void OnScore_Func(int _currentScore)
    {
        this.scoreTmp.text = $"{_currentScore}";
        this.gameScoreTmp.text = $"{_currentScore} !!";
    }
}
