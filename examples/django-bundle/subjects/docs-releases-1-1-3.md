# docs/releases/1.1.3

- Subject: docs/releases/1.1.3 (id `a59104e3-5df8-4956-a41e-677da18d5081`)
- Kind: subject
- Budget: 1200 tokens
- Used: 686 tokens
- Facts shown: 11 of 11
- Conflicts: 0
- Gaps: 0

## Facts

- ========================== Django 1.1.3 release notes ========================== [1853c8a8]
- Backwards incompatible changes ============================== [f2cb124aa97ba055]
- For full details on the new features, backwards incompatibilities, and deprecated features in the 1.1 branch, see the :doc:`/releases/1.1`. [c5816bb0ad26b431-2]
- However, it has been demonstrated that this can be abused to gain access to information outside of an admin user's permissions; for example, an attacker with access to the admin and sufficient knowledge of model structure and relations could construct query strings which -- with repeated use of regular-expression lookups supported by the Django database API -- expose sensitive information such as users' password hashes. [ef891265cf1578be]
- One historically-undocumented and -unofficially-supported feature has been the ability for a user with sufficient knowledge of a model's structure and the format of these lookup arguments to invent useful new filters on the fly by manipulating the querystring. [268206f0aaa31a43]
- Restricted filters in admin interface ------------------------------------- [67efa09035dab44d]
- The Django administrative interface, ``django.contrib.admin``, supports filtering of displayed lists of objects by fields on the corresponding models, including across database-level relationships. This is implemented by passing lookup arguments in the querystring portion of the URL, and options on the ModelAdmin class allow developers to specify particular fields or relationships which will generate automatic links for filtering. [9b9505832d70fe4a]
- This is the third "bugfix" release in the Django 1.1 series, improving the stability and performance of the Django 1.1 codebase. [95efdbed]
- To remedy this, ``django.contrib.admin`` will now validate that querystring lookup arguments either specify only fields on the model being viewed, or cross relations which have been explicitly allowed by the application developer using the preexisting mechanism mentioned above. This is backwards-incompatible for any users relying on the prior ability to insert arbitrary lookups. [106d1ccd690f41d7]
- Welcome to Django 1.1.3! [bb0ceb9a]
- With one exception, Django 1.1.3 maintains backwards compatibility with Django 1.1.2. It also contains a number of fixes and other improvements. Django 1.1.2 is a recommended upgrade for any development or deployment currently using or targeting Django 1.1. [aa144111]
