# docs/releases/1.11.28

- Subject: docs/releases/1.11.28 (id `ddee67ff-69c8-4f2f-8218-5047655a5975`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 162 tokens
- Facts shown: 5 of 5
- Conflicts: 0
- Gaps: 0

## Facts

- *February 3, 2020* [8c8dd425]
- :class:`~django.contrib.postgres.aggregates.StringAgg` aggregation function was subject to SQL injection, using a suitably crafted ``delimiter``. [c99c0e28]
- ============================ Django 1.11.28 release notes ============================ [5a602781]
- CVE-2020-7471: Potential SQL injection via ``StringAgg(delimiter)`` =================================================================== [ee4b4d73]
- Django 1.11.28 fixes a security issue in 1.11.27. [ac4ef8aa]
