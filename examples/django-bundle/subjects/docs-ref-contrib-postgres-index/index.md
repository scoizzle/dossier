# docs/ref/contrib/postgres/index

- Subject: docs/ref/contrib/postgres/index (id `0e5654fc-d216-455c-ba09-4372a72fe6c8`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 407 tokens
- Facts shown: 7 of 7
- Conflicts: 0
- Gaps: 0

## Facts

- Django provides support for a number of data types which will only work with PostgreSQL. There is no fundamental reason why (for example) a ``contrib.mysql`` module does not exist, except that PostgreSQL has the richest feature set of the supported databases so its users have the most to gain. [97d4e393]
- aggregates constraints expressions fields forms functions indexes lookups operations search validators [af9586b5]
- .. module:: django.contrib.postgres :synopsis: PostgreSQL-specific fields and features [72e649c8]
- .. note:: Django is, and will continue to be, a database-agnostic web framework. We would encourage those writing reusable applications for the Django community to write database-agnostic code where practical. However, we recognize that real world projects written using Django need not be database-agnostic. In fact, once a project reaches a given size changing the underlying data store is already a significant challenge and is likely to require changing the code base in some ways to handle differences between the data stores. [95ddf434]
- .. toctree:: :maxdepth: 2 [13f532897bf9e689-11]
- =========================== ``django.contrib.postgres`` =========================== [c9097073]
- PostgreSQL has a number of features which are not shared by the other databases Django supports. This optional module contains model fields and form fields for a number of PostgreSQL specific data types. [ff5a8679]
