# docs/releases/1.5.4

- Subject: docs/releases/1.5.4 (id `73568aa5-26a4-4947-8956-01eb6d04b1e5`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 541 tokens
- Facts shown: 10 facts
- Conflicts: 0
- Gaps: 0

## Facts

- * Fixed a bug that prevented a ``QuerySet`` that uses :meth:`~django.db.models.query.QuerySet.prefetch_related` from being pickled and unpickled more than once (the second pickling attempt raised an exception) (#21102). [1be93d42]
- *September 14, 2013* [8a31d330e1b95cd3-2]
- ========================== Django 1.5.4 release notes ========================== [4ee4754f]
- As of 1.5.4, Django's authentication framework imposes a 4096-byte limit on passwords, and will fail authentication with any submitted password of greater length. [77a930d4]
- Bugfixes ======== [6c84539cac9c976c-40]
- Corrected usage of :func:`~django.views.decorators.debug.sensitive_post_parameters` in :mod:`django.contrib.auth`’s admin ========================================================================================================================= [dcc6e3cdca237414-2]
- Denial-of-service via password hashers ====================================== [b97258633faf5e1b-2]
- In previous versions of Django, no limit was imposed on the plaintext length of a password. This allowed a denial-of-service attack through submission of bogus but extremely large passwords, tying up server resources performing the (expensive, and increasingly expensive with the length of the password) calculation of the corresponding hash. [98ebdae5e7a4888f-2]
- The decoration of the ``add_view`` and ``user_change_password`` user admin views with :func:`~django.views.decorators.debug.sensitive_post_parameters` did not include :func:`~django.utils.decorators.method_decorator` (required since the views are methods) resulting in the decorator not being properly applied. This usage has been fixed and :func:`~django.views.decorators.debug.sensitive_post_parameters` will now throw an exception if it's improperly used. [4b317ea34d766936-2]
- This is Django 1.5.4, the fourth release in the Django 1.5 series. It addresses two security issues and one bug. [3f6ebef0]
