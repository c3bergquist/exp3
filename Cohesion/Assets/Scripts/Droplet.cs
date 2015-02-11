﻿using UnityEngine;
using System.Collections;

public class Droplet: MonoBehaviour {

	void OnTriggerEnter2D (Collider2D collider) {
		if (collider.gameObject.tag == "Player") {
			DropletManager.Instance.player.GetComponent<CharController> ().Grow ();
			DropletManager.Instance.dropsCollected++;
			Destroy (this.gameObject);
		}
		else if (collider.gameObject.tag == "Droplet") {
			transform.localScale = new Vector2 (transform.localScale.x * 1.1f, transform.localScale.y * 1.1f);
			Destroy (collider.gameObject);
		}
	}
}