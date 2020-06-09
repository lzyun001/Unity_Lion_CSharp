using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Far : Ground
{
    [Header("停止距離"), Range(0, 10)]
    public float stopDistance;
    [Header("丟擲物品")]
    public GameObject prop;
    [Header("丟擲間隔時間"), Range(0, 5)]
    public float cd;
    [Header("死亡時間"), Range(3, 7)]
    public float deadTime;

    /// <summary>
    /// 目標物件
    /// </summary>
    private Transform target;
    private float timer;
    /// <summary>
    /// 繪製圖示事件：在Scene繪製顯示，遊戲內不會顯示
    /// </summary>
    private void OnDrawGizmos()
    {
        // 圖示.顏色 = 顏色(紅，綠，藍，透明)
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        // 圖示.繪製線條(起點,終點)
        Gizmos.DrawLine(transform.position, transform.position + transform.right * stopDistance);
    }

    private void Start()
    {
        target = GameObject.Find("房子").transform;
    }
    protected override void Update()
    {
        base.Update();
        Throw();
    }

    private void Throw()
    {
        float dis = Vector3.Distance(transform.position, target.position);

        if (dis <= stopDistance)
        {
            speed = 0;      // 移動速度 = 0


            timer += Time.deltaTime;    //計時

            if (timer >= cd)
            {
                timer = 0;
                // 生成（丟擲物品，中心點+右邊+上方，角度）
                GameObject temp = Instantiate(prop, transform.position + transform.right * 2 + transform.up * 2, Quaternion.identity);
                temp.GetComponent<Rigidbody2D>().AddForce(new Vector2(300, 150));
                temp.GetComponent<ThrowObject>().damage = damage; // 將遠距離傷害值賦予丟擲物品
            }

            Invoke("Explosion", deadTime); // 延遲呼叫方法("方法名稱",延遲時間)
           
        }
    }
}
