using UnityEngine;
using UnityEngine.UI;
using System;

public class Practice1_OperatorMethod : MonoBehaviour
{
    // 儲存兩筆數字
    public string number1;
    public string number2;

    [Header("文字：輸出結果")]
    public Text result;

    /// <summary>
    /// 給第一個輸入欄位使用
    /// </summary>
    /// <param name="number">第一個欄位的數值</param>
    public void InputNumber1(string number)
    { 
        number1 = number;
    }

    public void InputNumber2(string number)
    {
        number2 = number;
    }

    public void Add()
    {
        int n1 = Int32.Parse(number1);
        int n2 = Int32.Parse(number2);
        
        print("加法結果：" + (n1 + n2));

        //輸出結果，文字內容 =
        result.text = "加法結果：" + (n1 + n2);
    }

    public void Sub()
    {
        int n1 = Int32.Parse(number1);
        int n2 = Int32.Parse(number2);

        result.text = "減法結果：" + (n1 - n2);
    }
    public void Mul()
    {
        int n1 = Int32.Parse(number1);
        int n2 = Int32.Parse(number2);
        result.text = "乘法結果：" + (n1 * n2);
    }
    public void Div()
    {
        int n1 = Int32.Parse(number1);
        int n2 = Int32.Parse(number2);
        result.text = "除法結果：" + (n1 / n2);
    }
    public void Rem()
    {
        int n1 = Int32.Parse(number1);
        int n2 = Int32.Parse(number2);
        result.text = "餘數：" + (n1 % n2);
    }
}
