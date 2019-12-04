using UnityEngine;

public class LearnOperator : MonoBehaviour
{
    public int A = 10, B = 3;
    
    public int C = 1;
    public int prop = 1;

    public int D = 9;

    public float E = 99.9f, F = 10.5f;

    private void Start()
    {
        #region 數學運算子
        // 加減乘除餘 + - * / %
        print(A + B);
        print(A - B);
        print(A * B);
        print(A / B);
        print(A % B);

        // 指派：先運算指派符號右邊再傳回左邊
        C = 9 + 1;
        print("C 運算結果：" + C);

        // prop = prop + 1; 原本寫法

        print(prop++);  // 後置遞增：先輸出在運算 - 輸出結果為 1，記憶體內儲存為 2
        print(++prop);  // 前置遞增：先運算在輸出 - 輸出結果為 3，記憶體內儲存為 3
        // 遞減 --

        // D = D + 10;
        D += 10;
        #endregion

        #region 比較運算子
        // 結果為布林值
        print(E > F);   // true
        print(E < F);   // false
        print(E >= F);  // t
        print(E <= F);  // f
        print(E == F);  // f
        print(E != F);  // t
        #endregion
    }
}
