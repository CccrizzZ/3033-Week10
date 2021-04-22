using UnityEngine;


public abstract class MenuWidget : MonoBehaviour
{
    [SerializeField]
    private string MenuName;




    protected MenuScript M_Script;

    private void Awake()
    {
        M_Script = FindObjectOfType<MenuScript>();
        if (M_Script)
        {
            M_Script.AddMenu(MenuName, this);
        }
        else
        {
            Debug.LogError("Menu Controller Not Found.");
        }
    }



    public void ReturnToRootMenu()
    {
        if (M_Script)
        {
            M_Script.ReturnToRootMenu();
        }
    }


    public void EnableWidget()
    {
        gameObject.SetActive(true);
    }




    public void DisableWidget()
    {
        gameObject.SetActive(false);

    }

}

   

