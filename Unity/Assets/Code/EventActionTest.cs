using UnityEngine;
using System.Collections;
using Assets.Code;

public class EventActionTest : MonoBehaviour
{
	void Start ()
	{
		GlulxStateService.Instance.EventOccurred += OnEventOccurred;
	}

	private void OnEventOccurred(string eventText)
	{
		var o = new GameObject("Created");
	}
}
