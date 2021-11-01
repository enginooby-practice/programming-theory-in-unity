using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUIHandler : MonoBehaviour {
  public void LoadMainScene() {
    UnityEngine.SceneManagement.SceneManager.LoadScene(1);
  }

  public void ExitApp() {
#if UNITY_EDITOR
    UnityEditor.EditorApplication.ExitPlaymode();
#else
    Application.Quit();
#endif
  }
}
