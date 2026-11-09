# docs/releases/1.1.2

- Subject: docs/releases/1.1.2 (id `27a09027-5b44-4833-8418-074a3446c4d8`)
- Kind: subject
- Budget: 1200 tokens
- Used: 750 tokens
- Facts shown: 13 of 13
- Conflicts: 0
- Gaps: 0

## Facts

- ========================== Django 1.1.2 release notes ========================== [9f3afc02]
- Backwards-incompatible changes in 1.1.2 ======================================= [f1ac6d23]
- Cookie encoding --------------- [a8cceee3de363b57]
- Django 1.1.2 maintains backwards compatibility with Django 1.1.0, but contain a number of fixes and other improvements. Django 1.1.2 is a recommended upgrade for any development or deployment currently using or targeting Django 1.1. [d142f6bb]
- For full details on the new features, backwards incompatibilities, and deprecated features in the 1.1 branch, see the :doc:`/releases/1.1`. [c5816bb0ad26b431]
- One new feature =============== [79d817980538c5cc]
- Ordinarily, a point release would not include new features, but in the case of Django 1.1.2, we have made an exception to this rule. Django 1.2 (the next major release of Django) will contain a feature that will improve protection against Cross-Site Request Forgery (CSRF) attacks. This feature requires the use of a new :ttag:`csrf_token` template tag in all forms that Django renders. [6b61dc96]
- Test runner exit status code ---------------------------- [7ea06e3e24e48e9b]
- The exit status code of the test runners (``tests/runtests.py`` and ``python manage.py test``) no longer represents the number of failed tests, since a failure of 256 or more tests resulted in a wrong exit status code. The exit status code for the test runner is now 0 for success (no failing tests) and 1 for any number of test failures. If needed, the number of test failures can be found at the end of the test runner's output. [94333d5d]
- This is the second "bugfix" release in the Django 1.1 series, improving the stability and performance of the Django 1.1 codebase. [6fbb7151]
- To fix bugs with cookies in Internet Explorer, Safari, and possibly other browsers, our encoding of cookie values was changed so that the characters comma and semi-colon are treated as non-safe characters, and are therefore encoded as ``\054`` and ``\073`` respectively. This could produce backwards incompatibilities, especially if you are storing comma or semi-colon in cookies and have JavaScript code that parses and manipulates cookie values client-side. [938163bc]
- To make it easier to support both 1.1.X and 1.2.X versions of Django with the same templates, we have decided to introduce the :ttag:`csrf_token` template tag to the 1.1.X branch. In the 1.1.X branch, :ttag:`csrf_token` does nothing - it has no effect on templates or form processing. However, it means that the same template will work with Django 1.2. [68133a96]
- Welcome to Django 1.1.2! [0b5b3a9f]
