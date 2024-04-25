using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSystem_Manager : MonoBehaviour
{
    public static NoteSystem_Manager Instance;
    [SerializeField] private Button_Script btn;

    private void Awake()
    {
        Instance = this;
    }

    //InputSystem_Manager에서 눌린 버튼 처리
    public void OnInput_Func(KeyCode _keyCode)
    { 

        if (_keyCode == KeyCode.RightArrow)
        {
            this.btn.OnClickRightButton();
        }

        else if(_keyCode == KeyCode.LeftArrow)
        {
            this.btn.OnClickLeftButton();
        }
    }

}
