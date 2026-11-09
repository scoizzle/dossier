# docs/releases/1.4.8

- Subject: docs/releases/1.4.8 (id `0ca50f3c-ab48-4893-afa9-3f69320611e6`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 455 tokens
- Facts shown: 8 of 8
- Conflicts: 0
- Gaps: 0

## Facts

- *September 14, 2013* [8a31d330e1b95cd3]
- ========================== Django 1.4.8 release notes ========================== [22091fce]
- As of 1.4.8, Django's authentication framework imposes a 4096-byte limit on passwords and will fail authentication with any submitted password of greater length. [592aa51c]
- Corrected usage of :func:`~django.views.decorators.debug.sensitive_post_parameters` in :mod:`django.contrib.auth`’s admin ========================================================================================================================= [dcc6e3cdca237414]
- Denial-of-service via password hashers ====================================== [b97258633faf5e1b]
- Django 1.4.8 fixes two security issues present in previous Django releases in the 1.4 series. [009c2104]
- In previous versions of Django, no limit was imposed on the plaintext length of a password. This allowed a denial-of-service attack through submission of bogus but extremely large passwords, tying up server resources performing the (expensive, and increasingly expensive with the length of the password) calculation of the corresponding hash. [98ebdae5e7a4888f]
- The decoration of the ``add_view`` and ``user_change_password`` user admin views with :func:`~django.views.decorators.debug.sensitive_post_parameters` did not include :func:`~django.utils.decorators.method_decorator` (required since the views are methods) resulting in the decorator not being properly applied. This usage has been fixed and :func:`~django.views.decorators.debug.sensitive_post_parameters` will now throw an exception if it's improperly used. [4b317ea34d766936]
