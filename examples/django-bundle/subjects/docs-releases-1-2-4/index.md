# docs/releases/1.2.4

- Subject: docs/releases/1.2.4 (id `f3dfdd81-b772-4873-9465-c3ab66250714`)
- Kind: subject
- Budget: 1200 tokens
- Used: 894 tokens
- Facts shown: 14 of 18
- Conflicts: 0
- Gaps: 0

## Facts

- ========================== Django 1.2.4 release notes ========================== [5f7fb90c]
- Backwards incompatible changes ============================== [f2cb124aa97ba055-3]
- For full details on the new features, backwards incompatibilities, and deprecated features in the 1.2 branch, see the :doc:`/releases/1.2`. [d239dffcb32222b1-2]
- GeoDjango ========= [7c65b830]
- However, it has been demonstrated that this can be abused to gain access to information outside of an admin user's permissions; for example, an attacker with access to the admin and sufficient knowledge of model structure and relations could construct query strings which -- with repeated use of regular-expression lookups supported by the Django database API -- expose sensitive information such as users' password hashes. [ef891265cf1578be-2]
- In addition, the GeoDjango test suite is now included when :ref:`running the Django test suite <running-unit-tests>` with ``runtests.py`` and using :ref:`spatial database backends <spatial-backends>`. [59f471e3]
- Most users -- even users with multiple-database configurations -- need not be concerned about the data loss bug, or the manual configuration of :setting:`TEST_DEPENDENCIES`. See the :ticket:`original problem report <14415>` documentation on :ref:`controlling the creation order of test databases <topics-testing-creation-dependencies>` for details. [54fd1953]
- One historically-undocumented and -unofficially-supported feature has been the ability for a user with sufficient knowledge of a model's structure and the format of these lookup arguments to invent useful new filters on the fly by manipulating the querystring. [268206f0aaa31a43-2]
- One new feature =============== [79d817980538c5cc-3]
- One of the bugs fixed in Django 1.2.4 involves a set of circumstances whereby a running a test suite on a multiple database configuration could cause the original source database (i.e., the actual production database) to be dropped, causing catastrophic loss of data. In order to provide a fix for this problem, it was necessary to introduce a new setting -- :setting:`TEST_DEPENDENCIES` -- that allows you to define any creation order dependencies in your database configuration. [58564036]
- Ordinarily, a point release would not include new features, but in the case of Django 1.2.4, we have made an exception to this rule. [093f8c34]
- Restricted filters in admin interface ------------------------------------- [67efa09035dab44d-2]
- The Django administrative interface, ``django.contrib.admin``, supports filtering of displayed lists of objects by fields on the corresponding models, including across database-level relationships. This is implemented by passing lookup arguments in the querystring portion of the URL, and options on the ModelAdmin class allow developers to specify particular fields or relationships which will generate automatic links for filtering. [9b9505832d70fe4a-2]
- The function-based :setting:`TEST_RUNNER` previously used to execute the GeoDjango test suite, ``django.contrib.gis.tests.run_gis_tests``, was finally deprecated in favor of a class-based test runner, ``django.contrib.gis.tests.GeoDjangoTestSuiteRunner``, added in this release. [15684677]

## Beyond the budget

4 more facts did not fit in the budget: [fd7425e1] [106d1ccd690f41d7-2] [06dfc455] [f52bc7a6]
