using UnityEngine;

public class RandomSpawnPositions : MonoBehaviour
{
    [SerializeField] private Transform _areaWhereAgentsWillSpawn;
    [SerializeField] private Transform _agentTransform;
    private float _scaleOfAgentY;
    private Vector3 _centerOfArea;
    private Vector3 _scaleOfArea;


    private void Start()
    {
        _centerOfArea = _areaWhereAgentsWillSpawn.position;
        _scaleOfArea = _areaWhereAgentsWillSpawn.localScale;
        _scaleOfAgentY = _agentTransform.localScale.y;
    }

    public Vector3 GetRandomPositionInArea()
    {
        Vector3 randomPos = _centerOfArea + new Vector3(
            Random.Range(-_scaleOfArea.x / 2, _scaleOfArea.x / 2), 
            _scaleOfArea.y,
            Random.Range(-_scaleOfArea.z / 2, _scaleOfArea.z / 2)
            );
        return randomPos;
    }
    
}
