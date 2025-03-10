using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubiksLine : MonoBehaviour
{
    public GameObject m_base;
    RubicksBase m_scriptBase;

    public int lineCount;

    public GameObject m_topFront;
    public GameObject m_topMiddle;
    public GameObject m_topBack;

    public GameObject m_middleFront;
    public GameObject m_Center;
    public GameObject m_middleBack;
    
    public GameObject m_bottomFront;
    public GameObject m_bottomMiddle;
    public GameObject m_bottomBack;

    public bool m_isSelected;

    // Start is called before the first frame update
    void Start()
    {
        m_scriptBase = m_base.GetComponent<RubicksBase>();
    }

    void SetParents() 
    {
        m_topFront.transform.SetParent(gameObject.transform);
        m_topMiddle.transform.SetParent(gameObject.transform);
        m_topBack.transform.SetParent(gameObject.transform);

        m_middleFront.transform.SetParent(gameObject.transform);
        m_Center.transform.SetParent(gameObject.transform);
        m_middleBack.transform.SetParent(gameObject.transform);

        m_bottomFront.transform.SetParent(gameObject.transform);
        m_bottomMiddle.transform.SetParent(gameObject.transform);
        m_bottomBack.transform.SetParent(gameObject.transform);
    }

    void UnSetParents() 
    {
        m_topFront.transform.SetParent(m_base.transform);
        m_topMiddle.transform.SetParent(m_base.transform);
        m_topBack.transform.SetParent(m_base.transform);

        m_middleFront.transform.SetParent(m_base.transform);
        m_Center.transform.SetParent(m_base.transform);
        m_middleBack.transform.SetParent(m_base.transform);

        m_bottomFront.transform.SetParent(m_base.transform);
        m_bottomMiddle.transform.SetParent(m_base.transform);
        m_bottomBack.transform.SetParent(m_base.transform);
    }

    void RotateUp() 
    {
        SetParents();
        gameObject.transform.Rotate(new Vector3(1.0f, 0.0f, 0.0f), 90.0f);
        m_scriptBase.RotateLine(this,1);

        GameObject tempTopfront = m_topFront;
        GameObject tempTopMiddle = m_topMiddle;
        GameObject tempTopBack = m_topBack;

        m_topFront = m_bottomFront;
        m_topMiddle = m_middleFront;
        m_topBack = tempTopfront;
        m_middleFront = m_bottomMiddle;
        m_bottomFront = m_bottomBack;
        m_bottomMiddle = m_middleBack;
        m_bottomBack = tempTopBack;
        m_middleBack = tempTopMiddle;

    UnSetParents();
    }


    void RotateDown() 
    {
        SetParents();
        gameObject.transform.Rotate(new Vector3(1.0f, 0.0f, 0.0f), -90.0f);
        m_scriptBase.RotateLine(this, 0);

        GameObject tempTopfront = m_topFront;
        GameObject tempTopMiddle = m_topMiddle;
        GameObject tempTopBack = m_topBack;

        m_topFront = m_topBack;
        m_topMiddle = m_middleBack;
        m_topBack = m_bottomBack;
        m_middleBack = m_bottomMiddle;
        m_bottomBack = m_bottomFront;
        m_bottomMiddle = m_middleFront;
        m_bottomFront = tempTopfront;
        m_middleFront = tempTopMiddle;

        UnSetParents();
    }


    // Update is called once per frame
    void Update()
    {
        if (m_isSelected) 
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                RotateDown();
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                RotateUp();
            }
        }
    }

    private void OnMouseDown()
    {
        m_scriptBase.ChangeLineSelect(this);
    }
}
