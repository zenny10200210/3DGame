﻿using UnityEngine;

public class LearAPI : MonoBehaviour
{
    //非靜態
    //變形、剛體、動畫、音效、燈光、攝影機
    //先定義蘭為存放並設定代號
    //修飾詞 類型 名稱(代號)
    public Transform test1;
    public Transform test2;
    void Start()
    {
     //取得非靜態屬性
     //代號.屬性
     print(test1.position);
        //設定非靜態屬性
        //代號.屬性 = 對應的類型
        test1.localScale = new Vector3(10, 10, 10);
        //new Vector3(1, 1, 1)*5;
        test2.localScale = Vector3.one*5;
    }
    private void Update()
    {
        //代號.方法(對應引數)
        test1.Rotate(0, 5, 0);
        test2.Translate(0, 0, 1.5f);
    }
}
