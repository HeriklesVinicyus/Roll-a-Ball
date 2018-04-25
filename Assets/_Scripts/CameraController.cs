using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	void Start (){
		offset = transform.position - player.transform.position;
	}

	//Chamado como o Update, porém é quando todos dos outros updates são chamados
	void LateUpdate (){
		transform.position = player.transform.position + offset;
	}
}
