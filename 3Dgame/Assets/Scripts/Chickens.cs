using UnityEngine; //引用Unity  API

//      類別   類別名稱要等於檔案名稱
public class Chickens : MonoBehaviour
{
    #region 欄位區域
    //宣告變數(定義欄位 Field)
    //欄位類型 欄位名稱  (指定 值) 結束
    //私人 - 隱藏 private (預設)
    //公開 - 顯示 public
    [Header("移動速度")][Range(1,2000)]
    public int speed = 10;         //整數1,999,-100
    [Header("旋轉速度"),Tooltip("G8雞的旋轉速度"),Range(1.5f,200f)]
    public float turn = 20.5f;     // 浮點數
    [Header("是否完成任務")]
    public bool mission;           //布林值 true false
    [Header("玩家名稱")]
    public string _name = "G8雞";   //字串""
    #endregion

    public Transform tran;
    public Rigidbody rig;
    public Animator ani;

    private void Update()
    {
        Turn();
        Run();
    }

    #region 方法區域
    /// <summary>
    /// 跑步
    /// </summary>
    private void Run() 
    {
        float v = Input.GetAxis("Vertical"); //W 上 1、S 下 -1、沒按 0
        //rig.AddForce(0,0 ,speed * v)
        //tran.forward 區域座標Z軸
        //tran.right   區域座標X軸
        //tran.up      區域座標Y軸
        rig.AddForce(tran.forward * speed * v * Time.deltaTime);
    }
    /// <summary>
    /// 旋轉
    /// </summary>
    private void Turn()
    {
        float h = Input.GetAxis("Horizontal"); //A 左 -1、D 右 1、沒按 0
        tran.Rotate(0, turn * h * Time.deltaTime, 0);
    }
    /// <summary>
    /// 亂叫
    /// </summary>
    private void Bark()
    {
        //按下空白鍵拍翅膀
    }
    /// <summary>
    /// 撿東西
    /// </summary>
    private void Catch()
    {
        //按下左鍵撿東西
    }
    /// <summary>
    /// 檢視任務
    /// </summary>
    private void Task()
    {

    }
    #endregion
}
