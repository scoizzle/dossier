# docs/releases/1.2.5

- Subject: docs/releases/1.2.5 (id `64217371-9685-4113-bb0c-cecbecb7c7e0`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1690 tokens
- Facts shown: 27 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- * Browsers have strict same-origin policies regarding XMLHttpRequest. [c4dfd23e18422715-2]
- * In the context of a browser, the only way that a custom header of this nature can be added is with XMLHttpRequest. [ef911ec26a0d0aaf-2]
- * Many AJAX toolkits add an X-Requested-With header when using XMLHttpRequest. [c1711033993a0635-2]
- ========================== Django 1.2.5 release notes ========================== [806ad284]
- Additionally, Django will now accept the CSRF token in the custom HTTP header X-CSRFTOKEN, as well as in the form submission itself, for ease of use with popular JavaScript toolkits which allow insertion of custom headers into all AJAX requests. [a6f4647cfbbc4d9b-2]
- Backwards incompatible changes ============================== [f2cb124aa97ba055-4]
- CSRF exception for AJAX requests -------------------------------- [f9f33cacdb1a4b91-2]
- Django 1.2.4 introduced a method ``lookup_allowed`` on ``ModelAdmin``, to cope with a security issue (changeset :commit:`[15033] <85207a245bf09fdebe486b4c7bbcb65300f2a693>`). Although this method was never documented, it seems some people have overridden ``lookup_allowed``, especially to cope with regressions introduced by that changeset. While the method is still undocumented and not marked as stable, it may be helpful to know that the signature of this function has changed. [4a6d445a]
- Django includes a CSRF-protection mechanism, which makes use of a token inserted into outgoing forms. Middleware then checks for the token's presence on form submission, and validates it. [fb2a915651ca04f5-2]
- Django provides a custom SQL hooks as a way to inject hand-crafted SQL into the database synchronization process. One of the possible uses for this custom SQL is to insert data into your database. If your custom SQL contains ``INSERT`` statements, those insertions will be performed every time your database is synchronized. This includes the synchronization of any test databases that are created when you run a test suite. [3919826b08d1ac96]
- FileField no longer deletes files --------------------------------- [1a6d5e3b]
- For full details on the new features, backwards incompatibilities, and deprecated features in the 1.2 branch, see the :doc:`/releases/1.2`. [d239dffcb32222b1-3]
- However, in the process of testing the Django 1.3, it was discovered that this feature has never completely worked as advertised. When using database backends that don't support transactions, or when using a TransactionTestCase, data that has been inserted using custom SQL will not be visible during the testing process. [12014225c08a987b]
- Michael Koziarski of the Rails team brought this to our attention, and we were able to produce a proof-of-concept demonstrating the same vulnerability in Django's CSRF handling. [fff67cb57ab70001-2]
- ModelAdmin.lookup_allowed signature changed ------------------------------------------- [873cce05]
- Please see the :ref:`CSRF docs for example jQuery code <csrf-ajax>` that demonstrates this technique, ensuring that you are looking at the documentation for your version of Django, as the exact code necessary is different for some older versions of Django. [bdf74a1981fb2981-2]

## All facts

- [800f63f0] In earlier Django versions, when a model instance containing a :class:`~django.db.models.FileField` was deleted, :class:`~django.db.models.FileField` took it upon itself to also delete the file from the backend storage. This opened the door to several potentially serious data-loss scenarios, including rolled-back transactions and fields on different models referencing the same file. In Django 1.2.5, :class:`~django.db.models.FileField` will never delete files from the backend storage. If you need cleanup of orphaned files, you'll need to handle it yourself (for instance, with a custom management command that can be run manually or scheduled to run periodically via e.g. cron).
- [cd2a9f85142eda54-2] Prior to Django 1.2.5, our CSRF protection made an exception for AJAX requests, on the following basis:
- [b9f8ea76652b8240-2] Recently, engineers at Google made members of the Ruby on Rails development team aware of a combination of browser plugins and redirects which can allow an attacker to provide custom HTTP headers on a request to any website. This can allow a forged request to appear to be an AJAX request, thereby defeating CSRF protection which trusts the same-origin nature of AJAX requests.
- [4089a6c9f535a706-2] Therefore, for ease of use, we did not apply CSRF checks to requests that appeared to be AJAX on the basis of the X-Requested-With header. The Ruby on Rails web framework had a similar exemption.
- [b0544aa81cf8ca53] This change only affects the testing process. You can still use custom SQL to load data into your production database as part of the ``syncdb`` process. If you require data to exist during test conditions, you should either insert it using :ref:`test fixtures <topics-testing-fixtures>`, or using the ``setUp()`` method of your test case.
- [42dd0132] This is the fifth "bugfix" release in the Django 1.2 series, improving the stability and performance of the Django 1.2 codebase.
- [8370f126dc5e7c8e-2] To remedy this, Django will now apply full CSRF validation to all requests, regardless of apparent AJAX origin. This is technically backwards-incompatible, but the security risks have been judged to outweigh the compatibility concerns in this case.
- [e0bab9e25fa4176e] Unfortunately, there was no way to rectify this problem without introducing a backwards incompatibility. Rather than leave SQL-inserted initial data in an uncertain state, Django now enforces the policy that data inserted by custom SQL will *not* be visible during testing.
- [1b96e5f7fe85b082] Use of custom SQL to load initial data in tests -----------------------------------------------
- [79a4f50e] Welcome to Django 1.2.5!
- [6040e0f2] With four exceptions, Django 1.2.5 maintains backwards compatibility with Django 1.2.4. It also contains a number of fixes and other improvements. Django 1.2.5 is a recommended upgrade for any development or deployment currently using or targeting Django 1.2.
