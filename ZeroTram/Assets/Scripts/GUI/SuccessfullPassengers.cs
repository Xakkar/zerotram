﻿using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SuccessfullPassengers : MonoBehaviour, GameStateNotificationListener
{
	private Text _text;
	private const string Prefix = "доехавших: ";

	void Start()
	{
		_text = GetComponent<Text>();
		_text.text = Prefix + "0";
		GameController.GetInstance().AddListener(this);
	}

	void OnDestroy()
	{
		GameController.GetInstance().RemoveListener(this);
	}

	public void UpdateInfo(GameController.StateInformation information)
	{
		_text.text = Prefix + information.TicketCount;
	}

	public void GameOver()
	{

	}
}