using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Tutorial : MonoBehaviour {

	public void ButtonTutorial()
    {
        SceneManager.LoadScene("ButtonTutorial");
    }

    public void BlockTutorial()
    {
        SceneManager.LoadScene("BlockTutorial");
    }

    public void Quit()
    {
        SceneManager.LoadScene("main");
    }
}
