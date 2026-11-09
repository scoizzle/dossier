# docs/releases/1.4.22

- Subject: docs/releases/1.4.22 (id `0137ace6-32e2-4f91-b25e-4b70f4667deb`)
- Kind: subject
- Budget: 1200 tokens
- Used: 434 tokens
- Facts shown: 8 of 8
- Conflicts: 0
- Gaps: 0

## Facts

- *August 18, 2015* [02ccbe4c]
- =========================== Django 1.4.22 release notes =========================== [3b5ee333]
- Additionally, the ``contrib.sessions.backends.base.SessionBase.flush()`` and ``cache_db.SessionStore.flush()`` methods have been modified to avoid creating a new empty session. Maintainers of third-party session backends should check if the same vulnerability is present in their backend and correct it if so. [03e992c8]
- Denial-of-service possibility in ``logout()`` view by filling session store =========================================================================== [39219311]
- Django 1.4.22 fixes a security issue in 1.4.21. [337c5f4a]
- It also fixes support with pip 7+ by disabling wheel support. Older versions of 1.4 would silently build a broken wheel when installed with those versions of pip. [cb7c431d]
- Previously, a session could be created when anonymously accessing the ``django.contrib.auth.views.logout()`` view (provided it wasn't decorated with :func:`~django.contrib.auth.decorators.login_required` as done in the admin). This could allow an attacker to easily create many new session records by sending repeated requests, potentially filling up the session store or causing other users' session records to be evicted. [7a4bf060]
- The :class:`~django.contrib.sessions.middleware.SessionMiddleware` has been modified to no longer create empty session records, including when :setting:`SESSION_SAVE_EVERY_REQUEST` is active. [3077f7c4]
