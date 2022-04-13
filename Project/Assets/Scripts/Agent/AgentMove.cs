using System.Collections;
using UnityEngine;

[RequireComponent(typeof (AgentStats))]
public class AgentMove : MonoBehaviour
{
	private AgentStats _agentStats;
	private RandomPositionsInArea _randomPositionsInArea;
	private bool _isOnDestionation = false;
	private Vector3 _destination;

	private void Start()
	{
		_agentStats = GetComponent<AgentStats>();
		_randomPositionsInArea = GetComponent<RandomPositionsInArea>();
		SetDestionation();
	}

    private void Update()
    {
		CheckAgentPosition();

		if (!_isOnDestionation)
			Move();
		else
			SetDestionation();
    }


    private void Move()
    {
		transform.position = Vector3.MoveTowards(transform.position, _destination, _agentStats.Speed * Time.deltaTime);
    }
	

	private void CheckAgentPosition()
    {
		if (transform.position == _destination)
			_isOnDestionation = true;

    }

	private void SetDestionation()
    {
		_destination = _randomPositionsInArea.GetRandomPositionInArea();
		_destination.y = 1;
		_isOnDestionation = false;
    }
	

}
