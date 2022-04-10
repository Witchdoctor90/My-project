using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerStats : MonoBehaviour {

    public int level = 1;
    public int xp = 0;
    public int killedEnemies;

    private void Start()
    {
            
    }

    public void LevelUp()
    {
        level++;
    }

    public void EnemyKilled()
    {
        killedEnemies++;

    }

}
