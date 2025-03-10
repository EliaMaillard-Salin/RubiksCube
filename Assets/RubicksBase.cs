using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubicksBase : MonoBehaviour
{
    int m_selectedLine;
    int m_selectedColumn;

    public RubiksLine m_line1; // Left
    public RubiksLine m_line2; // Middle
    public RubiksLine m_line3; // Right

    public RubiksColumn m_column1; // Top
    public RubiksColumn m_column2; // Middle
    public RubiksColumn m_column3; // Bottom

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeColumnSelect(RubiksColumn col)
    {
        m_column1.m_isSelected = false;
        m_column2.m_isSelected = false;
        m_column3.m_isSelected = false;
        col.m_isSelected = true;
    }
    public  void ChangeLineSelect(RubiksLine line)
    {
        m_line1.m_isSelected = false;
        m_line2.m_isSelected = false;
        m_line3.m_isSelected = false;
        line.m_isSelected = true;
    }

    public void RotateLine(RubiksLine line, int direction) // 0 down 1 up 
    {
        if (line.lineCount == 3) // Right
        {

            if (direction == 0)
            {
                m_column1.m_frontRight = line.m_topBack;
                m_column1.m_middleRight = line.m_middleBack;
                m_column1.m_backRight = line.m_bottomBack;

                m_column2.m_frontRight = line.m_topMiddle;
                m_column2.m_middleRight = line.m_Center;
                m_column2.m_backRight = line.m_bottomMiddle;

                m_column3.m_frontRight = line.m_topFront;
                m_column3.m_middleRight = line.m_middleFront;
                m_column3.m_backRight = line.m_bottomFront;

            }

            if (direction == 1)
            {
                m_column1.m_frontRight = line.m_bottomFront;
                m_column1.m_middleRight = line.m_middleFront;
                m_column1.m_backRight = line.m_topFront;

                m_column2.m_frontRight = line.m_bottomMiddle;
                m_column2.m_middleRight = line.m_Center;
                m_column2.m_backRight = line.m_topMiddle;

                m_column3.m_frontRight = line.m_bottomBack;
                m_column3.m_middleRight = line.m_middleBack;
                m_column3.m_backRight = line.m_topBack;
            }
        
        }
        if (line.lineCount == 2) // Middle
        {

            if (direction == 0)
            {
                m_column1.m_frontMiddle = line.m_topBack;
                m_column1.m_Center = line.m_middleBack;
                m_column1.m_backMiddle = line.m_bottomBack;

                m_column2.m_frontMiddle = line.m_topMiddle;
                m_column2.m_Center = line.m_Center;
                m_column2.m_backMiddle = line.m_bottomMiddle;

                m_column3.m_frontMiddle = line.m_topFront;
                m_column3.m_Center = line.m_middleFront;
                m_column3.m_backMiddle = line.m_bottomFront;

            }

            if (direction == 1)
            {
                m_column1.m_frontMiddle = line.m_bottomFront;
                m_column1.m_Center = line.m_middleFront;
                m_column1.m_backMiddle = line.m_topFront;

                m_column2.m_frontMiddle = line.m_bottomMiddle;
                m_column2.m_Center = line.m_Center;
                m_column2.m_backMiddle = line.m_topMiddle;

                m_column3.m_frontMiddle = line.m_bottomBack;
                m_column3.m_Center = line.m_middleBack;
                m_column3.m_backMiddle = line.m_topBack;
            }

        }
        if (line.lineCount == 1) // Left
        {

            if (direction == 0)
            {
                m_column1.m_frontLeft = line.m_topBack;
                m_column1.m_middleLeft = line.m_middleBack;
                m_column1.m_backLeft = line.m_bottomBack;

                m_column2.m_frontLeft = line.m_topMiddle;
                m_column2.m_middleLeft = line.m_Center;
                m_column2.m_backLeft = line.m_bottomMiddle;

                m_column3.m_frontLeft = line.m_topFront;
                m_column3.m_middleLeft = line.m_middleFront;
                m_column3.m_backLeft = line.m_bottomFront;

            }

            if (direction == 1)
            {
                m_column1.m_frontLeft = line.m_bottomFront;
                m_column1.m_middleLeft = line.m_middleFront;
                m_column1.m_backLeft = line.m_topFront;

                m_column2.m_frontLeft = line.m_bottomMiddle;
                m_column2.m_middleLeft  = line.m_Center;
                m_column2.m_backLeft = line.m_topMiddle;

                m_column3.m_frontLeft  = line.m_bottomBack;
                m_column3.m_middleLeft  = line.m_middleBack;
                m_column3.m_backLeft = line.m_topBack;
            }
        }  
    }
    
    public void RotateColumn(RubiksColumn column, int direction) // 0 Left 1 Right
    {
        if (column.columnCount == 3) // Bottom
        {

            if (direction == 0)
            {
                m_line1.m_bottomFront = column.m_frontRight;
                m_line1.m_bottomMiddle = column.m_frontMiddle;
                m_line1.m_bottomBack = column.m_frontLeft;

                m_line2.m_bottomFront = column.m_middleRight;
                m_line2.m_bottomMiddle = column.m_Center;
                m_line2.m_bottomBack = column.m_middleLeft;

                m_line3.m_bottomFront = column.m_backRight;
                m_line3.m_bottomMiddle = column.m_backMiddle;
                m_line3.m_bottomBack = column.m_backLeft;

            }

            if (direction == 1)
            {
                m_line1.m_bottomFront = column.m_backLeft;
                m_line1.m_bottomMiddle = column.m_backMiddle;
                m_line1.m_bottomBack = column.m_backRight;

                m_line2.m_bottomFront = column.m_middleLeft;
                m_line2.m_bottomMiddle = column.m_Center;
                m_line2.m_bottomBack = column.m_middleRight;

                m_line3.m_bottomFront = column.m_frontLeft;
                m_line3.m_bottomMiddle = column.m_frontMiddle;
                m_line3.m_bottomBack = column.m_frontRight;
            }
        
        }
        if (column.columnCount == 2) // Middle
        {

            if (direction == 0)
            {
                m_line1.m_middleFront = column.m_frontRight;
                m_line1.m_Center = column.m_frontMiddle;
                m_line1.m_middleBack = column.m_frontLeft;

                m_line2.m_middleFront = column.m_middleRight;
                m_line2.m_Center = column.m_Center;
                m_line2.m_middleBack = column.m_middleLeft;

                m_line3.m_middleFront = column.m_backRight;
                m_line3.m_Center = column.m_backMiddle;
                m_line3.m_middleBack = column.m_backLeft;

            }

            if (direction == 1)
            {
                m_line1.m_middleFront = column.m_backLeft;
                m_line1.m_Center = column.m_backMiddle;
                m_line1.m_middleBack = column.m_backRight;

                m_line2.m_middleFront = column.m_middleLeft;
                m_line2.m_Center = column.m_Center;
                m_line2.m_middleBack = column.m_middleRight;

                m_line3.m_middleFront = column.m_frontLeft;
                m_line3.m_Center = column.m_frontMiddle;
                m_line3.m_middleBack = column.m_frontRight;
            }

        }
        if (column.columnCount == 1) // Top
        {

            if (direction == 0)
            {
                m_line1.m_topFront = column.m_frontRight;
                m_line1.m_topMiddle = column.m_frontMiddle;
                m_line1.m_topBack = column.m_frontLeft;

                m_line2.m_topFront = column.m_middleRight;
                m_line2.m_topMiddle = column.m_Center;
                m_line2.m_topBack = column.m_middleLeft;

                m_line3.m_topFront = column.m_backRight;
                m_line3.m_topMiddle = column.m_backMiddle;
                m_line3.m_topBack = column.m_backLeft;

            }

            if (direction == 1)
            {
                m_line1.m_topFront = column.m_backLeft;
                m_line1.m_topMiddle = column.m_backMiddle;
                m_line1.m_topBack = column.m_backRight;

                m_line2.m_topFront = column.m_middleLeft;
                m_line2.m_topMiddle = column.m_Center;
                m_line2.m_topBack = column.m_middleRight;

                m_line3.m_topFront = column.m_frontLeft;
                m_line3.m_topMiddle = column.m_frontMiddle;
                m_line3.m_topBack = column.m_frontRight;
            }
        }  
    }
}
