using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    [SerializeField] private float dogSpawnTimerMax = 2.0f;

    private float dogSpawnTimer;

    private void Awake()
    {
        dogSpawnTimer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (dogSpawnTimer > 0f) dogSpawnTimer -= Time.deltaTime;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (dogSpawnTimer <= 0f)
            {
                SpawnDog();
            }
        }
    }

    private void SpawnDog()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        dogSpawnTimer = dogSpawnTimerMax;
    }
}
