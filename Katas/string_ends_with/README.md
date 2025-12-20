# Notes

Generate with ChatGPT-5 and adding my own comments

# String Ends With (Codewars)

Check whether a string `text` ends with a given substring `ending`.

## Overview

- Input: two strings, `text` and `ending`.
- Output: `True` if `text` ends with `ending`, else `False`.
- Matching is case-sensitive.

## Examples

- `solution("samurai", "ai")` → `True`
- `solution("hello", "world")` → `False`
- `solution("abc", "")` → `True` (empty ending)
- `solution("abc", "abcd")` → `False` (ending longer than text)

## Approaches

- Built-in: `text.endswith(ending)` — simplest and reliable.
- Without built-ins: `text[-len(ending):] == ending` (treat empty `ending` as `True`).

## Current Script

The runner in [string*ends_with/string_ends_with*.py](string_ends_with/string_ends_with_.py) compares characters from the end using negative indices and prints matches.

The solution is a novice solution but without using any AI

## Run Locally (Windows)

```powershell
python string_ends_with\string_ends_with_.py
```

Or with an explicit Python path:

```powershell
& "C:/Program Files/Python313/python.exe" c:/codewars/string_ends_with/string_ends_with_.py
```

## Edge Cases

- Empty `ending` should return `True`.
- If `len(ending) > len(text)`, return `False`.
- Works with Unicode characters; comparison is exact.

## Complexity

- Both `endswith` and slicing-based checks run in $O(m)$ time where $m = \text{len(ending)}$, with $O(1)$ extra space.
