using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    private GameObject submenuParent;
    public GameObject submenuPrefab;

    public void Awake()
    {
        submenuParent = Instantiate(submenuPrefab);
        submenuParent.transform.SetParent(transform,false);
        submenuParent.SetActive(false);
    }

    public void ShowSubMenu()
    {
        submenuParent.SetActive(true);
    }

    public void HideSubMenu()
    {
        submenuParent.SetActive(false);
    }
}
