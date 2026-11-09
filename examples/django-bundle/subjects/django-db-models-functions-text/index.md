# django/db/models/functions/text

- Subject: django/db/models/functions/text (id `4131606c-a022-4d9e-8dab-0af495930647`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2999 tokens
- Facts shown: 61 facts
- Conflicts: 0
- Gaps: 0

## Highlights

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

## All facts

- [66bd9f83] def as_oracle(self, compiler, connection, **extra_context): # REVERSE in Oracle is undocumented and doesn't support multi-byte # strings. Use a special subquery instead. suffix = connection.features.bare_select_suffix sql, params = super().as_sql( compiler, connection, template=( "(SELECT LISTAGG(s) WITHIN GROUP (ORDER BY n DESC) FROM " f"(SELECT LEVEL n, SUBSTR(%(expressions)s, LEVEL, 1) s{suffix} " "CONNECT BY LEVEL <= LENGTH(%(expressions)s)) " "GROUP BY %(expressions)s)" ), **extra_context, ) return sql, params * 3
- [3bd3f87e] def as_oracle(self, compiler, connection, **extra_context): expression, number = self.source_expressions length = None if number is None else Length(expression) * number rpad = RPad(expression, length, expression) return rpad.as_sql(compiler, connection, **extra_context)
- [58378156] def as_oracle(self, compiler, connection, **extra_context): return self.get_substr().as_oracle(compiler, connection, **extra_context)
- [cc1f80bb] def as_oracle(self, compiler, connection, **extra_context): return super().as_sql( compiler, connection, template="%(function)s(%(expressions)s USING NCHAR_CS)", **extra_context, )
- [4c1c628c] def as_oracle(self, compiler, connection, **extra_context): return super().as_sql(compiler, connection, function="SUBSTR", **extra_context)
- [40bce517] def as_postgresql(self, compiler, connection, **extra_context): c = self.copy() c.set_source_expressions( [ ( expression if isinstance(expression.output_field, (CharField, TextField)) else Cast(expression, TextField()) ) for expression in c.get_source_expressions() ] ) return c.pipes_concat_sql(compiler, connection, **extra_context)
- [888525fc] def as_postgresql(self, compiler, connection, **extra_context): return super().as_sql(compiler, connection, function="STRPOS", **extra_context)
- [c753b2de] def as_sqlite(self, compiler, connection, **extra_context): return self.get_substr().as_sqlite(compiler, connection, **extra_context)
- [c5882451] def as_sqlite(self, compiler, connection, **extra_context): return super().as_sql(compiler, connection, function="CHAR", **extra_context)
- [0fbff191] def as_sqlite(self, compiler, connection, **extra_context): return super().as_sql(compiler, connection, function="SUBSTR", **extra_context)
- [3afa1339] def as_sqlite(self, compiler, connection, **extra_context): return super().as_sql(compiler, connection, function="UNICODE", **extra_context)
- [2cf50ad8] def coalesce(self): # null on either side results in null for expression, wrap with # coalesce c = self.copy() c.set_source_expressions( [ Coalesce(expression, Value("")) for expression in c.get_source_expressions() ] ) return c
- [a4df6a41] def get_substr(self): return Substr( self.source_expressions[0], self.source_expressions[1] * Value(-1), self.source_expressions[1], )
- [37e2188a] def get_substr(self): return Substr(self.source_expressions[0], Value(1), self.source_expressions[1])
- [1eaf4f24] def pipes_concat_sql(self, compiler, connection, **extra_context): coalesced = self.coalesce() return super(ConcatPair, coalesced).as_sql( compiler, connection, template="(%(expressions)s)", arg_joiner=" || ", **extra_context, )
- [ae6e3d1a] function = "INSTR" arity = 2 output_field = IntegerField()
- [e382d347] function = "LENGTH" lookup_name = "length" output_field = IntegerField()
- [cdbcac31] function = None template = "%(expressions)s"
- [30e06027] class Chr(Transform): function = "CHR" lookup_name = "chr" output_field = CharField()
- [2f3e46d7] class Concat(Func): """ Concatenate text fields together. Backends that result in an entire null expression when any arguments are null will wrap each argument in coalesce functions to ensure a non-null result. """
- [60469491] class ConcatPair(Func): """ Concatenate two arguments together. This is used by `Concat` because not all backend databases support more than two arguments. """
- [de27a9ea] class LPad(Func): function = "LPAD" output_field = CharField()
- [227bcd46] class LTrim(Transform): function = "LTRIM" lookup_name = "ltrim"
- [db798528] class Left(Func): function = "LEFT" arity = 2 output_field = CharField()
- [f04c2dd5] class Length(Transform): """Return the number of characters in the expression."""
- [40a6f5ed] class Lower(Transform): function = "LOWER" lookup_name = "lower"
- [c0cb1508] class MD5(OracleHashMixin, Transform): function = "MD5" lookup_name = "md5"
- [b3f7f588] class MySQLSHA2Mixin: def as_mysql(self, compiler, connection, **extra_context): return super().as_sql( compiler, connection, template="SHA2(%%(expressions)s, %s)" % self.function[3:], **extra_context, )
- [91bacd45] class OracleHashMixin: def as_oracle(self, compiler, connection, **extra_context): return super().as_sql( compiler, connection, template=( "LOWER(RAWTOHEX(STANDARD_HASH(UTL_I18N.STRING_TO_RAW(" "%(expressions)s, 'AL32UTF8'), '%(function)s')))" ), **extra_context, )
- [488e5af7] class Ord(Transform): function = "ASCII" lookup_name = "ord" output_field = IntegerField()
- [699de7bc] class PostgreSQLSHAMixin: def as_postgresql(self, compiler, connection, **extra_context): return super().as_sql( compiler, connection, template="ENCODE(DIGEST(%(expressions)s, '%(function)s'), 'hex')", function=self.function.lower(), **extra_context, )
- [40d4006e] class RPad(LPad): function = "RPAD"
- [825bf7c8] class RTrim(Transform): function = "RTRIM" lookup_name = "rtrim"
- [9d93f927] class Repeat(Func): function = "REPEAT" output_field = CharField()
- [e51e34b1] class Replace(Func): function = "REPLACE"
- [93fe9ea4] class Reverse(Transform): function = "REVERSE" lookup_name = "reverse"
- [1ad9f1ba] class Right(Left): function = "RIGHT"
- [eafb12da] class SHA1(OracleHashMixin, PostgreSQLSHAMixin, Transform): function = "SHA1" lookup_name = "sha1"
- [d581d857] class SHA224(MySQLSHA2Mixin, PostgreSQLSHAMixin, Transform): function = "SHA224" lookup_name = "sha224"
- [43a638a7] class SHA256(MySQLSHA2Mixin, OracleHashMixin, PostgreSQLSHAMixin, Transform): function = "SHA256" lookup_name = "sha256"
- [e1fac33b] class SHA384(MySQLSHA2Mixin, OracleHashMixin, PostgreSQLSHAMixin, Transform): function = "SHA384" lookup_name = "sha384"
- [f229f86e] class SHA512(MySQLSHA2Mixin, OracleHashMixin, PostgreSQLSHAMixin, Transform): function = "SHA512" lookup_name = "sha512"
- [b43e045d] class StrIndex(Func): """ Return a positive integer corresponding to the 1-indexed position of the first occurrence of a substring inside another string, or 0 if the substring is not found. """
- [591d51de] class Substr(Func): function = "SUBSTRING" output_field = CharField()
- [6acd2e29] class Trim(Transform): function = "TRIM" lookup_name = "trim"
- [fe1cc9b8] class Upper(Transform): function = "UPPER" lookup_name = "upper"
- [3abea421] from django.db import NotSupportedError from django.db.models.expressions import Func, Value from django.db.models.fields import CharField, IntegerField, TextField from django.db.models.functions import Cast, Coalesce from django.db.models.lookups import Transform
