using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteGroup_Script : MonoBehaviour
{
    [SerializeField] private int noteMaxNum = 6; //�ִ� ��Ʈ ����
    [SerializeField] private Note_Script baseNoteClass = null; //�����ϰ� �� ��Ʈ
    [SerializeField] private float noteGapInterval = 2f;
    [SerializeField] private Transform noteSpawnTrf = null; // ��Ʈ ���� ��ġ

    public List<Note_Script> noteClassList; //������ ��Ʈ ����

    private void Awake()
    {
        this.noteClassList = new List<Note_Script>();
    }

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < noteMaxNum; i++)/*�м�*/
        {
            this.OnSpawnNote_Func();
        }
    }

    public void OnSpawnNote_Func()
    {
        GameObject _noteClassObj = GameObject.Instantiate(this.baseNoteClass.gameObject);

        _noteClassObj.transform.SetParent(this.noteSpawnTrf);
        _noteClassObj.transform.localPosition = Vector3.up * this.noteClassList.Count * this.noteGapInterval;

        Note_Script _noteClass = _noteClassObj.GetComponent<Note_Script>();

        _noteClass.GenerateNote_Func();

        this.noteClassList.Add(_noteClass);
    }

    public void ClickDone_Func(KeyCode _keyCode)
    {
        Note_Script _noteClass = this.noteClassList[0];
        _noteClass.Deactivate_Func();
        this.noteClassList.RemoveAt(0);

        if((_noteClass.IndexNum == 0 && _keyCode == KeyCode.RightArrow) || (_noteClass.IndexNum == 1 && _keyCode == KeyCode.LeftArrow))
        {
            GameSystem_Manager.Instance.scoreUp_Func();
        }
        else
        {
            GameSystem_Manager.Instance.scoreDown_Func();
        }

        for(int i = 0; i < this.noteClassList.Count; i++)
            this.noteClassList[i].transform.localPosition = Vector3.up * i * this.noteGapInterval;

        this.OnSpawnNote_Func();
    }
}
