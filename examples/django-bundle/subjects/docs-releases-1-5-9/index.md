# docs/releases/1.5.9

- Subject: docs/releases/1.5.9 (id `420732f9-ab41-47f9-9051-ef53a9290b74`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 943 tokens
- Facts shown: 14 of 14
- Conflicts: 0
- Gaps: 0

## Highlights

- *August 20, 2014* [82ab06a2c0d215a2-2]
- ========================== Django 1.5.9 release notes ========================== [c258338d]
- Before this release, Django's file upload handing in its default configuration may degrade to producing a huge number of ``os.stat()`` system calls when a duplicate filename is uploaded. Since ``stat()`` may invoke IO, this may produce a huge data-dependent slowdown that slowly worsens over time. The net result is that given enough time, a user with the ability to upload files can cause poor performance in the upload handler, eventually causing it to become very slow simply by uploading 0-byte files. At this point, even a slow network connection and few HTTP requests would be all that is necessary to make a site unavailable. [8b20278daf1165ec-2]
- Data leakage via query string manipulation in ``contrib.admin`` =============================================================== [70bab3376894b90c-2]
- Django 1.5.9 fixes several security issues in 1.5.8. [28f4f3f9]
- File upload denial-of-service ============================= [30de1bbd7bf00272-2]
- In certain situations, URL reversing could generate scheme-relative URLs (URLs starting with two slashes), which could unexpectedly redirect a user to a different host. An attacker could exploit this, for example, by redirecting users to a phishing site designed to ask for user's passwords. [f5b8c6a819f8ff73-2]
- In older versions of Django it was possible to reveal any field's data by modifying the "popup" and "to_field" parameters of the query string on an admin change form page. For example, requesting a URL like ``/admin/auth/user/?pop=1&t=password`` and viewing the page's HTML allowed viewing the password hash of each user. While the admin requires users to have permissions to view the change form pages in the first place, this could leak data if you rely on users having access to view only certain fields on a model. [2915f9036c40997d-2]
- To address the issue, an exception will now be raised if a ``to_field`` value that isn't a related field to a model that has been registered with the admin is specified. [8727b7c0bf9c5d71-2]
- To remedy this, URL reversing now ensures that no URL starts with two slashes (//), replacing the second slash with its URL encoded counterpart (%2F). This approach ensures that semantics stay the same, while making the URL relative to the domain and not to the scheme. [5f960b0236750da3-2]
- We've remedied the issue by changing the algorithm for generating file names if a file with the uploaded name already exists. :meth:`Storage.get_available_name <django.core.files.storage.Storage.get_available_name>` now appends an underscore plus a random 7 character alphanumeric string (e.g. ``"_x3a1gho"``), rather than iterating through an underscore followed by a number (e.g. ``"_1"``, ``"_2"``, etc.). [d968df823a30e77f-2]
- When using the :class:`~django.contrib.auth.middleware.RemoteUserMiddleware` and the ``RemoteUserBackend``, a change to the ``REMOTE_USER`` header between requests without an intervening logout could result in the prior user's session being co-opted by the subsequent user. The middleware now logs the user out on a failed login attempt. [db22dd1bb3d126ab-2]

## All facts

- [c2867c7f0bbb8bfe-2] ``RemoteUserMiddleware`` session hijacking ==========================================
- [64b3e342b8c4c494-2] ``reverse()`` could generate URLs pointing to other hosts =========================================================
