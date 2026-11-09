# docs/internals/contributing/sprint-quickstart

- Subject: docs/internals/contributing/sprint-quickstart (id `ded75be5-9d31-44c9-8e61-9425a2dbebcf`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2449 tokens
- Facts shown: 59 facts
- Conflicts: 0
- Gaps: 0

## Highlights

- $ # This needs to be >= 3.12 $ python -V $ python -m venv ~/.virtualenvs/djangodev $ source ~/.virtualenvs/djangodev/bin/activate [e1d1a978]
- $ ./tests/runtests.py [d4a85a14]
- $ cd docs && make html && cd .. [6e9deeab]
- $ git clone https://github.com/YourGitHubName/django.git $ cd django $ git remote add upstream https://github.com/django/django.git [909333ad]
- $ python -m pip install -U pip $ python -m pip install -e . -r tests/requirements/py3.txt -r docs/requirements.txt [26c53035]
- $ python -m pip install pre-commit $ pre-commit install [2894405ebdfc4412]
- $ git fetch upstream $ git checkout -b ticket_TicketNumber upstream/main [d68d6992]
- $ git fetch upstream pull/8000/head:ticket_123 $ git checkout ticket_123 $ git push origin ticket_123 [ee8ed592]
- $ git fetch upstream pull/PRNumber/head:ticket_TicketNumber $ git checkout ticket_TicketNumber $ git push origin ticket_TicketNumber [30f60721]
- .. code-block:: shell [8aa7203c166b13be-23]
- .. console:: [7714e199aac2701e-7]
- .. console:: [7714e199aac2701e-8]
- .. console:: [7714e199aac2701e-9]
- .. console:: [7714e199aac2701e-10]
- .. console:: [7714e199aac2701e-11]
- If you are not using a Unix-like system, see the :ref:`platform-specific instructions <intro-contributing-install-local-copy>`. [ee24d257]
- If you have a small number of failures, it may be worth investigating whether they are known issues, or using the :ref:`django-docker-box <running-tests-docker-box>` project to run the tests. Since this is a sprint, it may be more valuable for you to work on the issue at hand rather than investigating a weird machine configuration problem. Make a note of the failing tests before you start, so you can tell whether a later failure was caused by your changes. [496c12fc]
- See :ref:`coding-style-pre-commit` for further details. [a698af39]
- See :ref:`running-unit-tests` for more information. While tests will all pass in CI, they may not on every person's local environment. For example, the test suite is only guaranteed to pass on the latest point release of each supported Python version. It's possible you may encounter errors using an earlier point release. [9652f1e3]
- #. Build the documentation: [9e7896c9]
- #. Confirm you're using a :ref:`compatible version of Python <faq-python-version-support>`, then set up a virtual environment: [445e7262]
- #. Fork the repository on GitHub, clone your fork to your machine, and configure a remote reference to Django's upstream repository: [a8aca22c]
- #. Install pre-commit hooks so that formatting and linting run automatically before each commit: [8c64c4f3]
- #. Install the dependencies to run the tests and build the documentation: [1fdd7be6]
- #. Run the tests: [40bf5bad]
- * Look at the `easy pickings`_. * Use the `vulture method`_. [36b8a205]
- .. console:: [7714e199aac2701e-12]

## All facts

- [8c64cebd] * Git (see :doc:`/internals/contributing/writing-code/working-with-git`) * Managing multiple versions of Python * Python dependency management, including virtual environments * The concept of running tests and building documentation
- [80a376eb] * Triage stage = Accepted * Patch needs improvement = Yes * Created = between ``5 years ago`` and ``today`` * Modified = between ``5 years ago`` and ``6 months ago``
- [ff1cc30e] .. _accepted tickets created in the last five years: https://code.djangoproject.com/query?stage=Accepted&status=assigned&status=new&time=5+years+ago..today&order=id&desc=1&col=id&col=summary&col=owner&col=type&col=component&col=time&col=changetime .. _tickets for the documentation component: https://code.djangoproject.com/query?component=Documentation&stage=Accepted&status=assigned&status=new&time=5+years+ago..today&order=id&desc=1&col=id&col=summary&col=owner&col=type&col=component&col=time&col=changetime
- [76d3e26a] .. _easy pickings: https://code.djangoproject.com/query?easy=1&stage=Accepted&status=assigned&status=new&time=5+years+ago..today&order=id&desc=1&col=id&col=summary&col=owner&col=type&col=component&col=time&col=changetime .. _vulture method: https://youtube.com/shorts/D6QHet5U82U?si=j5M6sy0ufpeGy_iZ .. _possibly vulture-able tickets here: https://code.djangoproject.com/query?stage=Accepted&changetime=5+years+ago..6+months+ago&needs_better_patch=1&status=assigned&status=new&time=5+years+ago..today&order=id&desc=1&col=id&col=summary&col=time&col=changetime&col=needs_better_patch&col=owner&col=type&col=component
- [7714e199aac2701e-13] .. console::
- [7714e199aac2701e-14] .. console::
- [05533c1a] ======================= Sprint quickstart guide =======================
- [696f4fe4] Assessing tickets -----------------
- [04fb87b4] Claiming a ticket -----------------
- [ffb5c140] Consider using the component filter option in Trac to limit your search to areas you have used before. If you've used forms in a few Django apps, consider filtering down to the forms component. Similarly, if you've never worked with geospatial projects, it's probably wise to avoid ``django.contrib.gis``. For example, here are the `tickets for the documentation component`_.
- [2f8f72e3] Continuing someone else's work ------------------------------
- [74b2f755] Creating a branch for the ticket ================================
- [97c81d7f] Finding a ticket to work on ===========================
- [38f66f6e] Finding a workable ticket is a challenging task. It's important to read this section before attempting to do so.
- [4307e1eb] For example, to continue PR 8000 for ticket 123, run:
- [ee90dbef] How you create your branch depends on whether the ticket already has work attached to it.
- [9edf3911] If any of these are unfamiliar, see :doc:`/intro/contributing` for a longer, step-by-step tutorial.
- [f23595b8] If you're continuing the work from someone else's pull request on GitHub, things can be tricky. You need to pull their branch, but then push it to your GitHub repository fork.
- [c4e2d7fa] Methods to find tickets -----------------------
- [fad94972] Run the following, replacing ``PRNumber`` and ``TicketNumber`` with the actual pull request and Trac ticket numbers:
- [8826c6c1] Set up ======
- [b805cb1d] Starting fresh --------------
- [e60017d7] The vulture method is the process of looking for accepted tickets that haven't been touched in six months or longer. The ideal ticket has a PR linked to it that has a code review with explicit requests for changes and the author has not responded in at least six months on the PR and on the ticket. Before taking one over, leave a comment on both the ticket and the PR letting the author know that you are continuing their work.
- [d7c6c492] There are two recommended ways to find a ticket:
- [1ba995e0] This document explains how to prepare to contribute to Django. It is intended for use during sprints, or by people who are already familiar with contributing to Python open source projects.
- [4d0bc10f] This guide assumes you're familiar with:
- [9444169a] When looking over tickets, it's a good idea to keep your search to `accepted tickets created in the last five years`_. Older tickets are old for a reason: they are usually still open because they are hard, contentious, or both. You're welcome to try one, but expect it to require a high degree of perseverance.
- [06b49a94] When preparing your commit, please review our :ref:`committing guidelines <committing-guidelines>`, specifically how to credit co-authors.
- [a67c8152] When you find a ticket, make yourself the owner by clicking the "Modify Ticket" button near the bottom of the page, selecting the "assign to" radio button in the "Action" section, and clicking "Submit changes". Your username will be filled in the text box by default. See :ref:`claiming-tickets` for the full documentation.
- [719df574] When your work is ready, push the branch to your fork and open a pull request. See :doc:`/internals/contributing/writing-code/submitting-patches` for the full process.
- [3fb81b93] With the ticket claimed, create a branch for your work, replacing ``TicketNumber`` with the actual Trac ticket number:
- [501efd79] You can view the list of `possibly vulture-able tickets here`_. The filters that are applied are:
