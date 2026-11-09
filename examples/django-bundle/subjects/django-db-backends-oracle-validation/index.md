# django/db/backends/oracle/validation

- Subject: django/db/backends/oracle/validation (id `61530861-200d-463d-803b-08bbe4d02017`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 171 tokens
- Facts shown: 2 facts
- Conflicts: 0
- Gaps: 0

## Facts

- class DatabaseValidation(BaseDatabaseValidation): def check_field_type(self, field, field_type): """Oracle doesn't support a database index on some data types.""" errors = [] if field.db_index and field_type.lower() in self.connection._limited_data_types: errors.append( checks.Warning( "Oracle does not support a database index on %s columns." % field_type, hint=( "An index won't be created. Silence this warning if " "you don't care about it." ), obj=field, id="fields.W162", ) ) return errors [95a7f904]
- from django.core import checks from django.db.backends.base.validation import BaseDatabaseValidation [4e52b2df]
