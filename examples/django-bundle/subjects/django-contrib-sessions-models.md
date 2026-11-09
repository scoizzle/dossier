# django/contrib/sessions/models

- Subject: django/contrib/sessions/models (id `64529d1f-15fa-4267-a2a7-a90f0d13935e`)
- Kind: subject
- Budget: 1200 tokens
- Used: 380 tokens
- Facts shown: 9 of 9
- Conflicts: 0
- Gaps: 0

## Facts

- return SessionStore [849b3663]
- @classmethod def get_session_store_class(cls): from django.contrib.sessions.backends.db import SessionStore [aff1cfd4]
- For complete documentation on using Sessions in your code, consult the sessions documentation that is shipped with Django (also available on the Django web site). """ [7939680b]
- The Django sessions framework is entirely cookie-based. It does not fall back to putting session IDs in URLs. This is an intentional design decision. Not only does that behavior make URLs ugly, it makes your site vulnerable to session-ID theft via the "Referer" header. [d53a26bb]
- class Meta(AbstractBaseSession.Meta): db_table = "django_session" [56d53121]
- objects = SessionManager() [f017606a]
- class Session(AbstractBaseSession): """ Django provides full support for anonymous sessions. The session framework lets you store and retrieve arbitrary data on a per-site-visitor basis. It stores data on the server side and abstracts the sending and receiving of cookies. Cookies contain a session ID -- not the data itself. [2612d383]
- class SessionManager(BaseSessionManager): use_in_migrations = True [e5f1db43]
- from django.contrib.sessions.base_session import AbstractBaseSession, BaseSessionManager [0a104221]
