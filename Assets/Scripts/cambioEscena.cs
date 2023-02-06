using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambioEscena : MonoBehaviour
{
	public void CambiardeEscena(string nombreEscena)
	{
		SceneManager.LoadScene(nombreEscena);
	}
}
