using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubiksColumn : MonoBehaviour
{
    public GameObject m_base;
    RubicksBase m_scriptBase;

    public int columnCount;

    public GameObject m_frontLeft;
    public GameObject m_frontMiddle;
    public GameObject m_frontRight;

    public GameObject m_middleLeft;
    public GameObject m_Center;
    public GameObject m_middleRight;

    public GameObject m_backLeft;
    public GameObject m_backMiddle;
    public GameObject m_backRight;

    public bool m_isSelected;

    // Start is called before the first frame update
    void Start()
    {
        m_scriptBase = m_base.GetComponent<RubicksBase>();
    }

    void SetParents()
    {
        m_frontLeft.transform.SetParent(gameObject.transform);
        m_frontMiddle.transform.SetParent(gameObject.transform);
        m_frontRight.transform.SetParent(gameObject.transform);

        m_middleLeft.transform.SetParent(gameObject.transform);
        m_Center.transform.SetParent(gameObject.transform);
        m_middleRight.transform.SetParent(gameObject.transform);

        m_backLeft.transform.SetParent(gameObject.transform);
        m_backMiddle.transform.SetParent(gameObject.transform);
        m_backRight.transform.SetParent(gameObject.transform);
    }

    void UnSetParents()
    {
        m_frontLeft.transform.SetParent(m_base.transform);
        m_frontMiddle.transform.SetParent(m_base.transform);
        m_frontRight.transform.SetParent(m_base.transform);

        m_middleLeft.transform.SetParent(m_base.transform);
        m_Center.transform.SetParent(m_base.transform);
        m_middleRight.transform.SetParent(m_base.transform);

        m_backLeft.transform.SetParent(m_base.transform);
        m_backMiddle.transform.SetParent(m_base.transform);
        m_backRight.transform.SetParent(m_base.transform);
    }

    void RotateRight()
    {
        SetParents();
        gameObject.transform.Rotate(new Vector3(0.0f, 1.0f, 0.0f), -90.0f);
        m_scriptBase.RotateColumn(this, 1);

        GameObject tempFrontLeft = m_frontLeft;
        GameObject tempFrontMiddle = m_frontMiddle;
        GameObject tempFrontRight = m_frontRight;

        m_frontRight = tempFrontLeft;
        m_frontMiddle = m_middleLeft;
        m_frontLeft = m_backLeft;
        m_middleLeft = m_backMiddle;
        m_backLeft = m_backRight;
        m_backMiddle = m_middleRight;
        m_backRight = tempFrontRight;
        m_middleRight = tempFrontMiddle;

        UnSetParents();
    }


    void RotateLeft()
    {
        SetParents();
        gameObject.transform.Rotate(new Vector3(0.0f, 1.0f, 0.0f), 90.0f);
        m_scriptBase.RotateColumn(this, 0);

        GameObject tempFrontLeft = m_frontLeft;
        GameObject tempFrontMiddle = m_frontMiddle;
        GameObject tempFrontRight = m_frontRight;

        m_frontLeft = m_frontRight;
        m_frontMiddle = m_middleRight;
        m_frontRight = m_backRight;
        m_middleRight = m_backMiddle;
        m_backRight = m_backLeft;
        m_backMiddle = m_middleLeft;
        m_backLeft = tempFrontLeft;
        m_middleLeft = tempFrontMiddle;

        UnSetParents();
    }


    // Update is called once per frame
    void Update()
    {
        if (m_isSelected)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                RotateLeft();
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                RotateRight();
            }
        }
    }

    private void OnMouseDown()
    {
        m_scriptBase.ChangeColumnSelect(this);
        gameObject.GetComponent<MeshRenderer>().enabled = true;
    }
}
