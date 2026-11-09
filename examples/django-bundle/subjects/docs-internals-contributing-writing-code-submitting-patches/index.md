# docs/internals/contributing/writing-code/submitting-patches

- Subject: docs/internals/contributing/writing-code/submitting-patches (id `32ea870c-ad9b-442c-aba9-19ec9b5fc0d9`)
- Kind: subject
- Budget: 1200 tokens
- Used: 890 tokens
- Facts shown: 21 of 138
- Conflicts: 0
- Gaps: 0

## Facts

- # RemovedInDjangoXXXXWarning. def old_private_helper(): # Helper function that is only used in foo(). pass [def15f05]
- @ignore_warnings(category=RemovedInDjangoXXXXWarning) class MyDeprecatedTests(unittest.TestCase): ... [e3b1a047]
- @ignore_warnings(category=RemovedInDjangoXXXXWarning) def test_foo(self): ... [1584a066]
- def foo(): warnings.warn( "foo() is deprecated.", category=RemovedInDjangoXXXXWarning, skip_file_prefixes=django_file_prefixes(), ) old_private_helper() ... [c0ccaef5]
- def test_foo_deprecation_warning(self): msg = "Expected deprecation message" with self.assertWarnsMessage(RemovedInDjangoXXXXWarning, msg) as ctx: # invoke deprecated behavior ... self.assertEqual(ctx.filename, __file__) [88deb849]
- from django.test import ignore_warnings from django.utils.deprecation import RemovedInDjangoXXXXWarning [d477b139cfe88760]
- from django.utils.deprecation import RemovedInDjangoXXXXWarning [1b9e642c]
- import warnings from django.utils.deprecation import RemovedInDjangoXXXXWarning, django_file_prefixes [c6f6f942]
- "Claiming" tickets ================== [20648e46]
- #) Add a description of the deprecated behavior, and the upgrade path if applicable, to the current release notes (``docs/releases/A.B.txt``) under the "Features deprecated in A.B" heading. [71946bbf]
- #) Add an entry in the deprecation timeline (``docs/internals/deprecation.txt``) under the appropriate version describing what code will be removed. [b819f764]
- #) For an entire test case:: [6b82e510]
- #) If the existing feature is documented, mark it deprecated in documentation using the ``.. deprecated:: A.B`` annotation. Include a short description and a note about the upgrade path if applicable. [6d32e4a0]
- #) In a particular test:: [798c8461]
- #. Create a virtual environment and :ref:`install the cloned copy of Django in editable mode <intro-contributing-install-local-copy>`. [b5e2f33a]
- #. Set up a Django project outside the source tree (you can use the :doc:`first part of the tutorial </intro/tutorial01>` for guidance). [3df41a11]
- * **Disclose** which AI tools were used and what they were used for (e.g., generating code, drafting commit messages, writing documentation). [b09bb430]
- * **Review and verify** all AI-generated output. Ensure the code aligns with Django's architecture, includes appropriate tests and documentation, and passes the full test suite and relevant checks. [a857010f]
- * Are there tests to "exercise" all of the new code? * Is there a release note in ``docs/releases/A.B.txt``? * Is there documentation for the feature and is it :ref:`annotated appropriately <documenting-new-features>` with ``.. versionadded:: A.B`` or ``.. versionchanged:: A.B``? [655b707a]
- * Assist reviewers. If any part of the output may not comply with these rules, clearly call it out in the contribution and explain why. [cd99ac6b]
- * Double-check the proposal against the :ref:`patch-review-checklist`. [eef62df6]

## Beyond the budget

116 more facts did not fit in the budget: [b88ff21a] [9a488059] [21df7ea1] [fbe59fbd] [cc3b27f2] [abffe55b] [6fe45f55] [4dcbf5c6] [4386aeda] [ce416daa] [f7c608a2] [aaae62e3] [cca41565] [1855a1ff] [f0fce612] [a201ba9b] [4d944bff] [4b94ca5a] [816146ef] [98ec0f5a] [dec493a0] [428077d2] [17bba24c] [eec4730a] [033e404c] [3ff236d1] [065058b0] [bc3a2d48] [f03d6e23] [7a0fb1c8] [c2181ede] [3a88be19] [8fbb925a] [76311ee7] [24d2da78] [ef7f905d] [bd34661b] [eb14d718] [7dd49914] [3be970ee] [9f8ee0ad] [7ade9dee] [8fc6dcd6] [6153b322] [a0c99917] [4e4e9cd6] [7a2fb46b] [3474330d] [d9f1f4f8] [9784552a] [6e01336d] [dbe7ea28] [523520cb] [3dd841d0] [4f8c5913] [595de508] [a4ab1b1c] [c20982a9] [e34df76c] [bcff98ea] [78ea00e9] [f17b4327] [85af067a] [ffb9f498] [4167a351] [ea349f70] [fdeb297d] [aab98740] [7e3870dc] [3cfb483d] [7d1864bd] [05d772da] [a428ab3c] [22850f14] [94ed148e] [6f6c6aaa] [7539486b] [f624f806] [bc5931f0] [6a42df69] [f2bed6c2a49a4853] [e48ba691] [e630ad3f] [1ddd4f31] [e2fbb6e9] [f536438c] [f4e46a8e] [ce92773e] [94068e28] [d719db8c] [7f4d8775] [e9c9ed67] [1bae1024] [3bf227c3] [e844c678] [212e66aa] [a87426af] [83eccb73] [9bcb162e] [96767ffd] [c17c7f5b] [07d2950b] [0fc0eb0c] [3375da76] [7c8b7fd7] [de9ef30a] [03b78cbc] [1dee909a] [2be127ed] [c96ee206] [891df95c] [a8f8a34d] [d6460d04] [9951d5fa] [bf776856] [72835029]
