# docs/internals/release-process

- Subject: docs/internals/release-process (id `ce3214d8-8294-437d-ad7a-a279006de4c7`)
- Kind: subject
- Budget: 1200 tokens
- Used: 896 tokens
- Facts shown: 21 of 128
- Conflicts: 0
- Gaps: 0

## Facts

- .. _the download page: https://www.djangoproject.com/download/ [87cb15f6]
- See `the download page`_ for the ``A.B`` releases that have been designated for long-term support. [4e64ea5c]
- Starting with Django 2028, there are no separate LTS releases. All feature releases receive security and data loss fixes for three years: one year of mainstream support followed by two years of extended support. See the :ref:`annual release cycle <annual-supported-versions>` for more details. [71ff836e]
- These releases will be 100% compatible with the associated feature release, unless this is impossible for security reasons or to prevent data loss, in which case the release notes will provide detailed upgrade instructions. Generally, you should always upgrade to the latest patch release. Each patch release supersedes earlier patch releases in its series, which may contain known security vulnerabilities. [44f9848d]
- * Crashing bugs. [4a01d54d]
- * Data loss bugs. [14de642f]
- * Major functionality bugs in new features of the latest stable release. [caefc27a]
- * Regressions from older versions of Django introduced in the current release series. [1d15a609]
- * Security issues. [574e309d]
- Feature release Feature releases contain new features, improvements to existing features, and other enhancements. Each version will be mostly backwards compatible with the previous release. Exceptions to this rule will be listed in the release notes. [7d9788ab]
- Long-term support release Under the ``A.B`` versioning scheme, certain feature releases are designated as long-term support (LTS) releases. These releases receive security and data loss fixes for three years. [8153ec42]
- Patch release A release containing bug fixes and/or security fixes, issued as needed. [8e0da4be]
- The rule of thumb is that fixes will be backported to the last feature release for bugs that would have prevented a release in the first place (release blockers). [bfb3728b]
- * Before a new feature release, there are alpha, beta, and release candidate releases, for example 2028 alpha 1, 2028 beta 1, and 2028 rc 1. [dedcc84b]
- * Before a new feature release, we'll make alpha, beta, and release candidate releases. These are of the form ``A.B alpha/beta/rc N``, which means the ``Nth`` alpha/beta/release candidate of version ``A.B``. [e8dccf79]
- * Critical bug fixes will be applied to the ``stable/2029.x`` branch, and released roughly once a month as patch releases 2029.1, 2029.2, etc. [ca41028e]
- * Critical bug fixes will be applied to the ``stable/5.1.x`` branch, and released as 5.1.1, 5.1.2, etc. [ea554a1a]
- * Django 2028 will contain the deprecated feature and raise a ``RemovedInDjango2030Warning``. [e974d266]
- * Django 2029 will continue to contain the deprecated feature. [0baf174c]
- * Django 2030 will remove the feature. [14d4a109]
- * Django 4.2 will contain a backwards-compatible replica of the function which will raise a ``RemovedInDjango51Warning``. [ba4b9d51]

## Beyond the budget

91 more facts did not fit in the budget: [3f797b61] [fc38d645] [b9419995] [6d1c864d] [8c3eaf2f] [5ad958c0] [45bbd58a] [5c55314d] [f399d9b7] [697b4411] [2e250873] [39c10acc] [63cfa4c3] [b3d035c2] [95699a83] [2f8b74e9] [bd689ad2] [606cc14d] [728e3bae] [7f0e1ef4] [4dec8984] [12d9135c] [9eeb33d1] [60b99e9b] [50be2e44] [a814c8e5] [268dedd8] [cdfb3aca] [f71bcc4b] [8ae062d3] [6ace0d2e] [5612377a] [68c83176] [1f2b4882462bc951-2] [ea76918a] [f1b5126b] [02ddc9b6] [406482d2] [406e314d] [941053fd] [00ba3fafe2a55c17] [94bfba2801c0f6ef] [4b14f615] [4e57f3de] [d5587a28] [c628fee8] [9959af07] [65299349] [23614d43] [4230a981] [32df3725] [3ae8162d] [3733a883] [fced91b5] [9434c86d] [e38141e4] [8a37c5a1] [4f3f6577] [8340ed22] [9818998c32f165ec] [ebfd21d0] [09878474] [3d9868e8] [b532d051] [36fa90da58a8960c] [f78f35575fa5ee8a] [0e5e5e7b] [a57aee59] [ef567a7a] [a90b18ae] [89122134] [2adbdd30] [68571245] [24b4d081] [c756d548] [7108f2e6] [a6f4374d] [31e801e9] [d7334f8c48e47322] [5844d9dd] [c8a4d1c9] [93d39740] [2b58b2e5] [be1eb08b] [4982c6af531ad1e9] [e93d3527] [550592171df5e2dc] [135413b2] [0f19b587] [6a2cb388] [aa892819735db8ae]
