using UnityEngine;
using System.Collections;

public class DoneSpanEnemy : MonoBehaviour
{
	public Object enemyObj;
	public Object enemyObj1;
	public Object enemyObj2;
	public Object enemyObj3;
	public Object enemyObj4;
	public Object propObj;
	public Object propObj1;
	private int time = 0;
	public GUIText guitext;
	private GameObject propPlane1;
	private GameObject propPlane2;

	void Awake ()
	{
		InvokeRepeating ("AddTime", 1, 2);
		propPlane1 = GameObject.FindWithTag ("Texture1");
		propPlane1.GetComponent<UITexture> ().enabled = false;
		propPlane2 = GameObject.FindWithTag ("Texture2");
		propPlane2.GetComponent<UITexture> ().enabled = false;
	}
	// Use this for initialization
	void Start ()
	{
		guitext.enabled = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
	
		if (time > 78) {
			CancelInvoke ("AddTime");
		}
	}

	void AddTime ()
	{
		time++;
		if (time < 55) {
			if (time % 3 == 0) {
				Instantiate (enemyObj);
			}
			if (time % 5 == 0) {
				Instantiate (enemyObj1);
			}
			if (time % 7 == 0) {
				Instantiate (enemyObj2);
			}
			if (time == 20 || time == 40) {
				Instantiate (propObj);
			}
			if (time == 20) {
				guitext.enabled = true;
				propPlane1.GetComponent<UITexture> ().enabled = true;
				guitext.material.color = Color.red;
				guitext.fontSize = 30;
				guitext.text = "Bullet Adding Prop!";
			}
			if (time == 23) {
				guitext.enabled = false;
				propPlane1.GetComponent<UITexture> ().enabled = false;
			}
			if (time > 40 && (time % 4 == 0)) {
				Instantiate (enemyObj3);
			}
			if (time == 45) {
				Instantiate (propObj1);
				guitext.enabled = true;
				propPlane2.GetComponent<UITexture> ().enabled = true;
				guitext.material.color = Color.red;
				guitext.fontSize = 30;
				guitext.text = "Blood Restoring Prop!";
			}
			if (time == 48) {
				guitext.enabled = false;
				propPlane2.GetComponent<UITexture> ().enabled = false;
			}
		}
		if (time == 75) {
			Instantiate (enemyObj4);
			Instantiate (propObj1);
			guitext.enabled = true;
			guitext.material.color = Color.red;
			guitext.fontSize = 50;
			guitext.text = "WARNING! BOSS COMING!";
		}
		if (time == 77) {
			guitext.enabled = false;
		}
	}
}
