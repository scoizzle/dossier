# docs/internals/git

- Subject: docs/internals/git (id `62a66751-5c3e-4706-9b4d-ecd017d8bb93`)
- Kind: subject
- Budget: 1200 tokens
- Used: 888 tokens
- Facts shown: 18 of 65
- Conflicts: 0
- Gaps: 0

## Facts

- For example, shortly after the release of Django 1.3 the branch ``stable/1.3.x`` was created. Official support for that release has expired, and so it no longer receives direct maintenance from the Django project. However, that and all other similarly named branches continue to exist, and interested community members have occasionally used them to provide unofficial support for old Django releases. [7476f3b9]
- Previously, these branches weren't created until right after the releases and the stabilization work occurred on the main repository branch. Thus, no new feature development work for the next release of Django could be committed until the final release happened. [672e6880]
- Since Django moved to Git in 2012, anyone can clone the repository and create their own branches, alleviating the need for official branches in the source code repository. [6587a5b5]
- The following section is mostly useful if you're exploring the repository's history, for example if you're trying to understand how some features were designed. [8dcda3c3]
- This policy for handling ``stable/A.B.x`` branches was adopted starting with the Django 1.5 release cycle. [6af60923]
- Prior to March 2021, the main branch was called ``master``. [7673ddcd]
- * ``boulder-oracle-sprint``: Added support for Oracle databases to Django's object-relational mapper. This has been part of Django since the 1.0 release. [cc9f2f88]
- * ``full-history`` [7b550ca9]
- * ``generic-auth`` [b96fa268]
- * ``gis``: Added support for geographic/spatial queries to Django's object-relational mapper. This has been part of Django since the 1.0 release, as the bundled application ``django.contrib.gis``. [f9e3013a]
- * ``i18n``: Added :doc:`internationalization support </topics/i18n/index>` to Django. This has been part of Django since the 0.90 release. [feb93144]
- * ``magic-removal``: A major refactoring of both the internals and public APIs of Django's object-relational mapper. This has been part of Django since the 0.95 release. [e640c483]
- * ``main`` contains the main in-development code which will become the next packaged release of Django. This is where most development activity is focused. [bda1c75d]
- * ``multi-auth``: A refactoring of :doc:`Django's bundled authentication framework </topics/auth/index>` which added support for :ref:`authentication backends <authentication-backends>`. This has been part of Django since the 0.95 release. [df635a15]
- * ``multiple-db-support`` [d390ffa5]
- * ``new-admin``: A refactoring of :doc:`Django's bundled administrative application </ref/contrib/admin/index>`. This became part of Django as of the 0.91 release, but was superseded by another refactoring (see next listing) prior to the Django 1.0 release. [6ce332a9]
- * ``newforms-admin``: The second refactoring of Django's bundled administrative application. This became part of Django as of the 1.0 release, and is the basis of the current incarnation of ``django.contrib.admin``. [4e528955]
- * ``per-object-permissions`` [a0bafc65]

## Beyond the budget

46 more facts did not fit in the budget: [99017f37] [c6dd093e] [af962bc9] [3551f0c0] [06406a6f] [0aa18ef4] [3dd491fc] [cb2ccfc2] [9a10da1b] [73ab7b83] [af705cab] [2c9bd93051411b26] [2c9bd93051411b26-2] [942ae6c11625c81c-15] [ff11ea7b] [94138150] [391d347f] [54df0152] [91c09e8e] [e456f2d5] [420db252] [2dd4f5e7] [b6a570bd] [56285976] [7560448e] [da4ab83b] [2f47171f] [b9be394a] [205276b5] [984ce0d9] [99ac95f2] [6300b1af] [32cce9a4ed33af09] [94f4a2ce] [d6a325e9] [cef773a4] [111b7246] [ca6932ac] [8b3b834e] [0b221583] [b9446bae] [70c4ddc9] [365c83fb] [b9e2f579] [0dee0df2] [6462646c]
