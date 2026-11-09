# docs/howto/upgrade-version

- Subject: docs/howto/upgrade-version (id `5c4b0c1e-58aa-475c-8a32-f952b2af66cf`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1795 tokens
- Facts shown: 40 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- $ PYTHONWARNINGS=always pytest tests --capture=no [ff5fae6e]
- $ python -Wa manage.py test [101af2650c64d744]
- $ python -Wa manage.py test [101af2650c64d744-2]
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
- If you installed Django with pip_, you can use the ``--upgrade`` or ``-U`` flag: [7ca1bdbd]
- If you're not using the Django test runner, you may need to also ensure that any console output is not captured which would hide deprecation warnings. For example, if you use `pytest <https://docs.pytest.org/>`__: [73a7ab8c]
- Testing ======= [2a042191630e69fa-3]

## All facts

- [5393bd59] If you are using caching provided by Django, you should consider clearing your cache after upgrading. Otherwise you may run into problems, for example, if you are caching pickled objects as these objects are not guaranteed to be pickle-compatible across Django versions. A past instance of incompatibility was caching pickled :class:`~django.http.HttpResponse` objects, either directly or indirectly via the :func:`~django.views.decorators.cache.cache_page` decorator.
- [ef09e4f7] If you're upgrading through more than one feature version (e.g. 2.0 to 2.2), it's usually easier to upgrade through each feature release incrementally (2.0 to 2.1 to 2.2) rather than to make all the changes for each feature release at once. For each feature release, use the latest patch release (e.g. for 2.1, use 2.1.15).
- [04541292] In Python, deprecation warnings are silenced by default. You must turn them on using the ``-Wa`` Python command line option or the :envvar:`PYTHONWARNINGS` environment variable. For example, to show warnings while running tests:
- [5a092ee1] In most cases it will be necessary to upgrade to the latest version of your Django-related dependencies as well. If the Django version was recently released or if some of your dependencies are not well-maintained, some of your dependencies may not yet support the new Django version. In these cases you may have to wait until new versions of your dependencies are released.
- [8db4d8757db9fb63] Installation ============
- [a253679d] Once you're ready, it is time to :doc:`install the new Django version </topics/install>`. If you are using a :mod:`virtual environment <venv>` and it is a major upgrade, you might want to set up a new environment with all the dependencies first.
- [7b9596b0] Pay particular attention to backwards incompatible changes to get a clear idea of what will be needed for a successful upgrade.
- [456faf51] Required Reading ================
- [8ea7c3d7] Resolve any deprecation warnings with your current version of Django before continuing the upgrade process.
- [2656a42e] Resolving deprecation warnings ==============================
- [358536b6] The same incremental upgrade approach is recommended when upgrading from one LTS to the next.
- [7174e978] Third party applications might use deprecated APIs in order to support multiple versions of Django, so deprecation warnings in packages you've installed don't necessarily indicate a problem. If a package doesn't support the latest version of Django, consider raising an issue or sending a pull request for it.
- [9e94b806] Upgrading Django to the latest version offers several benefits:
- [7fb17849] When the new environment is set up, :doc:`run the full test suite </topics/testing/overview>` for your application. Again, it's useful to turn on deprecation warnings on so they're shown in the test output (you can also use the flag if you test your app manually using ``manage.py runserver``):
- [03f024ad] When you are sufficiently confident your app works with the new version of Django, you're ready to go ahead and :doc:`deploy </howto/deployment/index>` your upgraded Django project.
