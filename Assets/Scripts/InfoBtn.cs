using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InfoBtn : MonoBehaviour
{
    public void clicked()
    {
        Debug.Log("Va bene, mi convincerai che il tasto è stato cliccato");
        EventSystem.current.SetSelectedGameObject(null);
    }
}
