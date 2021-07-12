using UnityEngine;
using UnityEngine.SceneManagement;


// What happens when the game starts, you'll have these buttons that you can click

public class MenuController : MonoBehaviour
    {

    public void OnClickPlayButton()
    {
        SceneManager.LoadScene("MainScene");
    }

    // What happens when you click on "ObjectiveButton"

    public void OnClickObjectiveButton()
    {
        SceneManager.LoadScene("Objective");
    }

    // What happens when you click on "CreditsButton"

    public void OnClickCreditsButton()
    {
        SceneManager.LoadScene("Credits");
    }

    // What happens when you click on "BackButton"

    public void OnClickBackButton()
    {
        SceneManager.LoadScene("Menu");
    }


    // What happens when you click on "QuitButton"

    public void OnClickExitButton()
    {
        Application.Quit();
    }

}
