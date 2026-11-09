# django/db/models/functions/text

- Subject: django/db/models/functions/text (id `854a2540-c096-4e45-8b6c-81befeafff2b`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 14 of 61
- Conflicts: 0
- Gaps: 0

## Facts

- as_sqlite = pipes_concat_sql [4303c046]
- def __init__(self, *expressions, **extra): if len(expressions) < 2: raise ValueError("Concat must take at least two expressions") paired = self._paired(expressions, output_field=extra.get("output_field")) super().__init__(paired, **extra) [4425c9ce]
- def __init__(self, expression, length, **extra): """ expression: the name of a field, or an expression returning a string length: the number of characters to return from the start of the string """ if not hasattr(length, "resolve_expression"): if length < 1: raise ValueError("'length' must be greater than 0.") super().__init__(expression, length, **extra) [aa3a0553]
- def __init__(self, expression, length, fill_text=Value(" "), **extra): if ( not hasattr(length, "resolve_expression") and length is not None and length < 0 ): raise ValueError("'length' must be greater or equal to 0.") super().__init__(expression, length, fill_text, **extra) [3c6191ea]
- def __init__(self, expression, number, **extra): if ( not hasattr(number, "resolve_expression") and number is not None and number < 0 ): raise ValueError("'number' must be greater or equal to 0.") super().__init__(expression, number, **extra) [b586dde9]
- def __init__(self, expression, pos, length=None, **extra): """ expression: the name of a field, or an expression returning a string pos: an integer > 0, or an expression returning an integer length: an optional number of characters to return """ if not hasattr(pos, "resolve_expression"): if pos < 1: raise ValueError("'pos' must be greater than 0") expressions = [expression, pos] if length is not None: expressions.append(length) super().__init__(*expressions, **extra) [47b2a930]
- def __init__(self, expression, text, replacement=Value(""), **extra): super().__init__(expression, text, replacement, **extra) [b45f1253]
- def _paired(self, expressions, output_field): # wrap pairs of expressions in successive concat functions # exp = [a, b, c, d] # -> ConcatPair(a, ConcatPair(b, ConcatPair(c, d)))) if len(expressions) == 2: return ConcatPair(*expressions, output_field=output_field) return ConcatPair( expressions[0], self._paired(expressions[1:], output_field=output_field), output_field=output_field, ) [32593c86]
- def as_mysql(self, compiler, connection, **extra_context): # Use CONCAT_WS with an empty separator so that NULLs are ignored. return super().as_sql( compiler, connection, function="CONCAT_WS", template="%(function)s('', %(expressions)s)", **extra_context, ) [ea02bf8a]
- def as_mysql(self, compiler, connection, **extra_context): return super().as_sql( compiler, connection, function="CHAR", template="%(function)s(%(expressions)s USING utf16)", **extra_context, ) [00464537]
- def as_mysql(self, compiler, connection, **extra_context): return super().as_sql( compiler, connection, function="CHAR_LENGTH", **extra_context ) [c0edf1fa]
- def as_mysql(self, compiler, connection, **extra_context): return super().as_sql(compiler, connection, function="ORD", **extra_context) [89b963f0]
- def as_oracle(self, compiler, connection, **extra_context): raise NotSupportedError("SHA224 is not supported on Oracle.") [7151fe26]
- function = "CONCAT" [01eb2aae]

## Beyond the budget

44 more facts did not fit in the budget: [66bd9f83] [3bd3f87e] [58378156] [cc1f80bb] [4c1c628c] [40bce517] [888525fc] [c753b2de] [c5882451] [2cf50ad8] [a4df6a41] [1eaf4f24] [ae6e3d1a] [e382d347] [cdbcac31] [30e06027] [2f3e46d7] [60469491] [de27a9ea] [227bcd46] [db798528] [f04c2dd5] [40a6f5ed] [c0cb1508] [b3f7f588] [91bacd45] [488e5af7] [699de7bc] [40d4006e] [825bf7c8] [9d93f927] [e51e34b1] [93fe9ea4] [1ad9f1ba] [eafb12da] [d581d857] [43a638a7] [e1fac33b] [f229f86e] [b43e045d] [591d51de] [6acd2e29] [fe1cc9b8] [3abea421]
