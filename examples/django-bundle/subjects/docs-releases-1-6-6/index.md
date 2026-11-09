# docs/releases/1.6.6

- Subject: docs/releases/1.6.6 (id `529b1861-0900-49a5-a87b-bc6a319514e3`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1354 tokens
- Facts shown: 25 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- * Corrected email and URL validation to reject a trailing dash (:ticket:`22579`). [1d350032]
- * Fixed JavaScript errors while editing multi-geometry objects in the OpenLayers widget (:ticket:`23137`, :ticket:`23293`). [19766778]
- * Fixed the "ORA-01843: not a valid month" errors when using Unicode with older versions of Oracle server (:ticket:`20292`). [7a458b38]
- * Fixed transaction handling when specifying non-default database in ``createcachetable`` and ``flush`` (:ticket:`23089`). [4e7d0a51]
- * Prevented ``UnicodeDecodeError`` in ``runserver`` with non-UTF-8 and non-English locale (:ticket:`23265`). [75fee66f]
- * Prevented a crash on Python 3 with query strings containing unencoded non-ASCII characters (:ticket:`22996`). [50c69760]
- * Prevented edge case where values of FK fields could be initialized with a wrong value when an inline model formset is created for a relationship defined to point to a field other than the PK (:ticket:`13794`). [c02d197a]
- * Prevented indexes on PostgreSQL virtual fields (:ticket:`22514`). [b5517c44]
- * Restored ``pre_delete`` signals for ``GenericRelation`` cascade deletion (:ticket:`22998`). [4b720802]
- * Restored bug fix for sending Unicode email with Python 2.6.5 and below (:ticket:`19107`). [96a3f7aa]
- *August 20, 2014* [82ab06a2c0d215a2-3]
- ========================== Django 1.6.6 release notes ========================== [adda5d5d]
- Before this release, Django's file upload handing in its default configuration may degrade to producing a huge number of ``os.stat()`` system calls when a duplicate filename is uploaded. Since ``stat()`` may invoke IO, this may produce a huge data-dependent slowdown that slowly worsens over time. The net result is that given enough time, a user with the ability to upload files can cause poor performance in the upload handler, eventually causing it to become very slow simply by uploading 0-byte files. At this point, even a slow network connection and few HTTP requests would be all that is necessary to make a site unavailable. [8b20278daf1165ec-3]
- Bugfixes ======== [6c84539cac9c976c-46]
- Data leakage via query string manipulation in ``contrib.admin`` =============================================================== [70bab3376894b90c-3]
- Django 1.6.6 fixes several security issues and bugs in 1.6.5. [796accb0]
- File upload denial-of-service ============================= [30de1bbd7bf00272-3]
- In certain situations, URL reversing could generate scheme-relative URLs (URLs starting with two slashes), which could unexpectedly redirect a user to a different host. An attacker could exploit this, for example, by redirecting users to a phishing site designed to ask for user's passwords. [f5b8c6a819f8ff73-3]
- To address the issue, an exception will now be raised if a ``to_field`` value that isn't a related field to a model that has been registered with the admin is specified. [8727b7c0bf9c5d71-3]
- ``RemoteUserMiddleware`` session hijacking ========================================== [c2867c7f0bbb8bfe-3]

## All facts

- [0127e30c] In older versions of Django it was possible to reveal any field's data by modifying the "popup" and "to_field" parameters of the query string on an admin change form page. For example, requesting a URL like ``/admin/auth/user/?_popup=1&t=password`` and viewing the page's HTML allowed viewing the password hash of each user. While the admin requires users to have permissions to view the change form pages in the first place, this could leak data if you rely on users having access to view only certain fields on a model.
- [5f960b0236750da3-3] To remedy this, URL reversing now ensures that no URL starts with two slashes (//), replacing the second slash with its URL encoded counterpart (%2F). This approach ensures that semantics stay the same, while making the URL relative to the domain and not to the scheme.
- [627fccaa] We've remedied the issue by changing the algorithm for generating file names if a file with the uploaded name already exists. :meth:`Storage.get_available_name() <django.core.files.storage.Storage.get_available_name>` now appends an underscore plus a random 7 character alphanumeric string (e.g. ``"_x3a1gho"``), rather than iterating through an underscore followed by a number (e.g. ``"_1"``, ``"_2"``, etc.).
- [db22dd1bb3d126ab-3] When using the :class:`~django.contrib.auth.middleware.RemoteUserMiddleware` and the ``RemoteUserBackend``, a change to the ``REMOTE_USER`` header between requests without an intervening logout could result in the prior user's session being co-opted by the subsequent user. The middleware now logs the user out on a failed login attempt.
- [64b3e342b8c4c494-3] ``reverse()`` could generate URLs pointing to other hosts =========================================================
