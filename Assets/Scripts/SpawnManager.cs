using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] animalPrefabs;
    [SerializeField] private float spawnRangeX;
    [SerializeField] private float spawnPosZ;
    [SerializeField] private float spawnStartTime;
    [SerializeField] private float spawnRateTime;

    private void Start()
    {
        InvokeRepeating("SpawnAnimal", spawnStartTime, spawnRateTime);
    }

    private void SpawnAnimal()
    {
        int randomAnimal = Random.Range(0, animalPrefabs.Length);
        float xPos = Random.Range(-spawnRangeX, spawnRangeX);
        Instantiate(animalPrefabs[randomAnimal], new Vector3(xPos, 0, spawnPosZ), animalPrefabs[randomAnimal].transform.rotation);
    }
}
