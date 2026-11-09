# docs/internals/contributing/localizing

- Subject: docs/internals/contributing/localizing (id `994580d1-7aa6-4570-b4e3-343eab7bed55`)
- Kind: subject
- Budget: 1200 tokens
- Used: 884 tokens
- Facts shown: 18 of 23
- Conflicts: 0
- Gaps: 0

## Facts

- .. note:: For more information about how to use Transifex, read the `Transifex User Guide`_. [f520bc58]
- * :ref:`Create a pull request <patch-review-checklist>` against the Django Git ``main`` branch, as for any code change. [d831cdbc]
- * Introduce yourself on the `Django internationalization forum`_. [18460af4]
- * Make sure you read the notes about :ref:`specialties-of-django-i18n`. [7071490a]
- * On the `Django project page`_, choose the language you want to work on, **or** -- in case the language doesn't exist yet -- request a new language team by clicking on the "Request language" link and selecting the appropriate language. [1e5be173]
- * Once you are a member of a team choose the translation resource you want to update on the team page. For example, the "core" resource refers to the translation catalog that contains all non-contrib translations. Each of the contrib apps also has a resource (prefixed with "contrib"). [8dbc4e5a]
- * Open a ticket in Django's ticket system, set its ``Component`` field to ``Translations``, set the "has patch" flag, and include the link to the pull request. [c41aebbe]
- * Sign up at `Transifex`_ and visit the `Django project page`_. [b060d920]
- * Then, click the "Join this Team" button to become a member of this team. Every team has at least one coordinator who is responsible to review your membership request. You can also contact the team coordinator to clarify procedural problems and handle the actual translation process. [ce957ea7]
- .. _Transifex: https://www.transifex.com/ .. _Django project page: https://app.transifex.com/django/django/ .. _Django internationalization forum: https://forum.djangoproject.com/c/internals/i18n/14 .. _Transifex User Guide: https://help.transifex.com/ [ea9afda8]
- .. _translating-documentation: [1e15f02b]
- ================= Localizing Django ================= [b9eabc64]
- Documentation ============= [c4250903]
- Formats ======= [f0f22092]
- If you find an incorrect translation or want to discuss specific translations, go to the `Django project page`_. If you would like to help out with translating or adding a language that isn't yet translated, here's what to do: [76724751]
- Once translations are published, updated versions from Transifex will be irregularly ported to the `django/django-docs-translations <https://github.com/django/django-docs-translations>`_ repository and to the documentation website. Only translations for the latest stable Django release are updated. [14bcbe0f]
- The format files aren't managed by the use of Transifex. To change them, you must: [ed5122f5]
- There is also an opportunity to translate the documentation, though this is a huge undertaking to complete entirely (you have been warned!). We use the same `Transifex tool <https://app.transifex.com/django/django-docs/>`_. The translations will appear at ``https://docs.djangoproject.com/<language_code>/`` when at least the ``docs/intro/*`` files are fully translated in your language. [c17165f9]

## Beyond the budget

5 more facts did not fit in the budget: [edca6f52] [d62cb18d] [bafe7955] [f72e8382] [37c5ef49]
