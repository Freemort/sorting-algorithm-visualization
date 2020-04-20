﻿using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Factory pattern for sorting algoritms
/// </summary>
public static class SortingAlgorithmCreator
{
    public static SortingAlgorithmBase GetAlgorithm(ISortingHandleable handleable, SortingTypes sortingType)
    {
        SortingAlgorithmBase result = null;

        switch (sortingType)
        {
            case SortingTypes.Bubble:
                result = SortingAlgorithmCreator.CreateBubbleSorting(handleable);
                break;
            case SortingTypes.Shaker:
                break;
            case SortingTypes.QuickSort:
                break;
        }
        return result;
    }

    private static SortingAlgorithmBase CreateBubbleSorting(ISortingHandleable handleable)
    {
        return new BubbleSorting(handleable);
    }
}