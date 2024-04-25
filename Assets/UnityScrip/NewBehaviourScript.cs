using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed;
    private bool isOnFloar = false;
    public float jumppower;  //����һ��������ʩ�ӵ���
    private Rigidbody2D rb2D;  //����������
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();  //������ĸ���ʩ�Ӹ�����
    }

    // Update is called once per frame
    void Update()
    {
        move1();
        jump1();

        
    }

    void move1()
    {
        float h = Input.GetAxis("Horizontal");   //��ȡ��������ֵ
        Vector3 Vc3 = new Vector3(h, 0, 0);
        transform.Translate(Vc3 * Time.deltaTime *speed);   //ʹ��������ƶ�
    }

    void jump1()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnFloar)   //�����¿ո��������������ƽ����ʱ
        {
            rb2D.AddForce(Vector2.up * jumppower);   //������ʩ�����ϵ���
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Floar")
        {
            isOnFloar = true;   //��ɫ�ڵذ��ϣ��� isOnFloar��Ϊtrue
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floar")
        {
            isOnFloar = false;   //��ɫ�뿪�ذ壬�� isOnFloar��Ϊfalse
        }
    }

    private void OnTriggerStay2D(Collider2D collision)  //����һ����������������������ʱ��������ʾ
    {
        if(collision.gameObject.tag == "fair")
        {
            print("���ڻ��У����ڿ�Ѫ");
        }
    }
}
