# docs/releases/1.11.11

- Subject: docs/releases/1.11.11 (id `f86788a2-cc69-44ad-bbab-4fdcd5dccb8c`)
- Kind: subject
- Budget: 1200 tokens
- Used: 453 tokens
- Facts shown: 9 of 9
- Conflicts: 0
- Gaps: 0

## Facts

- *March 6, 2018* [dd0841b4]
- ============================ Django 1.11.11 release notes ============================ [a410f6d6]
- CVE-2018-7536: Denial-of-service possibility in ``urlize`` and ``urlizetrunc`` template filters =============================================================================================== [22c46aa3]
- CVE-2018-7537: Denial-of-service possibility in ``truncatechars_html`` and ``truncatewords_html`` template filters ================================================================================================================== [9e54a5b5]
- Django 1.11.11 fixes two security issues in 1.11.10. [80859055]
- If ``django.utils.text.Truncator``'s ``chars()`` and ``words()`` methods were passed the ``html=True`` argument, they were extremely slow to evaluate certain inputs due to a catastrophic backtracking vulnerability in a regular expression. The ``chars()`` and ``words()`` methods are used to implement the ``truncatechars_html`` and ``truncatewords_html`` template filters, which were thus vulnerable. [627936c9]
- The ``django.utils.html.urlize()`` function was extremely slow to evaluate certain inputs due to catastrophic backtracking vulnerabilities in two regular expressions. The ``urlize()`` function is used to implement the ``urlize`` and ``urlizetrunc`` template filters, which were thus vulnerable. [be725523]
- The backtracking problem in the regular expression is fixed. [37d6d779]
- The problematic regular expressions are replaced with parsing logic that behaves similarly. [08553521]
