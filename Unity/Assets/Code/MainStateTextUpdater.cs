using Assets.Code;
using UnityEngine;
using UnityEngine.UI;

public class MainStateTextUpdater : MonoBehaviour
{
	private Text _textComponent;

	void Start ()
	{
		_textComponent = GetComponent<Text>();
		GlulxStateService.Instance.UpdatedMainState += UpdateStateText;
		UpdateStateText(GlulxStateService.Instance.CurrentMainText);
	}

	private void UpdateStateText(string newText)
	{
		_textComponent.text = newText;
	}
}