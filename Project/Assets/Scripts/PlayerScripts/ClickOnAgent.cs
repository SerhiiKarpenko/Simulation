using UnityEngine;
using UnityEngine.UI;

public class ClickOnAgent : MonoBehaviour
{
    [SerializeField] private GameObject _agentInformationCanvas;
    [SerializeField] private Text _agentHealthPoints;
    [SerializeField] private Text _agentName;

    private void Update()
    {
        if(Input.GetMouseButton(0))
            OnClickOnAgent();
    }

    private void OnClickOnAgent()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit, 30.0f))
        {
            if(hit.transform.gameObject.GetComponent<AgentStats>() != null)
            {
                _agentInformationCanvas.SetActive(true);
                _agentName.text = "Agent name:" + " " + hit.transform.gameObject.GetComponent<AgentStats>().Name;
                _agentHealthPoints.text = "Agent health:" + " " + hit.transform.gameObject.GetComponent<AgentHealth>().CurrentHealth;
            }
            else
            {
                _agentInformationCanvas.SetActive(false);
            }
        }

    }
}
