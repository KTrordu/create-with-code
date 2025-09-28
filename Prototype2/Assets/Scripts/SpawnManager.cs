using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] animalPrefabs;
    [SerializeField] private float spawnRangeX = 20f;
    [SerializeField] private float spawnPosZ = 20f;

    private void Start()
    {
        InputManager.Instance.OnSpawnPerformed += InputManager_OnSpawnPerformed;
    }

    private void InputManager_OnSpawnPerformed(object sender, System.EventArgs e)
    {
        HandleSpawn();
    }

    private void HandleSpawn()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0f, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
