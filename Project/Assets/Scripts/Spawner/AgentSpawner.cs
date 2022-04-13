using System.Collections;
using UnityEngine;

[RequireComponent(typeof(RandomSpawnPositions))]
public class AgentSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _agentPrefab;
    [SerializeField] private float _secondsToSpawnAgent;
    [SerializeField, Range(0, 30)] private int _maxAmountOfAgentsToSpawn;
    private int _amountOfAlreadySpawnedAgenst;
    private RandomSpawnPositions _randomSpawnPositions;

    private void Start()
    {
        _randomSpawnPositions = GetComponent<RandomSpawnPositions>();
    }

    private IEnumerator AgentSpawnerCoroutine()
    {
        while(true)
        {
            if (_amountOfAlreadySpawnedAgenst == _maxAmountOfAgentsToSpawn)
            {
                
                yield break;
            }
            else
            {
               // создаем объект, ждем время опять созадем,
            }
        }
    }

    private void SpawnAgent(GameObject agent, Vector3 spawnPosition, Quaternion rotation)
    {
        Instantiate(agent, spawnPosition, rotation);
    }
    
}
