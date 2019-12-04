using UnityEngine;

public class LearnIf : MonoBehaviour
{
    public bool openDoor;

    private void Start()
    {
        // if (布林值) { 陳述式或演算法 }
        // () 內的布林值為 true 會執行 {}
        if (true)
        {
            print("測試!");
        }
    }

    private void Update()
    {
        if (openDoor)
        {
            // if () 內的布林值為 true 會執行 if {}
            print("開門");
        }
        else
        {
            // if () 內的布林值為 false 會執行 else {}
            print("關門");
        }
    }
}
