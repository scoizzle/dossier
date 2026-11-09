# docs/internals/contributing/accessibility

- Subject: docs/internals/contributing/accessibility (id `2a7437b9-b5ce-45a7-8010-2a140785957d`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 18 of 46
- Conflicts: 0
- Gaps: 0

## Facts

- * A touch target (interactive element) is too small. * Hover-based interaction that does not translate to touch, such as a hover-only tooltip. [867cb1fc]
- * An interactive element can't be reached using the Tab or arrow keys. * An interactive element "traps" input focus and prevents navigating away. * An interactive element doesn't give a visible indication when it has input focus. * The focus order is inconsistent with the logical order that's communicated visually. [76e42b0e]
- * Content is cut off or disappears when zoomed. * Content that does not inherently require a two-dimensional layout causes scrolling in both directions (vertical and horizontal). Two-dimensional scrolling is acceptable for content like images, maps, videos, and data tables, which require both dimensions to be usable. [19d2e8ee]
- * Over-reliance on color for meaning, which is lost in forced-colors mode. * Use of ``!important`` or inline styles may break forced-colors mode. [19306006]
- * 400% browser zoom. Common issues include: [5a5e07a1]
- * Forced-colors mode (for example Windows Contrast Themes). Note that this can be tested via the ``"high_contrast"`` mode in the :ref:`screenshot tests <screenshot-tests>`. Common issues include: [7af4ddac]
- * Keyboard-only navigation. Common issues include: [e4707d59]
- * The `Accessibility Insights`_ browser extension's automated checks feature, or an equivalent tool with the `Axe`_ checker. [96a80d36]
- * Touch-only navigation. Common issues include: [809e1a70]
- * VoiceOver on iOS, or `TalkBack`_ on Android [82bdeb4f]
- * WCAG 2.2 `AAA-level guidelines`_ – stricter criteria that go beyond the AA level. * The upcoming `WCAG 3.0`_ guidelines – a new, evolving standard that aims to unify and improve upon previous versions of WCAG. * `Authoring Tool Accessibility Guidelines`_ (ATAG) 2.0 – guidelines for software and services that are used to produce web content. [ca73297c]
- * `JAWS`_ on Windows * `Dragon`_ on Windows [4f992a01]
- * `NVDA`_ - recommended with Firefox ESR * `Narrator`_ - recommended with Microsoft Edge * Windows Magnifier * Windows Speech Recognition * `Contrast themes`_ [659b134d]
- * `Orca`_ - recommended with Firefox ESR [7063366f]
- * `VoiceOver`_ - recommended with Safari * macOS Zoom * macOS Voice Control [f0ff706d]
- * ``#accessibility`` on the `Django Discord server`_. * The `Accessibility Django forum topic`_. * `Accessibility issues on the ticket tracker`_. * Our `django accessibility improvements`_ project board. * The `Accessibility team`_. [0c220ab7]
- .. _Django Discord server: https://chat.djangoproject.com .. _Accessibility Django forum topic: https://forum.djangoproject.com/c/internals/accessibility/26 .. _Accessibility issues on the ticket tracker: https://code.djangoproject.com/query?status=!closed&keywords=~accessibility .. _django accessibility improvements: https://github.com/orgs/django/projects/7 .. _Accessibility team: https://www.djangoproject.com/foundation/teams/#accessibility-team [ac17e632]
- .. _accessibility-known-issues-how-to-help: [f8f2aad4]

## Beyond the budget

28 more facts did not fit in the budget: [13485e13] [1c071fae] [c66fbbde] [e7b68847] [fc4770a9] [45d19921] [67d34a57] [e13864f4] [bbfe33ba] [1e2aa3c1] [656d761d] [46500556] [0689c557] [ada9572c] [5f4cdc35] [c9e8990e] [2c28b52d] [dbdd9cd0] [36aad28d] [350ca274] [cf3d083d] [83fa2907] [7a7f8ddc] [a2b9c20d] [b5a68958] [e5df6653] [5b4eedf6] [bc736f2e]
