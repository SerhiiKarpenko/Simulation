using UnityEngine;

public class AgentStats : MonoBehaviour
{
	[SerializeField] private AgentData _agentTemplate;
    [SerializeField] private string _name;
	[SerializeField] private float _speed;
	private int _maxHealthPoints = 3;

    private void Start()
    {
		_agentTemplate = AgentTemplatesHolder.Instance.GetRardomTemplate();
		_name = _agentTemplate.Name;
		_speed = _agentTemplate.Speed;
    }

	public string Name => _name;
	public int MaxHealthPoints => _maxHealthPoints;
	public float Speed => _speed;

}
