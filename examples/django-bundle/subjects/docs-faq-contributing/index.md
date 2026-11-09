# docs/faq/contributing

- Subject: docs/faq/contributing (id `288ae778-247a-4e9f-8e60-2735f855b4eb`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1685 tokens
- Facts shown: 26 of 26
- Conflicts: 0
- Gaps: 0

## Highlights

- * Are there clear instructions on how to reproduce the bug? If this touches a dependency (such as Pillow), a contrib module, or a specific database, are those instructions clear enough even for someone not familiar with it? [35150a66]
- * Does the change include a unit test? If not, is there a very clear explanation why not? A test expresses succinctly what the problem is, and shows that the branch actually fixes it. [b24c8e2b]
- * If there are several branches linked to the ticket, is it clear what each one does, which ones can be ignored and which matter? [72c6ef8d]
- .. _`Django Discord server`: https://chat.djangoproject.com [bf02bf4bd63231f7]
- .. _new-contributors-faq: [b9950a00]
- ====================== FAQ: Contributing code ====================== [7c0f84e1]
- A polite, well-timed message in the forum/branch is one way to get attention. To determine the right time, you need to keep an eye on the schedule. If you post your message right before a release deadline, you're not likely to get the sort of attention you require. [51938a8e]
- Another reason that a bug might be ignored for a while is if the bug is a symptom of a larger problem. While we can spend time writing, testing and applying lots of little changes, sometimes the right solution is to rebuild. If a rebuild or refactor of a particular component has been proposed or is underway, you may find that bugs affecting that component will not get as much attention. Again, this is a matter of prioritizing scarce resources. By concentrating on the rebuild, we can close all the little bugs at once, and hopefully prevent other little bugs from appearing in the future. [5c758925]
- Another way to get traction is to pull several related tickets together. When someone sits down to review a bug in an area they haven't touched for a while, it can take a few minutes to remember all the fine details of how that area of code works. If you collect several minor bug fixes together into a similarly themed group, you make an attractive target, as the cost of coming up to speed on an area of code can be spread over multiple tickets. [b0fbf2a3]
- But I've reminded you several times and you keep ignoring my contribution! ========================================================================== [c6a2c172]
- Don't worry: We're not ignoring you! [646c050d]
- Gentle reminders in the ``#contributing-getting-started`` channel in the `Django Discord server`_ can work. [12149554]
- How can I get started contributing code to Django? ================================================== [f145af93]
- I submitted a bug fix several weeks ago. Why are you ignoring my contribution? ============================================================================== [6804b575]
- I'm sure my ticket is absolutely 100% perfect, can I mark it as "Ready For Checkin" myself? =========================================================================================== [00c102ab]
- Sorry, no. It's always better to get another set of eyes on a ticket. If you're having trouble getting that second set of eyes, see questions above. [0d2ceba6]

## All facts

- [c0862cec] If your contribution is not suitable for inclusion in Django, we won't ignore it -- we'll close the ticket. So if your ticket is still open, it doesn't mean we're ignoring you; it just means we haven't had time to look at it yet.
- [48d4a0df] It's important to understand there is a difference between "a ticket is being ignored" and "a ticket has not been attended to yet." Django's ticket system contains hundreds of open tickets, of various degrees of impact on end-user functionality, and Django's developers have to review and prioritize.
- [1366fecc] On top of that: the people who work on Django are all volunteers. As a result, the amount of time that we have to work on the framework is limited and will vary from week to week depending on our spare time. If we're busy, we may not be able to spend as much time on Django as we might want.
- [7c7e3ea9] One of the criteria that is used to prioritize bug fixes is the number of people that will likely be affected by a given bug. Bugs that have the potential to affect many people will generally get priority over those that are edge cases.
- [7f63d87d] Please refrain from emailing anyone personally or repeatedly raising the same issue over and over again. This sort of behavior will not gain you any additional attention -- certainly not the attention that you need in order to get your issue addressed.
- [d87155bd] Seriously - we're not ignoring you. If your contribution is not suitable for inclusion in Django, we will close the ticket. For all the other tickets, we need to prioritize our efforts, which means that some tickets will be addressed before others.
- [21e46303] Thanks for asking! We've written an entire document devoted to this question. It's titled :doc:`Contributing to Django </internals/contributing/index>`.
- [f38add51] The best way to make sure tickets do not get hung up on the way to checkin is to make it dead easy, even for someone who may not be intimately familiar with that area of the code, to understand the problem and verify the fix:
- [73728d50] Whatever the reason, please keep in mind that while you may hit a particular bug regularly, it doesn't necessarily follow that every single Django user will hit the same bug. Different users use Django in different ways, stressing different parts of the code under different conditions. When we evaluate the relative priorities, we are generally trying to consider the needs of the entire community, instead of prioritizing the impact on one particular user. This doesn't mean that we think your problem is unimportant -- just that in the limited time we have available, we will always err on the side of making 10 people happy rather than making a single person happy.
- [0c1b6380] When and how might I remind the team of a change I care about? ==============================================================
