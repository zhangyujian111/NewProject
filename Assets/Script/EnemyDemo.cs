using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDemo : MonoBehaviour
{
    private Rigidbody rd;
    private int speed = 2;
    private int Hp = 100;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        Vector3 vector3 = -transform.forward * Time.fixedDeltaTime * speed;  //向物体的正前方移动
        rd.MovePosition(transform.position + vector3);
    }

    public void Hurt(int damage)
    {
        Hp -= damage;
        if(Hp <= 0) 
        {
            Dead();
        }
    }

    private void Dead()
    {
        //敌人死亡
        Destroy(gameObject);
        Player.Instance.EnemyDead(this);
    }
}
