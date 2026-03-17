using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum InvestigationItemType
{
    SCAR,
    BITE,
    GUT,
    FUR,
    COUNT
}

public class InvestigationSystem : MonoBehaviour
{
    private InvestigationItem[] investigationItems;
    
    private bool b_isHalted = false;
    public bool IsHalted { get => b_isHalted; }

    [SerializeField] private bool m_haltOnStart;

    private void Awake()
    {
        investigationItems = GetComponentsInChildren<InvestigationItem>();
    }

    private void Start()
    {
        if (m_haltOnStart)
        {
            OnHaltItems();
        }
    }

    public void OnDisableItemsOfType(InvestigationItemType p_investigationItemType)
    {
        for (int i = 0; i < investigationItems.Length; i++)
        {
            if (investigationItems[i].InvestigationItemType == p_investigationItemType)
            {
                investigationItems[i].gameObject.SetActive(false);
            }
        }
    }

    public void OnHaltItems()
    {
        b_isHalted = true;

        for (int i = 0; i < investigationItems.Length; i++)
        {
            investigationItems[i].Button.interactable = false;  
        }
    }

    public void OnResetItems()
    {
        b_isHalted = false;

        for (int i = 0; i < investigationItems.Length; i++)
        {
            if (investigationItems[i].gameObject.activeInHierarchy == true)
            {
                investigationItems[i].Button.interactable = true;
            }
        }
    }
}
