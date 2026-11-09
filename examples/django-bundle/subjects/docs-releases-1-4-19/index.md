# docs/releases/1.4.19

- Subject: docs/releases/1.4.19 (id `d0ed2fc0-1f90-44f0-ba4c-a287906f2222`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 179 tokens
- Facts shown: 5 of 5
- Conflicts: 0
- Gaps: 0

## Facts

- * ``GZipMiddleware`` now supports streaming responses. As part of the 1.4.18 security release, the ``django.views.static.serve()`` function was altered to stream the files it serves. Unfortunately, the ``GZipMiddleware`` consumed the stream prematurely and prevented files from being served properly (:ticket:`24158`). [7e3222df]
- *January 27, 2015* [a81aaee5]
- =========================== Django 1.4.19 release notes =========================== [29f05ae0]
- Bugfixes ======== [6c84539cac9c976c-33]
- Django 1.4.19 fixes a regression in the 1.4.18 security release. [e27e953c]
