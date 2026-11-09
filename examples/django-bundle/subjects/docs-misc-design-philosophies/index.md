# docs/misc/design-philosophies

- Subject: docs/misc/design-philosophies (id `c09e72cf-ffd7-4346-8783-1ba6654fd301`)
- Kind: subject
- Budget: 1200 tokens
- Used: 896 tokens
- Facts shown: 35 of 106
- Conflicts: 0
- Gaps: 0

## Facts

- The `discussion of DRY on the Portland Pattern Repository`__ [92b353cf]
- __ https://wiki.c2.com/?DontRepeatYourself [7e7942e2]
- .. _`Active Record`: https://www.martinfowler.com/eaaCatalog/activeRecord.html [ff672f5f]
- .. _`loose coupling and tight cohesion`: https://wiki.c2.com/?CouplingAndCohesion [7cf8700c]
- .. _cache-design-philosophy: [dad4402d]
- .. _consistency: [45c6049a]
- .. _definitive-urls: [d231db8f]
- .. _dry: [28f83457]
- .. _explicit-is-better-than-implicit: [36fa503b]
- .. _less-code: [d8db4630]
- .. _loose-coupling: [b0e57d44]
- .. _quick-development: [97f80358]
- .. _separation-of-logic-and-presentation: [e78872e4]
- .. index:: single: DRY single: Don't repeat yourself [767e9bc1]
- .. index:: coupling; loose [19c7bc84]
- .. index:: urls; definitive [5e8aebe5]
- .. index:: xml; suckiness of [e650de7f]
- .. seealso:: [6b4a5e54e001d097-15]
- =================== Design philosophies =================== [609b1432]
- A cache should be as fast as possible. Hence, all framework code surrounding the cache backend should be kept to the absolute minimum, especially for ``get()`` operations. [b90952da]
- A fundamental goal of Django's stack is `loose coupling and tight cohesion`_. The various layers of the framework shouldn't "know" about each other unless absolutely necessary. [992243a8]
- A view shouldn't care about which template system the developer uses -- or even whether a template system is used at all. [c2b3c103]
- Along these lines, the Django URL system should allow URLs for the same app to be different in different contexts. For example, one site may put stories at ``/stories/``, while another may use ``/news/``. [f0a3985a]
- Although Django comes with a full stack for convenience, the pieces of the stack are independent of another wherever possible. [91d280c4]
- Assume designer competence -------------------------- [cad41e09]
- Be decoupled from HTML ---------------------- [3db704d5]
- Cache Framework =============== [ece1bdfa]
- Consistency ----------- [1e70db07a3889c25]
- Consistency ----------- [1e70db07a3889c25-2]
- Database API ============ [495696c5]
- Definitive URLs --------------- [a4c99434]
- Differentiate between GET and POST ---------------------------------- [493c87df]
- Discourage redundancy --------------------- [89792898]
- Django apps should use as little code as possible; they should lack boilerplate. Django should take full advantage of Python's dynamic capabilities, such as introspection. [183f4df0]
- Don't invent a programming language ----------------------------------- [dd847ed0]

## Beyond the budget

69 more facts did not fit in the budget: [7a97e653] [aaf7ca98] [930bb42f] [2d118164] [b2aa54db7fd8deb1] [b2aa54db7fd8deb1-2] [31ab1a81] [21a88ae5] [1eaefaed] [6ddf0c59] [4df9d061] [15b923f7] [e37efd0a] [58c7e991] [bbe9c0a85f49e82b] [bbe9c0a85f49e82b-2] [24063235a087e6d2] [24063235a087e6d2-2] [24063235a087e6d2-3] [0f8f215e610fb29a] [1b051880] [03db2fe9] [5f5c6a38] [2b9bc20b] [9538bd38] [079aed1b] [3fafb5dd] [1c213ac1] [7b969104] [b4b3cc7d] [a00925a5] [ab0cd24a] [fac7820c] [6c56d98d] [a63c45c1] [4b4d2e30] [983e18db] [1f1e45d5] [87cae760] [a13c753f] [70678c6c] [e69bee5c] [c8df7940] [13d05762] [d54f34dc] [a531eb5c] [2318c80a] [1c90caa8] [12db412f] [661986fa] [bf121743] [ad5db0b5] [04c6c615] [430ce597] [a0d47e99] [c146d297] [c7624f6f] [9aca98ad] [86a9edcd] [391913f9] [dcd8bcc2] [c8110958] [13d3157a] [4fcfa687] [44ce6a64] [b61fd224] [062a3d8e] [2a8aa9a5] [61deea5f]
