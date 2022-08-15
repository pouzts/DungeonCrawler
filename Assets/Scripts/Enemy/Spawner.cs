using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject[] enemyPrefab; 
    [SerializeField] LayerMask layerMask;
    [SerializeField] int maxEnemies = 10; 

    int enemyIndex = 0;
    float timer = 2;
    int numEnemies = 0; 

    void Start()
    {
        
    }

    void Update()
    {
        timer -= Time.deltaTime; 

        if (timer <= 0 && numEnemies < maxEnemies)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hitInfo, 100, layerMask))
            {
                Instantiate(enemyPrefab[enemyIndex], hitInfo.point, Quaternion.AngleAxis(Random.Range(0, 360), Vector3.up));
                numEnemies++; 
            }

            timer = Random.Range(2, 4); 
        }
    }
}
