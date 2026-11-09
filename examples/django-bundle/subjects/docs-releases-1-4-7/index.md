# docs/releases/1.4.7

- Subject: docs/releases/1.4.7 (id `06296ec6-440c-426e-8a94-f5868af19ede`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 300 tokens
- Facts shown: 8 facts
- Conflicts: 0
- Gaps: 0

## Facts

- {% ssi "/var/www/../../etc/passwd" %} [04de41ef58201b91]
- *September 10, 2013* [355705f7427bed3a]
- .. code-block:: html+django [685d15dfb6eb2285-316]
- ========================== Django 1.4.7 release notes ========================== [84be49fd]
- Directory traversal vulnerability in ``ssi`` template tag ========================================================= [3c506cd455dd0417]
- Django 1.4.7 fixes one security issue present in previous Django releases in the 1.4 series. [4b7098a9]
- In practice this is not a very common problem, as it would require the template author to put the ``ssi`` file in a user-controlled variable, but it's possible in principle. [78f5508a30c935f0]
- In previous versions of Django it was possible to bypass the ``ALLOWED_INCLUDE_ROOTS`` setting used for security with the ``ssi`` template tag by specifying a relative path that starts with one of the allowed roots. For example, if ``ALLOWED_INCLUDE_ROOTS = ("/var/www",)`` the following would be possible: [c6fdea492418ff15]
