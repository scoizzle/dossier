# docs/releases/1.10.8

- Subject: docs/releases/1.10.8 (id `f96775c4-fa41-48d7-82a0-0a6582c8003b`)
- Kind: subject
- Budget: 1200 tokens
- Used: 221 tokens
- Facts shown: 5 of 5
- Conflicts: 0
- Gaps: 0

## Facts

- *September 5, 2017* [d989f6eacd7f1d9c]
- =========================== Django 1.10.8 release notes =========================== [43b62f94]
- CVE-2017-12794: Possible XSS in traceback section of technical 500 debug page ============================================================================= [5d47a9fe3575851b]
- Django 1.10.8 fixes a security issue in 1.10.7. [e3790921]
- In older versions, HTML autoescaping was disabled in a portion of the template for the technical 500 debug page. Given the right circumstances, this allowed a cross-site scripting attack. This vulnerability shouldn't affect most production sites since you shouldn't run with ``DEBUG = True`` (which makes this page accessible) in your production settings. [64dfac347d73c690]
