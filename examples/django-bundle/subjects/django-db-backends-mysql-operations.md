# django/db/backends/mysql/operations

- Subject: django/db/backends/mysql/operations (id `1cde3772-b0c3-4c45-8f1b-8c02e56f91aa`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 13 of 46
- Conflicts: 0
- Gaps: 0

## Facts

- fields = ", ".join( [ field_sql % {"field": field} for field in map(self.quote_name, update_fields) ] ) return conflict_suffix_sql % {"fields": fields} return super().on_conflict_suffix_sql( fields, on_conflict, update_fields, unique_fields, ) [5bcc8230]
- # Expression values are adapted by the database. if hasattr(value, "resolve_expression"): return value [1c91f52127aa0a78]
- # MySQL doesn't support tz-aware datetimes if timezone.is_aware(value): if settings.USE_TZ: value = timezone.make_naive(value, self.connection.timezone) else: raise ValueError( "MySQL backend does not support timezone-aware datetimes when " "USE_TZ is False." ) return str(value) [95c1c315]
- # MySQL doesn't support tz-aware times if timezone.is_aware(value): raise ValueError("MySQL backend does not support timezone-aware times.") [62de8eeb]
- match_option = "c" if lookup_type == "regex" else "i" return "REGEXP_LIKE(%%s, %%s, '%s')" % match_option [209b3f5b]
- return value.isoformat(timespec="microseconds") [b3595fdb]
- sql = ["SET FOREIGN_KEY_CHECKS = 0;"] if reset_sequences: # It's faster to TRUNCATE tables that require a sequence reset # since ALTER TABLE AUTO_INCREMENT is slower than TRUNCATE. sql.extend( "%s %s;" % ( style.SQL_KEYWORD("TRUNCATE"), style.SQL_FIELD(self.quote_name(table_name)), ) for table_name in tables ) else: # Otherwise issue a simple DELETE since it's faster than TRUNCATE # and preserves sequences. sql.extend( "%s %s %s;" % ( style.SQL_KEYWORD("DELETE"), style.SQL_KEYWORD("FROM"), style.SQL_FIELD(self.quote_name(table_name)), ) for table_name in tables ) sql.append("SET FOREIGN_KEY_CHECKS = 1;") return sql [6c5b5c5e]
- # EXTRACT format cannot be passed in parameters. _extract_format_re = _lazy_re_compile(r"[A-Z_]+") [d51ce70b9c1630cd]
- # MySQL stores positive fields as UNSIGNED ints. integer_field_ranges = { **BaseDatabaseOperations.integer_field_ranges, "PositiveSmallIntegerField": (0, 65535), "PositiveIntegerField": (0, 4294967295), "PositiveBigIntegerField": (0, 18446744073709551615), } cast_data_types = { "AutoField": "signed integer", "BigAutoField": "signed integer", "SmallAutoField": "signed integer", "CharField": "char(%(max_length)s)", "DecimalField": "decimal(%(max_digits)s, %(decimal_places)s)", "TextField": "char", "IntegerField": "signed integer", "BigIntegerField": "signed integer", "SmallIntegerField": "signed integer", "PositiveBigIntegerField": "unsigned integer", "PositiveIntegerField": "unsigned integer", "PositiveSmallIntegerField": "unsigned integer", "DurationField": "signed integer", } cast_char_field_without_max_length = "char" explain_prefix = "EXPLAIN" [bc745eb9]
- def _convert_sql_to_tz(self, sql, params, tzname): if tzname and settings.USE_TZ and self.connection.timezone_name != tzname: return f"CONVERT_TZ({sql}, %s, %s)", ( *params, self.connection.timezone_name, self._prepare_tzname_delta(tzname), ) return sql, params [6e108ef7]
- def _prepare_tzname_delta(self, tzname): tzname, sign, offset = split_tzname_delta(tzname) return f"{sign}{offset}" if offset else tzname [69e35ed28cef2bca]
- def adapt_datetimefield_value(self, value): if value is None: return None [e492a81a53966237]
- def adapt_timefield_value(self, value): if value is None: return None [36c6da6fa0266bb9]

## Beyond the budget

31 more facts did not fit in the budget: [213fe3ef] [24b8afb7] [a5bfeefdfb4f74a2] [b28e1da37b4a4ece] [e6ed82d78972eefd] [b0265d05] [e89de589] [f70e003a] [ad97558b] [d6c8ca08] [929f5c10] [5042ad31] [102e2868] [74e86014] [bd15df9f] [5637d3b0] [be3e9e6e] [b7ced9af] [cc8ee14c] [09ee344f] [16b23464df2517ba] [285862a9] [37fdd3da] [f97e7312] [d6b2815e1ddcc509] [164bdf21] [ce97eeea] [a0daf6d2] [2fa52a6e] [af63fb8a] [58516111]
