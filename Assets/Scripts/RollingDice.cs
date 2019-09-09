using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingDice : MonoBehaviour
{
    public int numberGet;
    public SpriteRenderer numberHolder;
    public Sprite[] NumberedSprite;

    private void Update(){
        if(Input.GetMouseButton(0)){
            numberGet = Random.Range(0,6);
            numberHolder.sprite=NumberedSprite[numberGet];
            numberGet+=1;
        }
    }
}
