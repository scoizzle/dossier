# docs/releases/1.11.27

- Subject: docs/releases/1.11.27 (id `0d38728f-b528-45c2-9ef4-36b826ab7753`)
- Kind: subject
- Budget: 1200 tokens
- Used: 412 tokens
- Facts shown: 9 of 9
- Conflicts: 0
- Gaps: 0

## Facts

- * Fixed a data loss possibility in :class:`~django.contrib.postgres.forms.SplitArrayField`. When using with ``ArrayField(BooleanField())``, all values after the first ``True`` value were marked as checked instead of preserving passed values (:ticket:`31073`). [4989acae]
- *December 18, 2019* [4e9f429f]
- .. __: https://www.unicode.org/reports/tr36/#Recommendations_General [1770ef7a]
- ============================ Django 1.11.27 release notes ============================ [9f7df718]
- Bugfixes ======== [6c84539cac9c976c-20]
- By submitting a suitably crafted email address making use of Unicode characters, that compared equal to an existing user email when lower-cased for comparison, an attacker could be sent a password reset token for the matched account. [5af6b432]
- CVE-2019-19844: Potential account hijack via password reset form ================================================================ [b85e380c]
- Django 1.11.27 fixes a security issue and a data loss bug in 1.11.26. [bec3bdd9]
- In order to avoid this vulnerability, password reset requests now compare the submitted email using the stricter, recommended algorithm for case-insensitive comparison of two identifiers from `Unicode Technical Report 36, section 2.11.2(B)(2)`__. Upon a match, the email containing the reset token will be sent to the email address on record rather than the submitted address. [6b6e65b3]
