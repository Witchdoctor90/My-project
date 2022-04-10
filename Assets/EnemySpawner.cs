using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {


    [SerializeField] private GameObject EnemyPrefab;


    private void Start()
    {
        StartCoroutine(EnemySpawnCourutine());
    }

    private IEnumerator EnemySpawnCourutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            Instantiate(EnemyPrefab, transform);
            Debug.Log("Spawned!");
        }
    }
}
