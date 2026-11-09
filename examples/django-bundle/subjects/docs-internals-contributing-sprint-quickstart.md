# docs/internals/contributing/sprint-quickstart

- Subject: docs/internals/contributing/sprint-quickstart (id `72d8c169-f3d6-427c-86b2-7e77666718ab`)
- Kind: subject
- Budget: 1200 tokens
- Used: 889 tokens
- Facts shown: 27 of 59
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

32 more facts did not fit in the budget: [8c64cebd] [80a376eb] [ff1cc30e] [76d3e26a] [7714e199aac2701e-13] [7714e199aac2701e-14] [05533c1a] [696f4fe4] [04fb87b4] [ffb5c140] [2f8f72e3] [74b2f755] [97c81d7f] [38f66f6e] [4307e1eb] [ee90dbef] [9edf3911] [f23595b8] [c4e2d7fa] [fad94972] [8826c6c1] [b805cb1d] [e60017d7] [d7c6c492] [1ba995e0] [4d0bc10f] [9444169a] [06b49a94] [a67c8152] [719df574] [3fb81b93] [501efd79]
