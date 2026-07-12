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
print(result)  # True