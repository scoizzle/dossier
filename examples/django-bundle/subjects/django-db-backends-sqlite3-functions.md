# django/db/backends/sqlite3/_functions

- Subject: django/db/backends/sqlite3/_functions (id `1ffed376-e253-4755-bbf3-913bdd14ae20`)
- Kind: subject
- Budget: 1200 tokens
- Used: 891 tokens
- Facts shown: 26 of 62
- Conflicts: 0
- Gaps: 0

## Facts

- def finalize(self): items = (item for item in self if item is not None) try: return functools.reduce(self.bit_operator, items) except TypeError: # items may be an empty iterator when all elements are None. return None [e0e0de0c]
- """ Implementations of SQL functions for SQLite. """ [eb2493d8]
- class AnyValue(ListAggregate): def finalize(self): return self[0] [e10884c3]
- class BitAggregate(ListAggregate): bit_operator = None [8c4a8e4a]
- class BitAnd(BitAggregate): bit_operator = operator.and_ [6801aba9]
- class BitOr(BitAggregate): bit_operator = operator.or_ [7f929d26]
- class BitXor(BitAggregate): bit_operator = operator.xor [901798ba]
- class ListAggregate(list): step = list.append [66ba3c0d]
- class StdDevPop(ListAggregate): finalize = statistics.pstdev [ccc3b43e]
- class StdDevSamp(ListAggregate): finalize = statistics.stdev [e9a440da]
- class VarPop(ListAggregate): finalize = statistics.pvariance [f6622042]
- class VarSamp(ListAggregate): finalize = statistics.variance [3763beeb]
- def _sqlite_acos(x): if x is None: return None return acos(x) [e91cd51e]
- def _sqlite_asin(x): if x is None: return None return asin(x) [19370e59]
- def _sqlite_atan(x): if x is None: return None return atan(x) [09d0a739]
- def _sqlite_atan2(y, x): if y is None or x is None: return None return atan2(y, x) [56c873c0]
- def _sqlite_bitxor(x, y): if x is None or y is None: return None return x ^ y [7aa0a69a]
- def _sqlite_ceiling(x): if x is None: return None return ceil(x) [8e397660]
- def _sqlite_cos(x): if x is None: return None return cos(x) [b42163bb]
- def _sqlite_cot(x): if x is None: return None return 1 / tan(x) [e98fea83]
- def _sqlite_date_trunc(lookup_type, dt, tzname, conn_tzname): dt = _sqlite_datetime_parse(dt, tzname, conn_tzname) if dt is None: return None if lookup_type == "year": return f"{dt.year:04d}-01-01" elif lookup_type == "quarter": month_in_quarter = dt.month - (dt.month - 1) % 3 return f"{dt.year:04d}-{month_in_quarter:02d}-01" elif lookup_type == "month": return f"{dt.year:04d}-{dt.month:02d}-01" elif lookup_type == "week": dt -= timedelta(days=dt.weekday()) return f"{dt.year:04d}-{dt.month:02d}-{dt.day:02d}" elif lookup_type == "day": return f"{dt.year:04d}-{dt.month:02d}-{dt.day:02d}" raise ValueError(f"Unsupported lookup type: {lookup_type!r}") [15af5306]
- def _sqlite_datetime_cast_date(dt, tzname, conn_tzname): dt = _sqlite_datetime_parse(dt, tzname, conn_tzname) if dt is None: return None return dt.date().isoformat() [1b6f5c08]
- def _sqlite_degrees(x): if x is None: return None return degrees(x) [f8bf499d]
- def _sqlite_exp(x): if x is None: return None return exp(x) [9efe1b33]
- def _sqlite_floor(x): if x is None: return None return floor(x) [3ae0eed5]
- def _sqlite_ln(x): if x is None: return None return log(x) [ffa9fced]

## Beyond the budget

34 more facts did not fit in the budget: [ff8c18bd] [08cfc95a] [f92ae4a3] [98116f6c] [3d3560db] [f763bf02] [b99b917f] [c8b234e3] [32be96f7] [83955508] [fa184246] [26ef8bc6] [1f737c37] [76dc690a] [ab0a6bb1] [945d3625] [ca880715] [594f3b40] [b274d95c] [c771a68b] [ecc39278] [04b1c72a] [ed4baafb] [fc613581] [427cf9e9] [deae9510] [72fccf9c] [ffe706d2] [0340abb4] [78af4277] [0ce1b2fb] [ee3248b7] [6f586f9a] [d1465a56]
