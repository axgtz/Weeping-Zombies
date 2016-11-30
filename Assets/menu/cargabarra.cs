using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class cargabarra : MonoBehaviour 
{
	public Slider barra;
	public GameObject imagecargando;
	public AsyncOperation asyn;

	public void ClickCarga(int nivel)

	{

		imagecargando.SetActive (true);
		StartCoroutine (Loadlevelslider());
	}

	IEnumerator Loadlevelslider()
	{
		asyn = Application.LoadLevelAsync(3);
		while (!asyn.isDone) 
		{
			barra.value = asyn.progress;
			yield return null;

		}
	}





}
