using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

[RequireComponent(typeof(Image))]
public class ImageFader : MonoBehaviour
{
    private Image m_image;
    [SerializeField] private Color m_defaultColor;
    [SerializeField] private bool m_setDefaultColorOnAwake;

    private void Awake()
    {
        m_image = GetComponent<Image>();

        if (m_setDefaultColorOnAwake)
        {
            m_defaultColor = m_image.color;
        }
    }

    public void FadeToColor(Color p_color, float p_time)
    {
        FadeTo(p_color, p_time);
    }

    public void FadeToDefault(float p_time)
    {
        FadeTo(m_defaultColor, p_time);
    }

    private void FadeTo(Color p_color, float p_time)
    {
        m_image.DOColor(p_color, p_time);   
    }    
}
