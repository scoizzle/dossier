# django/template/defaultfilters

- Subject: django/template/defaultfilters (id `9b0eed0e-1c88-468f-a78f-305c7373e513`)
- Kind: subject
- Budget: 1200 tokens
- Used: 893 tokens
- Facts shown: 14 of 118
- Conflicts: 0
- Gaps: 0

## Facts

- <li>States <ul> <li>Kansas <ul> <li>Lawrence</li> <li>Topeka</li> </ul> </li> <li>Illinois</li> </ul> </li> """ if autoescape: escaper = conditional_escape else: [e721d1be]
- def escaper(x): return x [1c109dc9108f15cf-2]
- def resolve(value): for part in parts: try: value = value[part] except (AttributeError, IndexError, KeyError, TypeError, ValueError): value = getattr(value, part) return value [e533eab6]
- return resolve else: return itemgetter(arg) [d0193567]
- # Avoid conversion to scientific notation by accessing `sign`, `digits`, # and `exponent` from Decimal.as_tuple() directly. rounded_d = d.quantize(exp, ROUND_HALF_UP, Context(prec=prec)) sign, digits, exponent = rounded_d.as_tuple() digits = [str(digit) for digit in reversed(digits)] while len(digits) <= abs(exponent): digits.append("0") digits.insert(-exponent, ".") if sign and rounded_d: digits.append("-") number = "".join(reversed(digits)) return mark_safe( formats.number_format( number, abs(p), use_l10n=use_l10n, force_grouping=force_grouping, ) ) [d25be576]
- # Values with more than 200 digits, or with a large exponent, are returned # "as is" to avoid high memory consumption and potential denial-of-service # attacks. The cut-off of 200 is consistent with # django.utils.numberformat.floatformat(). if number_of_digits_and_exponent_sum > 200: return input_val [68df0c73]
- * If value is 0, cand{{ value|pluralize:"y,ies" }} display "candies". * If value is 1, cand{{ value|pluralize:"y,ies" }} display "candy". * If value is 2, cand{{ value|pluralize:"y,ies" }} display "candies". """ if "," not in arg: arg = "," + arg bits = arg.split(",") if len(bits) > 2: return "" singular_suffix, plural_suffix = bits[:2] [e5b765e9]
- * If value is 0, class{{ value|pluralize:"es" }} display "classes". * If value is 1, class{{ value|pluralize:"es" }} display "class". * If value is 2, class{{ value|pluralize:"es" }} display "classes". [01515d9d]
- * If value is 0, vote{{ value|pluralize }} display "votes". * If value is 1, vote{{ value|pluralize }} display "vote". * If value is 2, vote{{ value|pluralize }} display "votes". [4be334b3]
- * num1 = 34.23234 * num2 = 34.00000 * num3 = 34.26000 * {{ num1|floatformat }} displays "34.2" * {{ num2|floatformat }} displays "34" * {{ num3|floatformat }} displays "34.3" [14743187]
- * {{ 6666.6666|floatformat:"2g" }} displays "6,666.67" * {{ 10000|floatformat:"g" }} displays "10,000" [b42d5069]
- * {{ 66666.6666|floatformat:"2" }} displays "66666,67" * {{ 66666.6666|floatformat:"2u" }} displays "66666.67" [199d7821]
- * {{ num1|floatformat:"-3" }} displays "34.232" * {{ num2|floatformat:"-3" }} displays "34" * {{ num3|floatformat:"-3" }} displays "34.260" [2fe4e8f1]
- >>> _property_resolver(1)('abc') 'b' >>> _property_resolver('1')('abc') Traceback (most recent call last): ... TypeError: string indices must be integers >>> class Foo: ... a = 42 ... b = 3.14 ... c = 'Hey!' >>> _property_resolver('b')(Foo()) 3.14 """ try: float(arg) except ValueError: if VARIABLE_ATTRIBUTE_SEPARATOR + "_" in arg or arg[0] == "_": raise AttributeError("Access to private variables is forbidden.") parts = arg.split(VARIABLE_ATTRIBUTE_SEPARATOR) [da798ad1]

## Beyond the budget

99 more facts did not fit in the budget: [b68a57f4] [4e4bd1a8] [71935d32] [6a30711b] [bc8fff57] [9ac1e843] [b6a7c45c] [e98901df] [94d42cd0] [b9666bef] [c4058a80] [7b57cd61] [22ff6799] [b1c736d7] [0aa33485] [b4fb9f4c] [e400ef15] [871c7916] [57ec0ef6] [ac0e1648] [59da3159] [76177ff4] [858711fc] [89b44d04] [cee5a63d] [e7f37144] [5cd8dfe6] [24c386fc] [6bf8d6bd] [e154e3ed] [c44db503] [6e86ae0f] [6032f536] [a0a3c1fe] [f1ce568d] [509e849d] [7b3bc0f5] [7818ff20] [b5775528] [b24b248c] [2ed0315d] [894f4987] [14ee6938] [eb96c9a1] [747f1546] [a5b8c925] [81d38987] [7a5d0779] [7d200675] [53f9f620] [0b370874] [ebfc6ec9] [a97c84c3] [eb5b208f] [ba04fd43] [d930b019] [997a1602] [d6a67309] [27121bd3] [9a0b3ee9] [76af5bae] [cb378181] [5abefaa9] [e40ffc19] [43bd82ef] [4673bec4] [bf9825bb] [82c8c01b] [877bdb27] [d69507e0] [c3c92b40] [e5e18dcf] [75cbc35a] [c14def38] [6008c47d] [35097ed3] [b985ea08] [0aa58e1f] [bf48d101] [738ff670] [512746be] [7a04036d] [4617656f] [27ddbd2a] [0b45da45] [d4b24138] [058cf33a] [c072e9bf] [2b4410a2] [5730ef19] [e516a44b] [aea3aef3] [3f1c480a] [08d21d3a] [55fab0bb] [89a8cb9a] [ad97a89d] [a4fd8b90] [c8c0ccd629deb6b1-3]
