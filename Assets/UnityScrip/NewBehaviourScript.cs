using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed;
    private bool isOnFloar = false;
    public float jumppower;  //设置一个给刚体施加的力
    private Rigidbody2D rb2D;  //定义刚体对象
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();  //将物体的刚体施加给对象
    }

    // Update is called once per frame
    void Update()
    {
        move1();
        jump1();

        
    }

    void move1()
    {
        float h = Input.GetAxis("Horizontal");   //获取横向输入值
        Vector3 Vc3 = new Vector3(h, 0, 0);
        transform.Translate(Vc3 * Time.deltaTime *speed);   //使物体横向移动
    }

    void jump1()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnFloar)   //当按下空格键，并且物体在平面上时
        {
            rb2D.AddForce(Vector2.up * jumppower);   //给刚体施加向上的力
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Floar")
        {
            isOnFloar = true;   //角色在地板上，则 isOnFloar变为true
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floar")
        {
            isOnFloar = false;   //角色离开地板，则 isOnFloar变为false
        }
    }

    private void OnTriggerStay2D(Collider2D collision)  //设置一个触发器，当物体碰到火时，触发提示
    {
        if(collision.gameObject.tag == "fair")
        {
            print("你在火中，正在扣血");
        }
    }
}
