from ftplib import print_line


def is_isomorphic(s: str, t: str) -> bool:
    if len(s) != len(t):
        return False

    map_st = {}
    map_ts = {}

    for cs, ct in zip(s, t):
        if cs in map_st:
            if map_st[cs] != ct:
                return False
        else:
            map_st[cs] = ct

        if ct in map_ts:
            if map_ts[ct] != cs:
                return False
        else:
            map_ts[ct] = cs

    return True

result = is_isomorphic("egg", "add")
# print(result)  # True


def Is_Palindrome(word):
        left = 0
        right = len(word) - 1
        while left < right:
            if word[left] != word[right]:
                return False

            left += 1
            right -= 1

        return True

print_line(Is_Palindrome("racecar"))  # True
print(Is_Palindrome("hello"))  # False
