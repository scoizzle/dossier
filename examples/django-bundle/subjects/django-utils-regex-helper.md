# django/utils/regex_helper

- Subject: django/utils/regex_helper (id `2a28ba4d-1b3c-4707-851d-2198fa8bf954`)
- Kind: subject
- Budget: 1200 tokens
- Used: 890 tokens
- Facts shown: 10 of 28
- Conflicts: 0
- Gaps: 0

## Facts

- if count == 0: if contains(result[-1], Group): # If we are quantifying a capturing group (or # something containing such a group) and the minimum is # zero, we must also handle the case of one occurrence # being present. All the quantifiers (except {0,0}, # which we conveniently ignore) that have a 0 minimum # also allow a single occurrence. result[-1] = Choice([None, result[-1]]) else: result.pop() elif count > 1: result.extend([result[-1]] * (count - 1)) else: # Anything else is a literal. result.append(ch) [dfaa0a72]
- if consume_next: ch, escaped = next(pattern_iter) consume_next = True except StopIteration: pass except NotImplementedError: # A case of using the disjunctive form. No results for you! return [("", [])] [b65c6f47]
- # A "while" loop is used here because later on we need to be able to peek # at the next character and possibly go around without consuming another # one at the top of the loop. try: ch, escaped = next(pattern_iter) except StopIteration: return [("", [])] [c90a4aac]
- # Consume the trailing '?', if necessary. try: ch, escaped = next(input_iter) except StopIteration: ch = None if ch == "?": ch = None return int(values[0]), ch [c8c79b22]
- (1) For any repeating sections, keeps the minimum number of occurrences permitted (this means zero for optional groups). (2) If an optional group includes parameters, include one occurrence of that group (along with the zero occurrence case from step (1)). (3) Select the first (essentially an arbitrary) element from any character class. Select an arbitrary character for any unordered class (e.g. '.' or '\w') in the pattern. (4) Ignore look-ahead and look-behind assertions. (5) Raise an error on any disjunctive ('|') constructs. [78dcf742]
- Django's URLs for forward resolving are either all positional arguments or all keyword arguments. That is assumed here, as well. Although reverse resolving can be done using positional args when keyword args are specified, the two cannot be mixed in the same reverse() call. """ # Do a linear scan to work out the special features of this pattern. The # idea is that we scan once here and collect all the information we need to # make future decisions. result = [] non_capturing_groups = [] consume_next = True pattern_iter = next_char(iter(pattern)) num_args = 0 [d3fb470e]
- Return the minimum number of occurrences permitted by the quantifier and either None or the next character from the input_iter if the next character is not part of the quantifier. """ if ch in "*?+": try: ch2, escaped = next(input_iter) except StopIteration: ch2 = None if ch2 == "?": ch2 = None if ch == "+": return 1, ch2 return 0, ch2 [b3844c47]
- Yield the next character, along with a boolean indicating whether it is a raw (unescaped) character or not. """ for ch in input_iter: if ch != "\\": yield ch, False continue ch = next(input_iter) representative = ESCAPE_MAPPINGS.get(ch, ch) if representative is None: continue yield representative, True [f3173612]
- def _compile(): # Compile the regex if it was not passed pre-compiled. if isinstance(regex, (str, bytes)): return re.compile(regex, flags) else: assert not flags, "flags must be empty if regex is passed pre-compiled" return regex [e3c9d589]
- return SimpleLazyObject(_compile) [a0ea6aad]

## Beyond the budget

18 more facts did not fit in the budget: [3c0195f6] [618c2100] [ced35357] [07752a2f] [56de7397] [17185ed2] [654f222c] [01bbc8dd] [f2ae41f2] [8bfd1a58] [0d981993] [c76921b5] [4bae9a65] [73a3ebdf] [868ea2bd] [b49a8dd4] [dbafcabf] [dae3b101b4aa9562-10]
