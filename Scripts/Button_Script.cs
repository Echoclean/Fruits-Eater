using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Button_Script : MonoBehaviour
{
    [SerializeField] private Animation LBtnAnim = null;
    [SerializeField] private Animation RBtnAnim = null;
    [SerializeField] private NoteGroup_Script _noteGroupClass;
    
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnClickRightButton()
    {
        audioSource.Play();
        RBtnAnim.Play();
        _noteGroupClass.ClickDone_Func(true);
    }

    public void OnClickLeftButton()
    {
        audioSource.Play();
        LBtnAnim.Play();
        _noteGroupClass.ClickDone_Func(false);
    }
}
