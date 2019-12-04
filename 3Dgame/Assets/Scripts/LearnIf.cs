using UnityEngine;

public class LearnIf : MonoBehaviour
{
    public bool openDoor;
    public int score;
    public int hit;
    private void Start()
    {
        // 語法：if (布林值) { 陳述式或演算法 }
        // () 內的布林值為 true 執行 { }
        if (true)
        {
            print("測試!");
        }
    }

    private void Update()
    {
        if (openDoor)
        {
            //if()內的布林值為true執行if {}
            print("開門");
        }
        else
        {
            //if()內的布林值為false執行if {}
            print("關門");
        }
        if (score >= 60)
        {
            print("及格");
        }
        else if(score >= 50)
        {
            print("可以補考");
        }
        else if (score >= 40)
        {
            print("可以付錢補考==+");
        }
        else
        {
            print("被當惹");
        }

        if (hit >= 150)
        {
            print("攻擊力10倍");
        }
        else if (hit >= 100&& hit<150)
        {
            print("攻擊力5倍");
        }
        else if (hit >= 50 && hit < 100)
        {
            print("攻擊力2倍");
        }
        else
        {
        }

    }
}
