# docs/releases/1.11.10

- Subject: docs/releases/1.11.10 (id `53e959f3-286b-4960-9c57-0165c8eb75e2`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 510 tokens
- Facts shown: 10 facts
- Conflicts: 0
- Gaps: 0

## Facts

- * Fixed a regression where ``contrib.auth.authenticate()`` crashes if an authentication backend doesn't accept ``request`` and a later one does (:ticket:`29071`). [fec61f08]
- * Fixed crash when entering an invalid uuid in ``ModelAdmin.raw_id_fields`` (:ticket:`29094`). [45d45f75]
- * Fixed incorrect foreign key nullification if a model has two foreign keys to the same model and a target model is deleted (:ticket:`29016`). [18d17112]
- *February 1, 2018* [20039246]
- ============================ Django 1.11.10 release notes ============================ [520abfd8]
- A regression in Django 1.11.8 made :class:`~django.contrib.auth.forms.AuthenticationForm` run its ``confirm_login_allowed()`` method even if an incorrect password is entered. This can leak information about a user, depending on what messages ``confirm_login_allowed()`` raises. If ``confirm_login_allowed()`` isn't overridden, an attacker enter an arbitrary username and see if that user has been set to ``is_active=False``. If ``confirm_login_allowed()`` is overridden, more sensitive details could be leaked. [3935babb]
- Bugfixes ======== [6c84539cac9c976c-9]
- CVE-2018-6188: Information leakage in ``AuthenticationForm`` ============================================================ [a8d21211]
- Django 1.11.10 fixes a security issue and several bugs in 1.11.9. [dd62a365]
- This issue is fixed with the caveat that ``AuthenticationForm`` can no longer raise the "This account is inactive." error if the authentication backend rejects inactive users (the default authentication backend, ``ModelBackend``, has done that since Django 1.10). This issue will be revisited for Django 2.1 as a fix to address the caveat will likely be too invasive for inclusion in older versions. [b94e0887]
