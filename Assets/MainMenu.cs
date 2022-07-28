using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;          // added to control scene management

public class MainMenu : MonoBehaviour
{
    
    public void PlayGame()
    {
        // ht-load el scene elly 3leh el dor b3deeha
        // btzabat el edwar mn el scene manager
        // btro7lo mn unity, file >> Build Settings
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Level1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);      // 2 dh rakam Level1
    }

    public void QuitGame()
    {
        Debug.Log("Quitting Game! Bueno Adios");
        Application.Quit();     // dh msh byezhar fl unity editor, fa zwd debug lyk
                                // hysht8l lama t3ml build lel game tho
    }
}
