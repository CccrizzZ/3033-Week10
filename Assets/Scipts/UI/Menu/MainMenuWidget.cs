using UnityEngine;

public class MainMenuWidget : MenuWidget
{
   public void OpenStartMenu()
    {
        M_Script.EnableMenu("LoadMenu");
    }

    public void OpenOptionsMenu()
    {
        M_Script.EnableMenu("OptionsMenu");
    }

    public void QuitApplication()
    {
        Application.Quit();
    }
}
