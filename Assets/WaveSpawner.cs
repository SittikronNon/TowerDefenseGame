using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;

    public float timeBetweenWaves = 5f;
    private float countdown = 2f;

    void Update()
    {
        if(countdown <= 0f)
        {
            Spawnwave();
            countdown = timeBetweenWaves;
        }

        countdown -= Time.deltaTime;

        
    }

    void Spawnwave()
    {
        Debug.Log("Wave Incoming!");
    }
}
