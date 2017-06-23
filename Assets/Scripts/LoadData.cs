using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class LoadData : MonoBehaviour {

	public Text FullName;
	public Image UserImage;
	public int width = 100;
	public int height = 100;
	// Use this for initialization
	void Start () {
		FullName.text = "Random user";

		byte[] bytes = File.ReadAllBytes(Application.dataPath + "/defaultavatar.png");
		Texture2D texture = new Texture2D(width, height);
		texture.filterMode = FilterMode.Trilinear;
		texture.LoadImage(bytes);
		Sprite sprite = Sprite.Create(texture, new Rect(0,0,width, height), new Vector2(0.5f,0.5f), 1.0f);

		UserImage.sprite =sprite;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
