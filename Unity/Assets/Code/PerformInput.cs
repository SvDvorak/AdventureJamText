using UnityEngine;
using System.Collections;
using Assets.Code;
using UnityEngine.UI;

public class PerformInput : MonoBehaviour
{
	private InputField _inputField;

	void Start ()
	{
		_inputField = GetComponent<InputField>();
	}

	void Update ()
	{
	
	}

	public void PerformAction()
	{
		if(_inputField.text != "")
		{
			GlulxStateService.Instance.Perform(_inputField.text);
			_inputField.text = "";
		}

		_inputField.Select();
		_inputField.ActivateInputField();
	}
}