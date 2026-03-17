using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Button))]
public class InvestigationItem : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private InvestigationSystem m_investigationSystem;

    [SerializeField] private InvestigationItemType m_investigationItemType;
    public InvestigationItemType InvestigationItemType { get => m_investigationItemType; }

    private Button m_button;
    public Button Button { get => m_button; }

    private bool b_selected = false;

    private void Awake()
    {
        m_button = GetComponent<Button>();
        m_investigationSystem = GetComponentInParent<InvestigationSystem>();
        m_button.onClick.AddListener(this.OnSelect);
    }
    private void Start()
    {
        Hide();
    }

    public void OnSelect()
    {
        b_selected = true;

        Show();

        m_button.interactable = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (b_selected == false && m_investigationSystem.IsHalted == false)
        {
            Show();
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (b_selected == false && m_investigationSystem.IsHalted == false)
        {
            Hide();
        }
    }

    private void Show()
    {
        m_button.image.color =
            new Color
            (
                m_button.image.color.r,
                m_button.image.color.g,
                m_button.image.color.b,
                1
            );


    }

    private void Hide()
    {
        m_button.image.color =
            new Color
            (
                m_button.image.color.r,
                m_button.image.color.g,
                m_button.image.color.b,
                0
            );
    }
}
