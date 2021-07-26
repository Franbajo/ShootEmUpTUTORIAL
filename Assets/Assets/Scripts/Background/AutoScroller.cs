﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoScroller : MonoBehaviour {

	public float scrollSpeed;
	[SerializeField]private MeshRenderer TextureBackground;

	void Update () {
		Vector2 offset = new Vector2 (0, Time.time * scrollSpeed);
		TextureBackground.material.mainTextureOffset = offset;
	}
}
