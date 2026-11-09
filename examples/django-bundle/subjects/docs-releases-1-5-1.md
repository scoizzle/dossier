# docs/releases/1.5.1

- Subject: docs/releases/1.5.1 (id `2dc53e8b-6717-4cd5-acea-3d05773728fc`)
- Kind: subject
- Budget: 1200 tokens
- Used: 295 tokens
- Facts shown: 7 of 7
- Conflicts: 0
- Gaps: 0

## Facts

- * Module-level warnings emitted during tests are no longer silently hidden (:ticket:`18985`). * Prevented filtering on password hashes in the user admin (:ticket:`20078`). [f191bc17]
- *March 28, 2013* [fba94bbc]
- ========================== Django 1.5.1 release notes ========================== [bf0dd824]
- Django 1.5.1 also includes a couple smaller fixes: [0fcb5d49]
- If you've noticed memory problems under Django 1.5, upgrading to 1.5.1 should fix those issues. [e7527ccb]
- The biggest fix is for a memory leak introduced in Django 1.5. Under certain circumstances, repeated iteration over querysets could leak memory - sometimes quite a bit of it. If you'd like more information, the details are in :ticket:`our ticket tracker <19895>` (and in :bpo:`a related issue <17468>` in Python itself). [fcc245ff]
- This is Django 1.5.1, a bugfix release for Django 1.5. It's completely backwards compatible with Django 1.5, but includes a handful of fixes. [f6cbc61f]
