using UnityEngine;

public class LearnIf : MonoBehaviour
{
    public bool openDoor;

    public int score;

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

        if (score >= 60 )
        {
            print("及格");
        }
        else if (score >= 50)
        {
            print("可以補考!");
        }
        else if (score >= 40)
        {
            print("付錢來補考~");
        }
        else
        {
            print("被當惹");
        }
    }
}
