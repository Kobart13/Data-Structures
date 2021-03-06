using System;
using System.Collections.Generic;

public abstract class AbstractHeap
{
    #region Members
    protected List<int> elements;
    #endregion

    #region Constructor
    public AbstractHeap()
    {
        elements = new List<int>();
    }
    #endregion

    #region Protected Methods
    protected int GetSize()
    {
        return elements.Count;
    }

    protected int GetLeft(int index)
    {
        return 2 * index + 1;
    }

    protected int GetRight(int index)
    {
        return 2 * index + 2;
    }

    protected void Swap(int first, int second)
    {
        int temp = elements[first];
        elements[first] = elements[second];
        elements[second] = temp;
    }

    protected int GetParent(int index)
    {
        if (index <= 0)
            return -1;

        return (index - 1) / 2;
    }

    protected int GetValueOfHeapAtTop()
    {
        return this.elements.Count > 0 ? this.elements[0] : default(int);
    }
    #endregion

    #region Abstract Methods
    public abstract void Add(int item);
    protected abstract void HeapifyUp(int index);
    protected abstract void HeapifyDown(int index);
    #endregion
}