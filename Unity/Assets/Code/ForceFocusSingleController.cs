using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ForceFocusSingleController : MonoBehaviour, IPointerDownHandler
{
	public InputField ObjectToFocusOn;

	public void OnPointerDown(PointerEventData eventData)
	{
		ObjectToFocusOn.Select();
		ObjectToFocusOn.ActivateInputField();
	}
}
