﻿using UnityEngine;

public class LearnMethod : MonoBehaviour
{
    //定義方法
    //語法
    //修飾詞 傳回類型 方法名稱 () { 陳述式或演算法 }
    //參數類型 參數名稱
    //void 無傳回
    //需要被呼叫
    /// <summary>
    /// 開車方法
    /// </summary>
    /// <param name="speed">開車的速度</param>
    private void Drive(int speed)
    {
        //輸出訊息(字串);
        print("音效!");
        //可使用+號串接字串與其他類型
        print("開車，時速："+speed);
    }

    //有預設值的參數 選填式參數，呼叫時可不填寫
    //選填式參數只能寫在最右邊
    public void Shoot(int count, float speed, string prop = "無",string direction="前方")
    {
        print("弓箭速度：" + count);
        print("弓箭速度：" + speed);
        print("弓箭速度：" + prop);
        print("弓箭速度：" + direction);
    }

    private int Square(int number=2)
    {
        return number * number;
    }
    //事件：在指定的時間會以指定次數執行的方法
    //初始事件：遊戲播放後執行一次
    private void Start()
    {
        print("Hello!World");

        //呼叫自訂方法 ，須給予對應德引數
        Drive(200);
        Drive(300);
        Drive(400);
        Drive(500);

        Shoot(1, 1.5f);
        Shoot(10, 10.5f, "火屬性");
        //使用具名方式給予選填式參數
        Shoot(3, 2, direction: "前後方");

        print(Square()); //當成傳回類型使用

        int result = Square(9);  //存放在區域欄位內
        print(result);
    }
}