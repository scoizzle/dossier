# docs/releases/1.2.2

- Subject: docs/releases/1.2.2 (id `e9f10ad7-5f2f-442a-a9d1-86219666656c`)
- Kind: subject
- Budget: 1200 tokens
- Used: 377 tokens
- Facts shown: 8 of 8
- Conflicts: 0
- Gaps: 0

## Facts

- ========================== Django 1.2.2 release notes ========================== [51b081b9]
- Django 1.2.2 maintains backwards compatibility with Django 1.2.1, but contain a number of fixes and other improvements. Django 1.2.2 is a recommended upgrade for any development or deployment currently using or targeting Django 1.2. [d3a82abd]
- For full details on the new features, backwards incompatibilities, and deprecated features in the 1.2 branch, see the :doc:`/releases/1.2`. [d239dffcb32222b1]
- In order to test a bug fix that forms part of the 1.2.2 release, it was necessary to add a feature -- the ``enforce_csrf_checks`` flag -- to the :ref:`test client <test-client>`. This flag forces the test client to perform full CSRF checks on forms. The default behavior of the test client hasn't changed, but if you want to do CSRF checks with the test client, it is now possible to do so. [031e6583]
- One new feature =============== [79d817980538c5cc-2]
- Ordinarily, a point release would not include new features, but in the case of Django 1.2.2, we have made an exception to this rule. [d2b949df]
- This is the second "bugfix" release in the Django 1.2 series, improving the stability and performance of the Django 1.2 codebase. [a1c1780a]
- Welcome to Django 1.2.2! [d73d89f4]
