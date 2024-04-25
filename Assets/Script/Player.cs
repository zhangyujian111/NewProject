using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;
    private int attackValue = 50;
    public List<EnemyDemo> enemys;
    private bool isOver = false;
    private int Score = 0;
    // Start is called before the first frame update

    private void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();

    }

    void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hitInfo, 1000))
            {
                if (hitInfo.collider.gameObject.tag == "Enemy")
                {
                    EnemyDemo enemy = hitInfo.collider.gameObject.GetComponent<EnemyDemo>();
                    enemy.Hurt(attackValue);
                }
            }
        }
    }

    public void EnemyDead(EnemyDemo enemy)
    {
        Score += 1;
        UIManager.Instance.UpdateScoreNumText(Score);
        enemys.Remove(enemy);
        if(enemys.Count == 0)
        {
            //ÓÎÏ·Ê¤Àû
            GameWin();
        }
    }

    private void GameWin()
    {
        UIManager.Instance.GameResult(true);
    }

    private void GameOver()
    {
        Time.timeScale = 0;
        UIManager.Instance.GameResult(false);
        isOver = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy" && isOver == false)
        {
            GameOver();
        }
    }
}
