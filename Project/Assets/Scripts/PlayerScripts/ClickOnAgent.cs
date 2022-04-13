using UnityEngine;
using UnityEngine.UI;

public class ClickOnAgent : MonoBehaviour
{
	[SerializeField] private GameObject _agentInformationCanvas;
	[SerializeField] private Text _agentHealthPoints;
	[SerializeField] private Text _agentName;
	private GameObject _prviousClickedAgent;

	private void Update()
	{
		if(Input.GetMouseButtonDown(0))
			OnClickOnAgent();
		

		if(_prviousClickedAgent != null)
        {
			_agentHealthPoints.text = "Agent health:" + " " + _prviousClickedAgent.GetComponent<AgentHealth>().CurrentHealth;
        }
	}

	// Hited Agent change's his color to blue, previous change's his color to green
	private void OnClickOnAgent()
	{
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if(Physics.Raycast(ray, out hit, 30.0f))
		{
			if(hit.transform.gameObject.GetComponent<AgentStats>() != null)
			{
				_agentInformationCanvas.SetActive(true);
				if (_prviousClickedAgent != null)
				{
					_prviousClickedAgent.GetComponent<AgentSelectedChangeColor>().AgentChangeColorUnSelected();
				}
				hit.transform.gameObject.GetComponent<AgentSelectedChangeColor>().AgentChangeColorSelected();
				_prviousClickedAgent = hit.transform.gameObject;
				_agentName.text = "Agent name:" + " " + _prviousClickedAgent.GetComponent<AgentStats>().Name;
				_agentHealthPoints.text = "Agent health:" + " " + _prviousClickedAgent.GetComponent<AgentHealth>().CurrentHealth;
			}
			else
			{
				if (_prviousClickedAgent != null)
				{
					_prviousClickedAgent.GetComponent<AgentSelectedChangeColor>().AgentChangeColorUnSelected();
				}
				_agentInformationCanvas.SetActive(false);
			}
		}

	}



}
