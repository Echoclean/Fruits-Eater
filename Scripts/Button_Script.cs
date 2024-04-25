using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Script : MonoBehaviour
{
    [SerializeField] private Animation LBtnAnim = null;
    [SerializeField] private Animation RBtnAnim = null;
    [SerializeField] private NoteGroup_Script _noteGroupClass;

    public void OnClickRightButton()
    {
        RBtnAnim.Play();
        _noteGroupClass.ClickDone_Func(KeyCode.RightArrow);
    }

    public void OnClickLeftButton()
    {
        LBtnAnim.Play();
        _noteGroupClass.ClickDone_Func(KeyCode.LeftArrow);
    }
}
