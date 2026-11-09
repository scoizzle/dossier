# docs/internals/contributing/triaging-tickets

- Subject: docs/internals/contributing/triaging-tickets (id `57d06d2a-abfe-4e57-9138-3bf35738bc74`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 20 of 164
- Conflicts: 0
- Gaps: 0

## Facts

- $ ./runtests.py migrations.test_regression [7fa46681]
- $ git bisect bad You need to start by "git bisect start" Do you want me to do it for you [Y/n]? y [acd1fc22]
- $ git bisect good Bisecting: X revisions left to test after this (roughly Y steps) ... [51223cc1]
- $ git bisect run tests/runtests.py migrations.test_regression [a92d4450]
- .. _Reports page: https://code.djangoproject.com/wiki/Reports [cea09db3]
- Our Trac system and GitHub repositories are intentionally open to the public. Anyone can help by working on tickets, triaging tickets and reviewing changes. Django is a community project, and we encourage :ref:`triage and collaboration by the community <how-can-i-help-with-triaging>`. We truly want you to help! [4c405368]
- The `Reports page`_ contains links to many useful Trac queries, including several that are useful for triaging tickets and reviewing proposals as suggested above. [a53c7e94]
- You can also find more :doc:`/internals/contributing/new-contributors`. [46d8d425]
- * Are the APIs and documentation accessible and well explained? [618fa609]
- * Run benchmark tests by labeling the pull request with "benchmark". [ed4a191f]
- * Use the change and provide feedback from that experience. [279accec]
- * Utilize :ref:`django-asv-benchmarks` to check performance over time. [c8fb779b]
- For new features, accepted tickets should only exist after the idea has gone through the appropriate :ref:`process for suggesting new features <requesting-features>` and received community and :ref:`Steering Council <steering-council>` approval, or been accepted in a DEP. [e7105657]
- The ticket is valid, but no one has submitted a patch for it yet. Often this means you could safely start writing a fix for it. This is generally more true for the case of accepted bugs than accepted features. A ticket for a bug that has been accepted means that the issue has been verified by at least one triager as a legitimate bug - and should probably be fixed if possible. [21f1cd4f]
- The ticket is waiting for people to review the supplied solution. This means downloading the patch and trying it out, verifying that it contains tests and docs, running the test suite with the included patch, and leaving feedback on the ticket. [06feadaa]
- This means the ticket has been reviewed, and has been found to need further work. "Needs tests" and "Needs documentation" are self-explanatory. "Patch needs improvement" will generally be accompanied by a comment on the ticket explaining what is needed to improve the code. [905b4cf9]
- * **Be polite.** No one likes having their ticket closed. It can be frustrating or even discouraging. The best way to avoid turning people off from contributing to Django is to be polite and friendly and to offer suggestions for how they could improve this ticket and other tickets in the future. [3fc8fbe7]
- * **Needs PR Review** (Accepted + Has Patch) [11a6b127]
- * **Needs Patch** (Accepted + No Flags) [f4c6c278]
- .. _bisecting-a-regression: [df855279]

## Beyond the budget

144 more facts did not fit in the budget: [63af887d] [b7f2fd3a] [674b2845] [d0175fda] [8073af03] [6cf18cfc] [2b684ec9] [6bed6917] [1cb0639e] [92f243df] [52dcb435] [cf4e60d8] [92a07f9c] [232491b8] [2ff34e7e] [22cef395] [0b6009ec] [a1f8d221] [5af43ba6] [1ff0fc7c] [4354ccb9] [79525af0] [11a5c53f] [fe3e42ac] [c1ee9c95] [41f8548a] [3e20f818] [718f544d] [42f01436] [6213e83b] [157f1352] [a66fefd8] [a48e4859] [7d4b594e] [e396a798] [fee8f62d] [7f4e70f5] [83687016] [f1c99dab] [ddbf45e3] [1fdd6610] [755d391f] [898bafe6] [00f53816] [fc7eea6a] [87853e04] [11331cd2] [3efc85d6] [3b691b6c] [33b75a0a] [a66de8b0] [8aa7203c166b13be-24] [8aa7203c166b13be-25] [8aa7203c166b13be-26] [8aa7203c166b13be-27] [b958de05] [942ae6c11625c81c-14] [9fe4103e] [89f6df7c] [26129bd8] [a2b0afe5] [59c569ff] [a8a4e632] [69613f8f] [106769ad] [bc3a64d5] [f5faf4ac] [4d60e712] [cf399262] [d76786da] [8ad86eb4] [5f93123e] [6e94e48f] [37de9951] [f456c1a5] [6d5044d4] [928bd6a2] [b7907a15] [8cd6a608] [4bba72a9] [660514b9] [3cb6c26f] [9605c62b] [69c09967] [177e80f1] [a2fd2bb6] [b4bd723c] [0daa5f26] [2af461d1] [bd2cc43b] [6fb572b6] [e022d762] [ffda3852] [fb6a6df9] [1011fe63] [d790324c] [1361a5d1] [2c50aa3c] [922f4bcf] [82600dd9] [3e9f1516] [e1879ff4] [027bbf4a] [5cfb941d] [6a689ddd] [95eb1cf7] [29364a6b] [5276eced] [dd79d4b4] [934ebfbb] [a9b45eb9] [6f8d4635] [fad219a5] [7e06f190] [4f60fc00] [d493847f] [5a541523] [41961268] [9e352719] [dbee1fc5] [6d214b43] [9628ccc0] [2961138b] [663060a9] [df9075bf] [906dadee] [bddf1f5c] [2e43f457] [9c7cf47d] [e93f763d] [00c82af3] [fac36c40] [74496b4c] [01c75e44] [36d64972] [0557321b] [d1c8302f] [9baa1284] [036cd3b9] [52ca041b] [c44cacc2] [cb4d7564] [bf62b172] [9bea7a7e]
