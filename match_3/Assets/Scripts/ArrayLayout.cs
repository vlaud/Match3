using UnityEngine;
using System.Collections;

[System.Serializable]
public class ArrayLayout  {

	[System.Serializable]
	public struct rowData{
		public bool[] row;
	}

    public ArrayLayout(int width, int height)
    {
        rows = new rowData[height];

        for (int i = 0; i < height; i++)
        {
            rows[i].row = new bool[width];
        }
    }

    public Grid grid;
    public rowData[] rows = new rowData[14]; //Grid of 7x7
}
