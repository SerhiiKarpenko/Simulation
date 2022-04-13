using System.Collections;
using UnityEngine;

[RequireComponent(typeof(RandomPositionsInArea))]
public class AgentSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _agentPrefab;
    [SerializeField] private float _secondsBetweenSpawnAgent;
    [SerializeField, Range(0, 30)] private int _maxAmountOfAgentsToSpawn;
    private int _amountOfAlreadySpawnedAgenst;
    private RandomPositionsInArea _randomSpawnPositions;

    private void Start()
    {
        _randomSpawnPositions = GetComponent<RandomPositionsInArea>();
        StartCoroutine(AgentSpawnerCoroutine());
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
                // creating agent, waiting some time and again creation agent
                yield return new WaitForSeconds(_secondsBetweenSpawnAgent);
                SpawnAgent(_agentPrefab, _randomSpawnPositions.GetRandomPositionInArea(), Quaternion.identity);
                _amountOfAlreadySpawnedAgenst++;

            }
        }
    }

    private void SpawnAgent(GameObject agent, Vector3 spawnPosition, Quaternion rotation)
    {
        // insted of Instantinate we can use object pooling patern
        Instantiate(agent, spawnPosition, rotation);
    }
    
}
