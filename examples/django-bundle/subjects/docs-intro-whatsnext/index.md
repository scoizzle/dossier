# docs/intro/whatsnext

- Subject: docs/intro/whatsnext (id `e416a208-64d6-4082-adbc-e571ad77caf6`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2915 tokens
- Facts shown: 65 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- $ cd path/to/django/docs $ make html [8c9196dd]
- $ python -m pip install Sphinx [0a0d1193]
- cd path\to\django\docs make.bat html [cf6b1125]
- $ grep -r max_length /path/to/django/docs/ [d3c0170c]
- .. code-block:: bat [fefc44cb8bc5d316]
- .. code-block:: console [faf6f5a8efbd7831-12]
- .. console:: [7714e199aac2701e-83]
- Answers to really common questions can also be found in the :doc:`FAQ </faq/index>`. [5aaef896]
- If you're on Windows you can alternatively use the included batch file: [48932daf]
- This is probably where you'll want to spend most of your time; if you work your way through these guides you should come out knowing pretty much everything there is to know about Django. [32cb12fb]
- You'll need `GNU Make`__ installed for this. [27c22cf2]
- (Yes, this is documentation about documentation. Rest assured we have no plans to write a document about how to read the document about documentation.) [d8e739a0]
- * As we add features to Django's development version, we update the documentation in the same Git commit transaction. [6ec33777]
- * Django's documentation uses a system called Sphinx__ to convert from plain text to HTML. You'll need to install Sphinx by either downloading and installing the package from the Sphinx website, or with ``pip``: [d8bd89e7]
- * Documentation fixes and improvements may be backported to the last release branch, at the discretion of the merger, however, once a version of Django is :ref:`no longer supported<supported-versions-policy>`, that version of the docs won't get any further updates. [61902aa9]
- * Finally, there's some "specialized" documentation not usually relevant to most developers. This includes the :doc:`release notes </releases/index>` and :doc:`internals documentation </internals/index>` for those who want to add code to Django itself, and a :doc:`few other things that don't fit elsewhere </misc/index>`. [b94af0e7]
- * If you are interested in deploying a project for public use, our docs have :doc:`several guides</howto/deployment/index>` for various deployment setups as well as a :doc:`deployment checklist</howto/deployment/checklist>` for some things you'll need to think about. [16dbfc6a]
- * The :doc:`introductory material </intro/index>` is designed for people new to Django -- or to web development in general. It doesn't cover anything in depth, but instead gives a high-level overview of how developing in Django "feels". [c79d9e74]
- * The :doc:`topic guides </topics/index>`, on the other hand, dive deep into individual parts of Django. There are complete guides to Django's :doc:`model system </topics/db/index>`, :doc:`template engine </topics/templates>`, :doc:`forms framework </topics/forms/index>`, and much more. [1876f85c]
- * The HTML documentation will be placed in ``docs/_build/html``. [d9365ace]
- * Then, use the included ``Makefile`` to turn the documentation into HTML: [64221f14]
- * To make content fixes, such as grammar/typo corrections. [1ff1dc8b]

## All facts

- [008c4e71] * The `main documentation web page`_ includes links to documentation for previous versions. Be sure you are using the version of the docs corresponding to the version of Django you are using!
- [bbaff07d] * The development documentation at https://docs.djangoproject.com/en/dev/ is from the main branch. These docs correspond to the latest feature release, plus whatever features have been added/changed in the framework since then.
- [6e0f6547] * The guides and how-to's don't cover every single class, function, and method available in Django -- that would be overwhelming when you're trying to learn. Instead, details about individual classes, functions, methods, and modules are kept in the :doc:`reference </ref/index>`. This is where you'll turn to find the details of a particular function or whatever you need.
- [73362000] * To add documentation for new features as new features get added, or as Django APIs or behaviors change.
- [bceb61eb] * To add information and/or examples to existing sections that need to be expanded.
- [95ce9459] * To distinguish feature changes/additions in the docs, we use the phrase: "New in Django Development version" for the version of Django that hasn't been released yet, or "New in version X.Y" for released versions.
- [1b8079a3] * To document Django features that aren't yet documented. (The list of such features is shrinking but exists nonetheless.)
- [0d4e0507] * Web development is often broad, not deep -- problems span many domains. We've written a set of :doc:`how-to guides </howto/index>` that answer common "How do I ...?" questions. Here you'll find information about :doc:`generating PDFs with Django </howto/outputting-pdf>`, :doc:`writing custom template tags </howto/custom-template-tags>`, and more.
- [7c325823] .. _Django ecosystem: https://www.djangoproject.com/community/ecosystem/
- [2fc531ed] .. _differences-between-doc-versions:
- [c0342bc8] .. _main documentation web page: https://docs.djangoproject.com/en/dev/
- [7fb57f07] .. _ticket system: https://code.djangoproject.com/ .. _Django Forum: https://forum.djangoproject.com/ .. _Django Discord server: https://chat.djangoproject.com
- [7714e199aac2701e-84] .. console::
- [a83120a5] ================= What to read next =================
- [b4699e33] As HTML, locally ----------------
- [f6c1e7ec] Differences between versions ============================
- [c7178eac] Django's documentation is kept in the same source control system as its code. It lives in the :source:`docs` directory of our Git repository. Each document online is a separate text file in the repository.
- [6146b270] Django's got a *lot* of documentation -- almost 450,000 words and counting -- so finding what you need can sometimes be tricky. A good place to start is the :ref:`genindex`. We also recommend using the builtin search feature.
- [87bb7152] Django's main documentation is broken up into "chunks" designed to fill different needs:
- [92147f5c] Finding documentation =====================
- [c70eb57a] For offline reading, or just for convenience, you can read the Django documentation in plain text.
- [7d8ddec3] How documentation is updated ============================
- [141c4e5ec809f575-3] How the documentation is organized ==================================
- [8a2a4287] If you're using an official release of Django, the zipped package (tarball) of the code includes a ``docs/`` directory, which contains all the documentation for that release.
- [f51e1ca3] If you're using the development version of Django (aka the main branch), the ``docs/`` directory contains all of the documentation. You can update your Git checkout to get the latest changes.
- [a8e260cf] In plain text -------------
- [f9b6e77c] Just as the Django code base is developed and improved on a daily basis, our documentation is consistently improving. We improve documentation for several reasons:
- [f2343d37] Note, however, that tickets should explicitly relate to the documentation, rather than asking broad tech-support questions. If you need help with your particular Django setup, try the `Django Forum`_ or the `Django Discord server`_ instead.
- [77488c78] On the web ----------
- [392afca9] One low-tech way of taking advantage of the text documentation is by using the Unix ``grep`` utility to search for a phrase in all of the documentation. For example, this will show you each mention of the phrase "max_length" in any Django document:
- [d0860406] Or you can just browse around!
- [2dd837c5] So what's next?
- [29a808dd] So you've read all the :doc:`introductory material </intro/index>` and have decided you'd like to keep using Django. We've only just scratched the surface with this intro (in fact, if you've read every single word, you've read about 5% of the overall documentation).
- [f44f5ddf] The most recent version of the Django documentation lives at https://docs.djangoproject.com/en/dev/. These HTML pages are generated automatically from the text files in source control. That means they reflect the "latest and greatest" in Django -- they include the very latest corrections and additions, and they discuss the latest Django features, which may only be available to users of the Django development version. (See :ref:`differences-between-doc-versions` below.)
- [dc7b17e5] The text documentation in the main branch of the Git repository contains the "latest and greatest" changes and additions. These changes include documentation of new features targeted for Django's next :term:`feature release <Feature release>`. For that reason, it's worth pointing out our policy to highlight recent changes and additions to Django.
- [231ed6f4] We encourage you to help improve the docs by submitting changes, corrections and suggestions in the `ticket system`_. The Django developers actively monitor the ticket system and use your feedback to improve the documentation for everybody.
- [6a7bc122] We follow this policy:
- [12d138b8] We've put a lot of effort into making Django's documentation useful, clear and as complete as possible. The rest of this document explains more about how the documentation works so that you can get the most out of it.
- [20102358] Well, we've always been big fans of learning by doing. At this point you should know enough to start a project of your own and start fooling around. As you need to learn new tricks, come back to the documentation. There's also a bigger `Django ecosystem`_ out there for you to explore that the community has created.
- [db7005dc] Where to get it ===============
- [4b34cc2f] You can get a local copy of the HTML documentation following a few steps:
- [c08f8787] You can read Django documentation in several ways. They are, in order of preference:
- [6b28b871] __ https://www.sphinx-doc.org/ __ https://www.gnu.org/software/make/
