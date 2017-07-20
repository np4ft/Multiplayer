﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyScript : Photon.MonoBehaviour {

	public int index = 1;
	
	// Update is called once per frame
	void Update () {
		if (photonView.isMine) {
			switch (index) {
			case 1: //head
				transform.position = ViveManager.Instance.head.transform.position;
				transform.rotation = ViveManager.Instance.head.transform.rotation;
				break;
			}
		}
	}
}
