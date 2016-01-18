using UnityEngine;
using System.Collections;

public class PlayerDress : MonoBehaviour {

	public SkinnedMeshRenderer headRender;
	public SkinnedMeshRenderer handRender;
	public SkinnedMeshRenderer footRenderer;
	public SkinnedMeshRenderer upperbodyRenderer;	
	public SkinnedMeshRenderer lowerbodyRenderer;	
	public SkinnedMeshRenderer[] bodyArray;
	
	// Use this for initialization
	void Start () {
		InitDress();
	}
	
	void InitDress() {
		int headMeshIndex = PlayerPrefs.GetInt("HeadMeshIndex");
		int handMeshIndex = PlayerPrefs.GetInt("HandMeshIndex");
		int footMeshIndex = PlayerPrefs.GetInt ("FootMeshIndex");
		int upperbodyMeshIndex = PlayerPrefs.GetInt("UpperbodyMeshIndex");
		int lowerbodyMeshIndex = PlayerPrefs.GetInt("LowerbodyMeshIndex");
		int colorIndex = PlayerPrefs.GetInt("ColorIndex");
		
		headRender.sharedMesh = MenuController._instance.headMeshArray[headMeshIndex];
		handRender.sharedMesh = MenuController._instance.handMeshArray[handMeshIndex];
		footRenderer.sharedMesh = MenuController._instance.footMeshArray [footMeshIndex];
		upperbodyRenderer.sharedMesh = MenuController._instance.upperbodyMeshArray [upperbodyMeshIndex];
		lowerbodyRenderer.sharedMesh = MenuController._instance.lowerbodyMeshArray [lowerbodyMeshIndex];

		
		foreach (SkinnedMeshRenderer render in bodyArray) {
			render.material.color = MenuController._instance.colorArray[colorIndex];
		}
	}
}
