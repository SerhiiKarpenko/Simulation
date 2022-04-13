using UnityEngine;

public class AgentTemplatesHolder : MonoBehaviour
{
    [SerializeField] private AgentData[] _agentsTemplates;

    // this is not Singleton but something like
    public static AgentTemplatesHolder Instance;
    private void Awake()
    {
        Instance = this;
    }

	public AgentData GetRardomTemplate()
	{
		AgentData agent = _agentsTemplates[Random.Range(0, _agentsTemplates.Length)];
		return agent;
	}
}
