using UnityEngine;
using UnityEngine.UI;

public class MarkoPolo : MonoBehaviour
{
	[SerializeField] private Text _marcoPoloText;
	public void OnPrintMarcoPoloButtonClick()
    {
		_marcoPoloText.text = PrintMarkoPoloText();
    }

	public void OnEraseMarcoPoloTextButtonClick()
    {
		_marcoPoloText.text = "";
    }

	private string PrintMarkoPoloText()
	{
		string marcoPolo = "";
		for (int i = 1; i <= 100; i++)
		{
			if (i % 3 == 0 && i % 5 == 0)
			{
				marcoPolo += " " + i + " = MarkoPolo ";
			}
			else if (i % 5 == 0)
			{
				marcoPolo += " " + i + " = Polo ";
			}
			else if (i % 3 == 0)
			{
				marcoPolo += " " + i +  " = Marco ";
			}
			else
			{
				marcoPolo += " " + i + " ";
			}
			marcoPolo += ",";
		}
		return marcoPolo;
	}
}
