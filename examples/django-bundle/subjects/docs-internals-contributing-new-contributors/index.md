# docs/internals/contributing/new-contributors

- Subject: docs/internals/contributing/new-contributors (id `7a5e5e64-658f-473f-829c-3e7c33beed1b`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2202 tokens
- Facts shown: 47 of 47
- Conflicts: 0
- Gaps: 0

## Highlights

- If you are new to contributing to Django, the :doc:`/intro/contributing` tutorial will give you an introduction to the tools and the workflow. [a8971bdb]
- .. _reports page: https://code.djangoproject.com/wiki/Reports [238f4a20]
- The `reports page`_ contains links to many useful Trac queries, including several that are useful for triaging tickets and reviewing patches as suggested above. [2ec1878e]
- .. _CLA: https://www.djangoproject.com/foundation/cla/ .. _Contributor License Agreement FAQ: https://www.djangoproject.com/foundation/cla/faq/ .. _unreviewed ticket: https://code.djangoproject.com/query?status=!closed&stage=Unreviewed [4dc88449]
- .. _`Django Discord server`: https://chat.djangoproject.com [bf02bf4bd63231f7-2]
- .. _easy pickings: https://code.djangoproject.com/query?status=!closed&easy=1 [389c75931f0baca6]
- .. admonition:: Get up and running! [01767f0a]
- .. note:: [942ae6c11625c81c-13]
- =========================== Advice for new contributors =========================== [6aec010d]
- Analyze tickets' context and history ------------------------------------ [08cdf29e]
- As a newcomer on a large project, it's easy to experience frustration. Here's some advice to make your work on Django more useful and rewarding. [8628f749]
- Be bold! Leave feedback! ------------------------ [488ec752]
- Be cautious when marking things "Ready For Check-in" ---------------------------------------------------- [a882c685]
- Be patient ---------- [f427208f]
- Be rigorous ----------- [43d91099]
- Confirm support before engaging in a big task --------------------------------------------- [4db6418c]
- Django's documentation is great but it can always be improved. Did you find a typo? Do you think that something should be clarified? Go ahead and suggest a documentation patch! See also the guide on :doc:`/internals/contributing/writing-documentation`. [ed8d702b]
- Finally, a well-timed reminder can help. See :ref:`contributing code FAQ <new-contributors-faq>` for ideas here. [49c8478a]
- First steps =========== [fbe83770e3b6538d-2]
- Focus on one or two tickets, see them through from start to finish, and repeat. The shotgun approach of taking on lots of tickets and letting some fall by the wayside ends up doing more harm than good. [f115c6ff]
- Guidelines ========== [748371b9]
- If an `unreviewed ticket`_ reports a bug, try and reproduce it. If you can reproduce it and it seems valid, make a note that you confirmed the bug and accept the ticket. Make sure the ticket is filed under the correct component area. Consider writing a patch that adds a test for the bug's behavior, even if you don't fix the bug itself. See more at :ref:`how-can-i-help-with-triaging`. [ad9753e9]
- If you are looking for a reference on the details of making code contributions, see the :doc:`/internals/contributing/writing-code/index` documentation. [d2178d675b9bdfd7]
- Start small ----------- [02a04ccd]

## All facts

- [573ea13b] If you're really not certain if a ticket is ready, don't mark it as such. Leave a comment instead, letting others know your thoughts. If you're mostly certain, but not completely certain, you might also try asking on the ``#contributing-getting-started`` channel in the `Django Discord server`_ to see if someone else can confirm your suspicions.
- [0a3468aa] It's easier to get feedback on a little issue than on a big one. See the `easy pickings`_.
- [efa457b4] It's not always easy for your ticket or your patch to be reviewed quickly. This isn't personal. There are a lot of tickets and pull requests to get through.
- [ab2ce4f7] Keep old patches up-to-date ---------------------------
- [1c8eb8e9] Keeping your patch up to date is important. Review the ticket on Trac to ensure that the *Needs tests*, *Needs documentation*, and *Patch needs improvement* flags are unchecked once you've addressed all review comments.
- [99283b51] New contributor and not sure what to do? Want to help but just don't know how to get started? This is the section for you.
- [bd144d7b] Oftentimes the codebase will change between a patch being submitted and the time it gets reviewed. Make sure it still applies cleanly and functions as expected. Updating a patch is both useful and important! See more on :ref:`patch-review-checklist`.
- [da5bb71a] Pick a subject area -------------------
- [936a4e66] Remember that Django has an eight-month release cycle, so there's plenty of time for your patch to be reviewed.
- [9632f0ec] Review patches of accepted tickets ----------------------------------
- [36e5c077] Sign the Contributor License Agreement --------------------------------------
- [b0848f9a] Sometimes it can be scary to put your opinion out to the world and say "this ticket is correct" or "this patch needs work", but it's the only way the project moves forward. The contributions of the broad Django community ultimately have a much greater impact than that of any one person. We can't do it without **you**!
- [24d417b9] Start with these steps to discover Django's development process.
- [52ca0971] The code that you write belongs to you or your employer. If your contribution is more than one or two lines of code, you have the option to sign the `CLA`_. See the `Contributor License Agreement FAQ`_ for a more thorough explanation.
- [470a2737] This means getting someone else to confirm that a bug is real before you fix the issue, and ensuring that there's consensus on a proposed feature before you go implementing it.
- [b52e1257] This page contains more general advice on ways you can contribute to Django, and how to approach that.
- [8f56839b] This should be something that you care about, that you are familiar with or that you want to learn about. You don't already have to be an expert on the area you want to work on; you become an expert through your ongoing contributions to the code.
- [cdd30266] This will help you build familiarity with the codebase and processes. Mark the appropriate flags if a patch needs docs or tests. Look through the changes a patch makes, and keep an eye out for syntax that is incompatible with older but still supported versions of Python. :doc:`Run the tests </internals/contributing/writing-code/unit-tests>` and make sure they pass. Where possible and relevant, try them out on a database other than SQLite. Leave comments and feedback!
- [62d0e6e3] Trac isn't an absolute; the context is just as important as the words. When reading Trac, you need to take into account who says things, and when they were said. Support for an idea two years ago doesn't necessarily mean that the idea will still have support. You also need to pay attention to who *hasn't* spoken -- for example, if an experienced contributor hasn't been recently involved in a discussion, then a ticket may not have the support required to get into Django.
- [e3a3940d] Triage tickets --------------
- [8e095603] Wait for feedback, and respond to feedback that you receive -----------------------------------------------------------
- [817574b3] When we say ":pep:`8`, and must have docs and tests", we mean it. If a patch doesn't have docs and tests, there had better be a good reason. Arguments like "I couldn't find any existing tests of this feature" don't carry much weight. While it may be true, that means you have the extra-important job of writing the very first tests for that feature, not that you get a pass from writing tests altogether.
- [f5d0f588] Write some documentation ------------------------
