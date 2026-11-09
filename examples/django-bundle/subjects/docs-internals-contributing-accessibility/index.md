# docs/internals/contributing/accessibility

- Subject: docs/internals/contributing/accessibility (id `417607a6-7096-4b7b-9083-d30324dfba3a`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2201 tokens
- Facts shown: 46 facts
- Conflicts: 0
- Gaps: 0

## Highlights

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

## All facts

- [13485e13] .. _Accessibility Insights: https://accessibilityinsights.io/ .. _Axe: https://github.com/dequelabs/axe-core .. _NVDA: https://www.nvaccess.org/ .. _Narrator: https://support.microsoft.com/en-us/windows/complete-guide-to-narrator-e4397a0d-ef4f-b386-d8ae-c172f109bdb1 .. _VoiceOver: https://support.apple.com/en-gb/guide/voiceover-guide/welcome/web .. _TalkBack: https://support.google.com/accessibility/android/answer/6283677 .. _Contrast themes: https://support.microsoft.com/en-us/windows/change-color-contrast-in-windows-fedc744c-90ac-69df-aed5-c8a90125e696 .. _JAWS: https://www.freedomscientific.com/products/software/jaws/ .. _Dragon: https://www.nuance.com/en-gb/dragon.html .. _Orca: https://help.gnome.org/users/orca/stable/
- [1c071fae] .. _Web Content Accessibility Guidelines: https://www.w3.org/TR/WCAG22/ .. _AA-level guidelines: https://www.w3.org/WAI/WCAG22/quickref/?currentsidebar=%23col_overview&levels=aaa .. _AAA-level guidelines: https://www.w3.org/WAI/WCAG22/quickref/?currentsidebar=%23col_overview&levels=a%2Caa .. _WCAG 3.0: https://www.w3.org/TR/wcag-3.0/ .. _Authoring Tool Accessibility Guidelines: https://www.w3.org/TR/ATAG20/ .. _The A11Y Project: https://www.a11yproject.com/
- [c66fbbde] .. _accessibility-standards:
- [e7b68847] .. _accessibility-support-targets:
- [fc4770a9] .. _accessibility-testing-baseline:
- [45d19921] .. _assistive-technologies:
- [67d34a57] .. _for everyone: https://en.wikipedia.org/wiki/Curb_cut_effect
- [e13864f4] ============= Accessibility =============
- [bbfe33ba] Accessibility standards =======================
- [1e2aa3c1] Always test user interface changes with:
- [656d761d] Beyond standards, we want to make sure Django actually works for people using a wide range of input devices and assistive technologies. This has benefits to make sure Django works better `for everyone`_. The best way to do this effectively is to take accessibility considerations into account as part of designing features. If in doubt, consult with users who rely on assistive technologies or with accessibility experts. You can reach out to the `Accessibility team`_ via the `Accessibility Django forum topic`_ or via the ``#accessibility`` channel on the `Django Discord server`_.
- [46500556] Design the UI with accessibility in mind, and the testing will only be needed as a final check. For more complex interfaces, confer with other contributors to decide on testing targets. Reach out to the `Accessibility team`_ for support and to coordinate testing.
- [0689c557] For Linux:
- [ada9572c] For Windows:
- [5f4cdc35] For macOS:
- [c9e8990e] For mobile or tablet:
- [2c28b52d] Known issues and how to help ============================
- [dbdd9cd0] Recommended assistive technologies ----------------------------------
- [36aad28d] Support targets and testing ===========================
- [350ca274] Testing baseline ----------------
- [cf3d083d] The Django project is committed to ensuring that websites built with Django are usable by everyone, including people with disabilities. Django's built-in components, such as the admin interface and default form rendering, should adhere to established accessibility standards and meet our own targets for supporting specific input devices and assistive technologies.
- [83fa2907] The following are popular licensed options. If you are a user of these, or can work with a user holding a license, also test against:
- [7a7f8ddc] There are parts of Django that do not meet our accessibility targets. We actively work on fixing issues, both as part of ongoing maintenance and bigger overhauls. To learn about known issues, and get involved, see:
- [a2b9c20d] To learn more about accessibility without diving straight into standards, we recommend `The A11Y Project`_, a community-driven effort to make digital accessibility easier.
- [b5a68958] We also aim to follow other best practices, such as:
- [e5df6653] We work to conform with the `Web Content Accessibility Guidelines`_ (WCAG), version 2.2, at the AA level. WCAG is the most established standard for web accessibility. `AA-level guidelines`_ are the most common legal compliance target worldwide.
- [5b4eedf6] Where the UI changes could affect assistive technologies, here are popular free options we recommend testing with.
- [bc736f2e] Where the UI changes could affect those modalities, also test with:
