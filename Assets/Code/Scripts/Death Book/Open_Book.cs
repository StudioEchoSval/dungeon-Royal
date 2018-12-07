using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_Book : MonoBehaviour
{

    public GameObject DeathBook;
    bool BookIsOpen  = false;


	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}


    public void OpenBook()
    {
        Debug.Log("  test livre" + BookIsOpen);

        if (BookIsOpen == false)
        {
            DeathBook.SetActive(true);
            BookIsOpen = true;
            Debug.Log(" cas  ouvert" + BookIsOpen);
        }
       
       else if (BookIsOpen == true)
        {
            DeathBook.SetActive(false);
            BookIsOpen = false;
            Debug.Log(" cas  fermer :" + BookIsOpen);
        }
    }



    public void closeBook()
    {
        DeathBook.SetActive(false);
        BookIsOpen = false;
        Debug.Log(" cas  fermer  2 " + BookIsOpen);
    }

}
