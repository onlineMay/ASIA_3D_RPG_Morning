using UnityEngine;

public class LearnAPIStatic : MonoBehaviour
{
    private void Start()
    {
        // 使用靜態成員
        // 成員：屬性 properties (類似欄位 fields)
        // 成員：方法 methods

        // 取得靜態屬性語法：類別.屬性
        // 設定靜態屬性語法：類別.屬性 = 值

        print(Random.value);
    }
}
