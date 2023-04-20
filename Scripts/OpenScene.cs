using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenScene : MonoBehaviour
{
    public void MenuScene()
    {
        SceneManager.LoadScene("Menu");
    }

    public void StartScene()
    {
        SceneManager.LoadScene("Start");
    }

    public void SettingsScene()
    {
        SceneManager.LoadScene("Settings");
    }

    public void StudioScene()
    {
        SceneManager.LoadScene("Studio");
    }

    public void AnimatorScene()
    {
        SceneManager.LoadScene("Animator");
    }

    public void PoserScene()
    {
        SceneManager.LoadScene("Poser");
    }

    public void CaracterCreatorScene()
    {
        SceneManager.LoadScene("CaracterCreator");
    }
}
