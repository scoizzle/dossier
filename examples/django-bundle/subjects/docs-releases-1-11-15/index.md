# docs/releases/1.11.15

- Subject: docs/releases/1.11.15 (id `cac79a05-7239-47ab-a90c-bcc01021008c`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 254 tokens
- Facts shown: 6 of 6
- Conflicts: 0
- Gaps: 0

## Facts

- *August 1, 2018* [8e983971]
- ============================ Django 1.11.15 release notes ============================ [1fba06c0]
- CVE-2018-14574: Open redirect possibility in ``CommonMiddleware`` ================================================================= [95c90746]
- Django 1.11.15 fixes a security issue in 1.11.14. [d95c94c5]
- If the :class:`~django.middleware.common.CommonMiddleware` and the :setting:`APPEND_SLASH` setting are both enabled, and if the project has a URL pattern that accepts any path ending in a slash (many content management systems have such a pattern), then a request to a maliciously crafted URL of that site could lead to a redirect to another site, enabling phishing and other attacks. [74ff91ee]
- ``CommonMiddleware`` now escapes leading slashes to prevent redirects to other domains. [7741c7b1]
