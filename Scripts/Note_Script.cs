using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note_Script : MonoBehaviour
{
    [SerializeField] public SpriteRenderer srdr;
    [SerializeField] public Sprite appleSprite;
    [SerializeField] public Sprite blueberrySprite;
    public int IndexNum = 0;

    public void Deactivate_Func()
    {
        GameObject.Destroy(this.gameObject);
    }

    public void GenerateNote_Func()
    {
        IndexNum = Random.Range(0, 2);
        if (IndexNum == 0)
        {
            this.srdr.sprite = this.appleSprite;
        }
        else
        {
            this.srdr.sprite = this.blueberrySprite;
        }
    }
}
