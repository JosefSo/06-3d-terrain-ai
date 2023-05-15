using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // The enemy prefab to spawn
    public float spawnRate = 2f; // The rate at which to spawn the enemies (enemies per second)

    private void Start()
    {
        // Start spawning enemies
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        int num = 1;
        while (num > 0)
        {
            num--;
            // Instantiate a new enemy at the spawner's position and rotation
            Instantiate(enemyPrefab, transform.position, transform.rotation);

            // Wait for the next spawn
            yield return new WaitForSeconds(1f / spawnRate);
        }
    }
}
