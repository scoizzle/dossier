# docs/internals/organization

- Subject: docs/internals/organization (id `c06eb855-5969-4b73-b963-5b3de99c8ad0`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 3483 tokens
- Facts shown: 59 of 65
- Conflicts: 0
- Gaps: 0

## Highlights

- - Code contributions to Django projects or major third-party packages in the Django ecosystem - Reviewing pull requests and/or triaging Django project tickets - Documentation, tutorials or blog posts - Discussions about Django on the Django Forum - Running Django-related events or user groups [c356bda9]
- - another Merger, - a steering council member, - a member of the `triage & review team`_, or - a member of the `security team`_. [59872912]
- #. The steering council directs one of its members to notify the Secretary of the Django Software Foundation, in writing, of the triggering of the election, and the condition which triggered it. The Secretary post to the appropriate venue -- the `Django Forum`_ to announce the election and its timeline. #. As soon as the election is announced, the `DSF Board`_ begin a period of voter registration. All `individual members of the DSF`_ are automatically registered and need not explicitly register. All other persons who believe themselves eligible to vote, but who have not yet registered to vote, may make an application to the DSF Board for voting privileges. The voter registration form and roll of voters is maintained by the DSF Board. The DSF Board may challenge and reject the registration of voters it believes are registering in bad faith or who it believes have falsified their qualifications or are otherwise unqualified. #. Registration of voters close one week after the announcement of the election. At that point, registration of candidates begin. Any qualified person may register as a candidate. The candidate registration form and roster of candidates are maintained by the DSF Board, and candidates must provide evidence of their qualifications as part of registration. The DSF Board may challenge and reject the registration of candidates it believes do not meet the qualifications of members of the Steering Council, or who it believes are registering in bad faith. #. Registration of candidates close one week after it has opened. One week after registration of candidates closes, the Secretary of the DSF publishes the roster of candidates to the `Django Forum`_, and the election begins. The DSF Board provides a voting form accessible to registered voters, and is the custodian of the votes. #. Voting is by secret ballot containing the roster of candidates, and any relevant materials regarding the candidates, in a randomized order. Each voter may vote for up to five candidates on the ballot. #. The election conclude one week after it begins. The DSF Board then tally the votes and produce a summary, including the total number of votes cast and the number received by each candidate. This summary is ratified by a majority vote of the DSF Board, then posted by the Secretary of the DSF to the `Django Forum`_. The five candidates with the highest vote totals immediately become the new steering council. [278ca44e]
- - A history of engagement with the direction and future of Django. This does not need to be recent, but candidates who have not engaged in the past three years must still demonstrate an understanding of Django's changes and direction within those three years. [1e1261e1]
- - A history of substantive contributions to Django or the Django ecosystem. This history must begin at least 18 months prior to the individual's candidacy for the Steering Council, and include substantive contributions in at least two of these bullet points: [4441019c]

## All facts

- [2bf70598] - A person must not simultaneously serve as a member of the steering council. If a Merger is elected to the steering council, they shall cease to be a Merger immediately upon taking up membership in the steering council. - A person may serve in the roles of Releaser and Merger simultaneously.
- [384e2df7dbad7f16] - Any member in good standing of an appropriate discussion venue, or the Django Software Foundation board acting with the input of the DSF's Fellowship committee, may suggest a person for consideration. - The steering council considers the suggestions put forth, and then any member of the steering council formally nominates a candidate for the role. - The steering council votes on nominees.
- [f65a27d5] - Becoming disqualified due to actions taken by the Code of Conduct committee of the Django Software Foundation. - A vote of the steering council.
- [a0a43ecf] - Becoming disqualified due to actions taken by the Code of Conduct committee of the Django Software Foundation. - Determining that they did not possess the qualifications of a member of the steering council. This determination must be made jointly by the other members of the steering council, and the `DSF Board`_. A valid determination of ineligibility requires that all other members of the steering council and all members of the DSF Board vote who can vote on the issue (the affected person, if a DSF Board member, must not vote) vote "yes" on a motion that the person in question is ineligible.
- [15f02a2e] - Driving the development of the Django web framework, - Fostering the ecosystem of Django-related software, - Leading the Django community in accordance with the values described in the `Django Code of Conduct`_.
- [d59d61a8] - Initiating discussion of a minor change in the appropriate venue, and request that other Mergers refrain from merging it while discussion proceeds. - Requesting a vote of the steering council regarding any minor change if, in the Merger's opinion, discussion has failed to reach a consensus. - Requesting a vote of the steering council when a `major change`_ (significant enough to require the use of the `DEP process`_) reaches one of its implementation milestones and is intended to merge.
- [962f3178] - Making a binding decision regarding any question of a technical change to Django. - Vetoing the merging of any particular piece of code into Django or ordering the reversion of any particular merge or commit. - Announcing calls for proposals and ideas for the future technical direction of Django. - Selecting and removing mergers and releasers. - Participating in the removal of members of the steering council, when deemed appropriate. - Calling elections of the steering council outside of those which are automatically triggered, at times when the steering council deems an election is appropriate. - Participating in modifying Django's governance (see :ref:`organization-change`). - Declining to vote on a matter the steering council feels is unripe for a binding decision, or which the steering council feels is outside the scope of its powers. - Taking charge of the governance of other technical teams within the Django open-source project, and governing those teams accordingly.
- [17963b43] - Merging any pull request which constitutes a `minor change`_ (small enough not to require the use of the `DEP process`_). A Merger must not merge a change primarily authored by that Merger, unless the pull request has been approved by:
- [4cb6c3cc] - provide oversight of Django's development and release process, - assist in setting the direction of feature development and releases, - select Mergers and Releasers, and - have a tie-breaking vote when other decision-making processes fail.
- [f3e8fc06] .. _Django Code of Conduct: https://www.djangoproject.com/conduct/ .. _Django Software Foundation: https://www.djangoproject.com/foundation/
- [b47064c8] .. _`DEP process`: https://github.com/django/deps/blob/main/final/0001-dep-process.rst .. _`DEP 0010`: https://github.com/django/deps/blob/main/final/0010-new-governance.rst#changing-this-governance-process
- [e95bb0a2] .. _`Django Forum`: https://forum.djangoproject.com/ .. _`Django Git repository`: https://github.com/django/django/ .. _`DSF Board`: https://www.djangoproject.com/foundation/#board .. _`individual members of the DSF`: https://www.djangoproject.com/foundation/individual-members/ .. _mergers: https://www.djangoproject.com/foundation/teams/#mergers-team .. _releasers: https://www.djangoproject.com/foundation/teams/#releasers-team .. _`security team`: https://www.djangoproject.com/foundation/teams/#security-team .. _`the steering council`: https://www.djangoproject.com/foundation/teams/#steering-council-team .. _`triage & review team`: https://www.djangoproject.com/foundation/teams/#triage-review-team
- [732e177a] .. _`minor change`: https://github.com/django/deps/blob/main/final/0010-new-governance.rst#terminology .. _`major change`: https://github.com/django/deps/blob/main/final/0010-new-governance.rst#terminology
- [de94cd89] .. _djangoproject.com: https://www.djangoproject.com/download/
- [36ca5710] .. _mergers-team:
- [1f25e595] .. _organization-change:
- [acb5aa86] .. _releasers-team:
- [e053f01d] .. _steering-council:
- [01ef9088] ================================== Organization of the Django Project ==================================
- [8031aae7] A member of the steering council may be removed by:
- [5a88ca85] A new council is elected after each release cycle of Django. The election process works as follows:
- [8b9dc763] A person may serve in the roles of Releaser and Merger simultaneously.
- [b123ceb3] Changes to this document require the use of the `DEP process`_, with modifications described in `DEP 0010`_.
- [f0db3a02] Changing the organization =========================
- [1a9357f9] It's not a requirement that a Merger is also a Django Fellow, but the Django Software Foundation has the power to use funding of Fellow positions as a way to make the role of Merger sustainable.
- [6176ab66d1a56080] Membership ----------
- [6176ab66d1a56080-2] Membership ----------
- [6176ab66d1a56080-3] Membership ----------
- [40882d80] Mergers =======
- [9d5fea29] Mergers hold the following prerogatives:
- [19741b21] Mergers may resign their role at any time, but should endeavor to provide some advance notice in order to allow the selection of a replacement. Termination of the contract of a Django Fellow by the Django Software Foundation temporarily suspends that person's Merger role until such time as the steering council can vote on their nomination.
- [d295d091] Mergers_ are a small set of people who merge pull requests to the `Django Git repository`_.
- [414be9ec] Otherwise, a Merger may be removed by:
- [2ac271c2] Otherwise, a Releaser may be removed by:
- [14b328b945583ada] Prerogatives ------------
- [14b328b945583ada-2] Prerogatives ------------
- [14b328b945583ada-3] Prerogatives ------------
- [d35e656d] Principles ==========
- [dd3e12f0] Releasers =========
- [85ccbdb2] Releasers_ :doc:`build Django releases </internals/howto-release-django>` and upload them to the :pypi:`Python Package Index <Django>` and to the `djangoproject.com`_ website.
- [e6eb3b48] Releasers_ are a small set of people who have the authority to upload packaged releases of Django to the :pypi:`Python Package Index <Django>` and to the `djangoproject.com`_ website.
- [2e17bc4dc6a60e7d] Role ----
- [2e17bc4dc6a60e7d-2] Role ----
- [2e17bc4dc6a60e7d-3] Role ----
- [d4465c51] Steering council ================
- [a2b962dd] The Django Project is managed by a team of volunteers pursuing three goals:
- [9f9804fe] The Django Project isn't a legal entity. The `Django Software Foundation`_, a non-profit organization, handles financial and legal matters related to the Django Project. Other than that, the Django Software Foundation lets the Django Project manage the development of the Django framework, its ecosystem and its community.
- [6f855269] The following restrictions apply to the role of Merger:
- [9442e6ed5801515b] The selection process, when a vacancy occurs or when the steering council deems it necessary to select additional persons for such a role, occur as follows:
- [cc0f85a9] The steering council holds the following prerogatives:
- [52a884a5] The steering council is a group of experienced contributors who:
- [e2a184aa] Their main concern is to maintain the quality and stability of the Django Web Framework.
- [c04730be] `The steering council`_ is an elected group of five experienced contributors who demonstrate:
- [c73ef1e8] `The steering council`_ selects Mergers_ as necessary to maintain their number at a minimum of three, in order to spread the workload and avoid over-burdening or burning out any individual Merger. There is no upper limit to the number of Mergers.
