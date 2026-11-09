# docs/releases/1.5.3

- Subject: docs/releases/1.5.3 (id `74870f55-8316-46e8-8e03-503be211464a`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 735 tokens
- Facts shown: 11 of 11
- Conflicts: 0
- Gaps: 0

## Facts

- {% ssi "/var/www/../../etc/passwd" %} [04de41ef58201b91-2]
- *September 10, 2013* [355705f7427bed3a-2]
- .. code-block:: html+django [685d15dfb6eb2285-318]
- :mod:`django.contrib.sessions` currently uses :mod:`pickle` to serialize session data before storing it in the backend. If you're using the :ref:`signed cookie session backend<cookie-session-backend>` and :setting:`SECRET_KEY` is known by an attacker (there isn't an inherent vulnerability in Django that would cause it to leak), the attacker could insert a string into their session which, when unpickled, executes arbitrary code on the server. The technique for doing so is simple and easily available on the internet. Although the cookie session storage signs the cookie-stored data to prevent tampering, a :setting:`SECRET_KEY` leak immediately escalates to a remote code execution vulnerability. [b051bb8c]
- ========================== Django 1.5.3 release notes ========================== [df7198b5]
- Directory traversal vulnerability in ``ssi`` template tag ========================================================= [3c506cd455dd0417-2]
- In practice this is not a very common problem, as it would require the template author to put the ``ssi`` file in a user-controlled variable, but it's possible in principle. [78f5508a30c935f0-2]
- In previous versions of Django it was possible to bypass the ``ALLOWED_INCLUDE_ROOTS`` setting used for security with the ``ssi`` template tag by specifying a relative path that starts with one of the allowed roots. For example, if ``ALLOWED_INCLUDE_ROOTS = ("/var/www",)`` the following would be possible: [c6fdea492418ff15-2]
- Mitigating a remote-code execution vulnerability in :mod:`django.contrib.sessions` ================================================================================== [48bda53c]
- This attack can be mitigated by serializing session data using JSON rather than :mod:`pickle`. To facilitate this, Django 1.5.3 introduces a new setting, :setting:`SESSION_SERIALIZER`, to customize the session serialization format. For backwards compatibility, this setting defaults to using :mod:`pickle`. While JSON serialization does not support all Python objects like :mod:`pickle` does, we highly recommend switching to JSON-serialized values. Also, as JSON requires string keys, you will likely run into problems if you are using non-string keys in ``request.session``. See the :ref:`session_serialization` documentation for more details. [c930ade8]
- This is Django 1.5.3, the third release in the Django 1.5 series. It addresses one security issue and also contains an opt-in feature to enhance the security of :mod:`django.contrib.sessions`. [6b2baccd]
