# docs/howto/upgrade-version

- Subject: docs/howto/upgrade-version (id `1b23810b-6956-4e93-9ec6-2d88eac7e4fd`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 22 of 40
- Conflicts: 0
- Gaps: 0

## Facts

- $ PYTHONWARNINGS=always pytest tests --capture=no [ff5fae6e]
- $ python -Wa manage.py test [101af2650c64d744]
- Django has a vibrant ecosystem. There are automated upgrade helpers highlighted on the `Community Ecosystem <https://www.djangoproject.com/community/ecosystem/#upgrade-utilities>`__ page. [48dd56a2]
- $ python -m pip install -U Django [8d34686a]
- * New features and improvements become available. * Bugs are fixed. * Older versions of Django eventually stop receiving security updates (see :ref:`supported-versions-policy`). * Upgrading with each new release helps keep your code base current and makes future upgrades smoother. [e2116734]
- * Read the :doc:`release notes </releases/index>` for each 'final' release from the one after your current Django version, up to and including the version to which you plan to upgrade. * Look at the :doc:`deprecation timeline</internals/deprecation>` for the relevant versions. [9fd9a3d2]
- .. _pip: https://pip.pypa.io/ [9bd3d4bd]
- .. admonition:: Tools to help with version upgrades [c71ca9b2]
- .. code-block:: console [faf6f5a8efbd7831-2]
- .. console:: [7714e199aac2701e-3]
- .. console:: [7714e199aac2701e-4]
- .. console:: [7714e199aac2701e-5]
- ======================================== How to upgrade Django to a newer version ======================================== [1f01c4c3]
- After you have run the tests, fix any failures. While you have the release notes fresh in your mind, it may also be a good time to take advantage of new features in Django by refactoring your code to eliminate any deprecation warnings. [337bfad6]
- Afterward, you should familiarize yourself with the changes that were made in the new Django version(s): [dee081c0]
- Before upgrading, it's a good idea to resolve any deprecation warnings raised by your project while using your current version of Django. Fixing these warnings before upgrading ensures that you're informed about areas of the code that need altering. [64e45dc2]
- Dependencies ============ [923df263]
- Deployment ========== [abc7004bdb4d6146-2]
- Here are some things to consider to help make your upgrade process as smooth as possible. [1d76db45]
- If it's your first time doing an upgrade, it is useful to read the :doc:`guide on the different release processes </internals/release-process>`. [9e591d40]
- If you are upgrading to an alpha, beta, or release candidate, please see our guide on :ref:`testing-pre-releases` for more specific tips about catching regressions and reporting bugs. [a2a66d1f]
- If you are using caching provided by Django, you should consider clearing your cache after upgrading. Otherwise you may run into problems, for example, if you are caching pickled objects as these objects are not guaranteed to be pickle-compatible across Django versions. A past instance of incompatibility was caching pickled :class:`~django.http.HttpResponse` objects, either directly or indirectly via the :func:`~django.views.decorators.cache.cache_page` decorator. [5393bd59]

## Beyond the budget

17 more facts did not fit in the budget: [7ca1bdbd] [73a7ab8c] [ef09e4f7] [04541292] [5a092ee1] [8db4d8757db9fb63] [a253679d] [7b9596b0] [456faf51] [8ea7c3d7] [2656a42e] [2a042191630e69fa-3] [358536b6] [7174e978] [9e94b806] [7fb17849] [03f024ad]
