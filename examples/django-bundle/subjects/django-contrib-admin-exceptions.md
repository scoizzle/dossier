# django/contrib/admin/exceptions

- Subject: django/contrib/admin/exceptions (id `91f4d281-8607-452d-90ce-7f45cd55ce2c`)
- Kind: subject
- Budget: 1200 tokens
- Used: 211 tokens
- Facts shown: 9 of 9
- Conflicts: 0
- Gaps: 0

## Facts

- pass [7655780f0d17b825]
- pass [7655780f0d17b825-2]
- pass [7655780f0d17b825-3]
- pass [7655780f0d17b825-4]
- class AlreadyRegistered(Exception): """The model is already registered.""" [f94cbb4c]
- class DisallowedModelAdminLookup(SuspiciousOperation): """Invalid filter was passed to admin view via URL querystring""" [ee5fe5fc]
- class DisallowedModelAdminToField(SuspiciousOperation): """Invalid to_field was passed to admin view via URL query string""" [b1f3f97b]
- class NotRegistered(Exception): """The model is not registered.""" [31636e7f]
- from django.core.exceptions import SuspiciousOperation [5132f8c967779d0c]
