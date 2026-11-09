# docs/internals/contributing/bugs-and-features

- Subject: docs/internals/contributing/bugs-and-features (id `48325262-f642-4596-ba1f-ba45c2b6984a`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 17 of 68
- Conflicts: 0
- Gaps: 0

## Facts

- $ python -Wa manage.py test [101af2650c64d744-3]
- $ python -m pip install --pre Django [1ae397e4]
- Please report security issues **only** to ``security@djangoproject.com``. This is a private list only open to long-time, highly trusted Django developers, and its archives are not public. For further details, please see :doc:`our security policies </internals/security>`. [c177c6a0973dc325]
- .. code-block:: console [faf6f5a8efbd7831-3]
- * **Check dependency support:** Determine whether major dependencies support the new version by checking Django version classifiers on PyPI. Since those projects also value early bug reports, don't let a lack of support prevent you from testing. * **Monitor performance:** You can run your tests with the :option:`test --durations` flag to identify potential performance regressions. * **Automate tests in CI:** Consider running your Continuous Integration (CI) pipeline with the pre-release version. * **Test manually:** While automated tests are great, manually testing your application's main workflows is an important part of verifying compatibility with a new release. [c5d08494]
- * **Do** ask on `Django Forum`_ or the `Django Discord server`_ *first* if you're not sure if what you're seeing is a bug. [d64e641b]
- * **Do** read the :doc:`FAQ </faq/index>` to see if your issue might be a well-known question. [a347456e]
- * **Do** write complete, reproducible, specific bug reports. You must include a clear, concise description of the problem, and a set of instructions for replicating it. Add as much debug information as you can: code snippets, test cases, exception backtraces, screenshots, etc. A nice small test case is the best way to report a bug, as it gives us a helpful way to confirm the bug quickly. [f533faf7]
- * **Don't** post to `Django Forum`_ only to announce that you have filed a bug report. All the tickets are mailed to another list, |django-updates|, which is tracked by developers and interested community members; we see them as they are filed. [c8826aef]
- * **Read the release notes:** Review the :doc:`/releases/index` for the upcoming version to learn about upgrade paths for deprecated features or about minor backward-incompatible changes. * **Resolve deprecation warnings:** Run your tests with deprecation warnings enabled to become aware of required follow-up actions: [aa506ebe]
- * +0: "Sounds OK to me." [d8f4e454]
- * +1: "I love the idea and I'm strongly committed to it." [fe1f6e03]
- * -0: "I'm not thrilled, but I won't stand in the way." [eafb5315]
- * -1: "I strongly disagree and would be very unhappy to see the idea turn into reality." [ce6383ec]
- * Check that someone hasn't already filed the bug report by `searching`_ or running `custom queries`_ in the ticket tracker. [8ab5a5d8]
- * Describe clearly and concisely what the missing feature is and how you'd like to see it implemented. Include example code (non-functional is OK) if possible. [0d161b0e]
- * Don't reopen issues that have been marked "needsnewfeatureprocess" without shepherding an issue through the `new feature ideas`_ GitHub project. [00bf2c16]

## Beyond the budget

50 more facts did not fit in the budget: [7a0dd707] [04bdf04c] [48044bc0] [53d697df] [8688b380] [1696c907] [b268872e] [92ef26d9] [0474797f] [b11cdee6] [9692532d] [7777aebd] [b464c013] [87e2461c] [d7000d4de70da096] [23d04747] [fe050392] [971706b2] [51370548] [6fc4f1d5] [faf6f5a8efbd7831-4] [416d1a3c] [4596bb19] [b78bf640] [eeab0aeb] [5e19b4b0] [8c953522] [68f42a13] [ad1a1732] [4fc7dcb9] [ab36ed7a] [f0b85f9e] [87f2d07e] [57f822e4] [23190d12] [14f40e87] [9b444216] [0f072870] [1132747c] [46d322a7] [8cc2e164] [eab3bd3f] [ebe93c6d] [aa89a0df] [6c85ebde] [e9928b06] [d54d5840] [f99028c6] [e1d8f2b7] [cb13450e]
