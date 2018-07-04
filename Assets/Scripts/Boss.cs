using System.Collections;
using UnityEngine;

public class Boss : MonoBehaviour {

    int hp;
    int power;
    int mp = 53;

    private void Start()
    {
        var boss = new Boss();
        for (int i = 0; i <= 10; i++)
        {
            boss.Magic(5);
        }
    }



public void Attack()
    {
        Debug.Log(this.power + "のダメージを受けた");
    }

    public void Defend(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + "のダメージを与えた");
    }

    public void Magic(int useMp)
    {
        if (mp >= useMp)
        {
            mp -= useMp;
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}

