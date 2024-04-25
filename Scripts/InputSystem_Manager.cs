using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSystem_Manager : MonoBehaviour
{
    public static InputSystem_Manager Instance;

    void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameSystem_Manager.Instance.isGameDone == true)
        {
            return;
        }

        //버튼 처리 (InputSystem -> NoteSystem -> Button)
        if(Input.GetKeyDown(KeyCode.RightArrow) == true)
        {
            NoteSystem_Manager.Instance.OnInput_Func(KeyCode.RightArrow);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) == true)
        {
            NoteSystem_Manager.Instance.OnInput_Func(KeyCode.LeftArrow);
        }
    }
}
