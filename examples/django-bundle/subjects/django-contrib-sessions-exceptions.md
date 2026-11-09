# django/contrib/sessions/exceptions

- Subject: django/contrib/sessions/exceptions (id `d898f077-3ab9-43b2-88a2-a4bea60efdb4`)
- Kind: subject
- Budget: 1200 tokens
- Used: 156 tokens
- Facts shown: 7 of 7
- Conflicts: 0
- Gaps: 0

## Facts

- pass [7655780f0d17b825-9]
- pass [7655780f0d17b825-10]
- pass [7655780f0d17b825-11]
- class InvalidSessionKey(SuspiciousOperation): """Invalid characters in session key""" [4c15cf15]
- class SessionInterrupted(BadRequest): """The session was interrupted.""" [96590a66]
- class SuspiciousSession(SuspiciousOperation): """The session may be tampered with""" [b0d9ab1e]
- from django.core.exceptions import BadRequest, SuspiciousOperation [fb1f8cbe]
