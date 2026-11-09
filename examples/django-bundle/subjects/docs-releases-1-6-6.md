# docs/releases/1.6.6

- Subject: docs/releases/1.6.6 (id `7a1f85ce-062d-45e1-abb6-b5c1d248bf1b`)
- Kind: subject
- Budget: 1200 tokens
- Used: 887 tokens
- Facts shown: 20 of 25
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

5 more facts did not fit in the budget: [0127e30c] [5f960b0236750da3-3] [627fccaa] [db22dd1bb3d126ab-3] [64b3e342b8c4c494-3]
