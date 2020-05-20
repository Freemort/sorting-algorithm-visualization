﻿using System.Collections.Generic;

public interface ISortingHandable
{
    List<int> Array { get; set; }
    void RelocateElements(int fromIndex, int toIndex);
    void MarkElements(params ElementColor[] markedElements);
    void FinishSorting();
}