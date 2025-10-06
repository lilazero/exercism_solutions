using System;
using System.Linq;
using System.Collections.Generic;

/// <summary>
/// Provides a method to determine if a given set of dominoes can be chained together.
/// </summary>
public static class Dominoes
{
    /// <summary>
    /// Determines if the given set of dominoes can be chained together.
    /// </summary>
    /// <param name="dominoes">The set of dominoes to check.</param>
    /// <returns>True if the dominoes can be chained together, false otherwise.</returns>
    public static bool CanChain(IEnumerable<(int, int)> dominoes) => TryChainDominoes(dominoes.ToList(), (0, 0));

    /// <summary>
    /// Recursively tries to chain the given set of dominoes together.
    /// </summary>
    /// <param name="dominoes">The set of dominoes to chain.</param>
    /// <param name="state">The current state of the chain.</param>
    /// <returns>True if the dominoes can be chained together, false otherwise.</returns>
    private static bool TryChainDominoes(List<(int, int)> dominoes, (int first, int last) state)
    {
        if (dominoes.Count == 0 && state.first == state.last)
        {
            return true;
        }

        for (int i = 0; i < dominoes.Count; i++)
        {
            var (left, right) = dominoes[i];

            if (state.last == 0)
            {
                state = (left, right);
            }
            else if (state.last == left)
            {
                state.last = right;
            }
            else if (state.last == right)
            {
                state.last = left;
            }
            else
            {
                continue;
            }

            var remaining = new List<(int, int)>(dominoes);
            remaining.RemoveAt(i);

            if (TryChainDominoes(remaining, state))
            {
                return true;
            }
        }

        return false;
    }
}
