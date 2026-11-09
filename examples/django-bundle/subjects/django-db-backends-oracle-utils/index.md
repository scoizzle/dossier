# django/db/backends/oracle/utils

- Subject: django/db/backends/oracle/utils (id `ecd37e33-85c2-4767-a36e-26e435165a70`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 690 tokens
- Facts shown: 13 of 13
- Conflicts: 0
- Gaps: 0

## Facts

- @classmethod def from_datetime(cls, dt): return Oracle_datetime( dt.year, dt.month, dt.day, dt.hour, dt.minute, dt.second, dt.microsecond, ) [b3193972]
- def __init__(self, field): internal_type = getattr(field, "target_field", field).get_internal_type() self.db_type = self.types.get(internal_type, str) self.bound_param = None [846b3849]
- def bind_parameter(self, cursor): self.bound_param = cursor.cursor.var(self.db_type) return self.bound_param [9323e50c]
- def get_value(self): return self.bound_param.getvalue() [36693ed0]
- input_size = Database.DB_TYPE_TIMESTAMP [918e0500]
- types = { "AutoField": NUMBER, "BigAutoField": NUMBER, "BigIntegerField": NUMBER, "BinaryField": BLOB, "BooleanField": NUMBER, "DateField": DATE, "DateTimeField": TIMESTAMP, "DecimalField": NUMBER, "DurationField": INTERVAL, "FloatField": NUMBER, "IntegerField": NUMBER, "PositiveBigIntegerField": NUMBER, "PositiveIntegerField": NUMBER, "PositiveSmallIntegerField": NUMBER, "SmallAutoField": NUMBER, "SmallIntegerField": NUMBER, "TextField": NCLOB, "TimeField": TIMESTAMP, } [20faac80]
- types = { "AutoField": int, "BigAutoField": int, "SmallAutoField": int, "IntegerField": int, "BigIntegerField": int, "SmallIntegerField": int, "PositiveBigIntegerField": int, "PositiveSmallIntegerField": int, "PositiveIntegerField": int, "BooleanField": int, "FloatField": Database.DB_TYPE_BINARY_DOUBLE, "DateTimeField": Database.DB_TYPE_TIMESTAMP, "DateField": datetime.date, "DecimalField": decimal.Decimal, } [f0254b10]
- class BoundVar: """ A late-binding cursor variable that can be passed to Cursor.execute as a parameter, in order to receive the id of the row created by an insert statement. """ [d1635fb1]
- class BulkInsertMapper: BLOB = "TO_BLOB(%s)" DATE = "TO_DATE(%s)" INTERVAL = "CAST(%s as INTERVAL DAY(9) TO SECOND(6))" NCLOB = "TO_NCLOB(%s)" NUMBER = "TO_NUMBER(%s)" TIMESTAMP = "TO_TIMESTAMP(%s)" [17cfd58a]
- class Oracle_datetime(datetime.datetime): """ A datetime object, with an additional class attribute to tell oracledb to save the microseconds too. """ [a6ac8f32]
- def dsn(settings_dict): if settings_dict["PORT"]: host = settings_dict["HOST"].strip() or "localhost" return Database.makedsn(host, int(settings_dict["PORT"]), settings_dict["NAME"]) return settings_dict["NAME"] [0f1e3570]
- from .base import Database [26c8dfb3c93f7ac3]
- import datetime import decimal [e2937da268df9eae-2]
