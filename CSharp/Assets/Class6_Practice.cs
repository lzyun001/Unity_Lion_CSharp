using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class6_Practice : MonoBehaviour
{
    // 欄位
    // 修飾詞 類別 物件名稱
    public SpriteRenderer sprite;
    public Rigidbody sphere;

    private void Start()
    {
        // 練習1：靜態屬性
        Time.timeScale = 2;

        // 練習2：非靜態屬性
        sprite.flipX = true;

        // 練習3：靜態方法
        print(Mathf.Floor(1.23456f));

        // 練習4：非靜態方法
        sphere.AddForce(0, 800, 1500);
    }
   
}
