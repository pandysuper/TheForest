using UnityEngine;

public class QuitOnEscape : MonoBehaviour
{
	private void Update()
	{
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Quit();
		}
	}
	void Quit()
	{
#if UNITY_EDITOR 
		UnityEditor.EditorApplication.isPlaying = false;
#else
		Application.Quit();
#endif
	}
}
