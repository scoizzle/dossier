# django/contrib/postgres/search

- Subject: django/contrib/postgres/search (id `940c6704-d139-4853-96bb-a5955e24bfac`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 18 of 81
- Conflicts: 0
- Gaps: 0

## Facts

- combined_sql = f"({lsql} {self.connector} {rsql})" combined_value = combined_sql % tuple(value_params) return "%s", (combined_value,) [e3e8b96d]
- if label: param = f"{param}:{label}" if self.invert: param = f"!{param}" [e2703519]
- if not hasattr(vector, "resolve_expression"): vector = SearchVector(vector) if not hasattr(query, "resolve_expression"): query = SearchQuery(query) expressions = [vector, query] if weights is not None: if not hasattr(weights, "resolve_expression"): weights = Value(weights) weights = Cast(weights, ArrayField(_Float4Field())) expressions = [weights, *expressions] if normalization is not None: if not hasattr(normalization, "resolve_expression"): normalization = Value(normalization) expressions.append(normalization) if cover_density: self.function = "ts_rank_cd" super().__init__(*expressions) [07ea2569]
- if not isinstance(value, str): raise TypeError( f"Lexeme value must be a string, got {value.__class__.__name__}." ) [4591309e]
- if weight is not None and ( not isinstance(weight, str) or weight.lower() not in {"a", "b", "c", "d"} ): raise ValueError( f"Weight must be one of 'A', 'B', 'C', and 'D', got {weight!r}." ) [0bb0af46]
- return "%s", (param,) [70af4d4d]
- return sql, (*config_params, *params, *extra_params) [1f80ec4f]
- rsql, params = compiler.compile(self.rhs) value_params.extend(params) [001b76ae]
- self.function = self.SEARCH_TYPES.get(search_type) if self.function is None: raise ValueError("Unknown search_type argument '%s'." % search_type) if not hasattr(value, "resolve_expression"): value = Value(value) expressions = (value,) self.config = SearchConfig.from_parameter(config) if self.config is not None: expressions = [self.config, *expressions] self.invert = invert super().__init__(*expressions, output_field=output_field) [32e076be]
- self.prefix = prefix self.invert = invert self.weight = weight super().__init__(value, output_field=output_field) [262e665f]
- # On Combinable, these are not implemented to reduce confusion with Q. In # this case we are actually (ab)using them to do logical combination so # it's consistent with other usage in Django. def __or__(self, other): return self._combine(other, self.BITOR, False) [439827868bd89bfb]
- @classmethod def from_parameter(cls, config): if config is None or isinstance(config, cls): return config return cls(config) [5a4a1bc3]
- class UTF8Dumper(Dumper): def dump(self, obj): return bytes(obj, "utf-8") [d8fb5b27]
- def __and__(self, other): return self._combine(other, self.BITAND, False) [f659b53843c4eef1]
- def __init__( self, value, output_field=None, *, config=None, invert=False, search_type="plain", ): if isinstance(value, LexemeCombinable): search_type = "raw" [23ac639f]
- def __init__( self, vector, query, weights=None, normalization=None, cover_density=False, ): from .fields.array import ArrayField [90c07f8b]
- def __init__( self, value, output_field=None, *, invert=False, prefix=False, weight=None ): if value == "": raise ValueError("Lexeme value cannot be empty.") [c562c840]
- class SearchVectorCombinable: ADD = "||" [7345c19e]

## Beyond the budget

58 more facts did not fit in the budget: [ae026459] [8d0774e6] [02c534ce] [f186db36] [b168d574] [e70b6d06] [57090870be5dc3fa] [8658e2a00e896e67] [71a47520] [92fa58e4] [89440b35] [e285c8d6] [c341dfe8] [8dca98f3] [71e51d65] [702003df] [7115a4bf] [3065217b] [cb20332d] [4ca09ac2] [0ac46613] [e5c01178] [713ebf88] [739e6226] [18b05ee1] [d1a0be10] [81b81fa8] [09dfd74f] [19c64a11] [f126f799] [cd37aa49] [439777a9] [451b45d6] [4f3f032a] [904a8798] [ba01b415] [a9ee3933] [cb12c988] [6cf00b3b] [9d129420] [d40edf05] [af9c8354] [6dec3312] [df95e209] [a01dac41] [2c43e346] [dd86452a] [71bb438d] [2e5ab21e] [81e3a9bc] [6ab9bd42] [698343f8] [2474518a] [ab2bac21886a7863-2] [de080203] [4b51f168] [e9252736] [2b7bf085]
