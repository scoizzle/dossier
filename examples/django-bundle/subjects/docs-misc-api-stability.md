# docs/misc/api-stability

- Subject: docs/misc/api-stability (id `521221bb-ff0d-4cc3-81cd-3cf06d966d25`)
- Kind: subject
- Budget: 1200 tokens
- Used: 897 tokens
- Facts shown: 17 of 20
- Conflicts: 0
- Gaps: 0

## Facts

- See :ref:`official-releases` for more details on how Django's version numbering scheme works, and how features will be deprecated. [a1e03c43]
- - All the public APIs (everything in this documentation) will not be moved or renamed without providing backwards-compatible aliases. [33b36633]
- - Functions, methods, and other objects prefixed by a leading underscore (``_``). This is the standard Python way of indicating that something is private; if any method starts with a single ``_``, it's an internal API. [b031f9b3]
- - If new features are added to these APIs -- which is quite possible -- they will not break or change the meaning of existing methods. In other words, "stable" does not (necessarily) mean "complete." [71697924]
- - If, for some reason, an API declared stable must be removed or replaced, it will be declared deprecated but will remain in the API for at least two feature releases. Warnings will be issued when the deprecated method is called. [a6227988]
- - Some documentation refers to internals and mentions them as such. If the documentation says that something is internal, we reserve the right to change it. [eac83054]
- - We'll only break backwards compatibility of these APIs without a deprecation process if a bug or security hole makes it completely unavoidable. [e93ee018]
- ============= API stability ============= [bf90cb6c]
- APIs marked as internal ----------------------- [f69d41c6]
- At the same time as making API stability a very high priority, Django is also committed to continual improvement, along with aiming for "one way to do it" (eventually) in the APIs we provide. This means that when we discover clearly superior ways to do things, we will deprecate and eventually remove the old ways. Our aim is to provide a modern, dependable web framework of the highest quality that encourages best practices in all projects that use it. By using incremental improvements, we try to avoid both stagnation and large breaking upgrades. [5a4495a3]
- Certain APIs are explicitly marked as "internal" in a couple of ways: [34d57c08]
- Django is committed to API stability and forwards-compatibility. In a nutshell, this means that code you develop against a version of Django will continue to work with future releases. You may need to make minor changes when upgrading the version of Django your project uses: see the "Backwards incompatible changes" section of the :doc:`release note </releases/index>` for the version or versions to which you are upgrading. [2edf46d9]
- Exceptions ========== [458050e52503f721]
- If we become aware of a security problem -- hopefully by someone following our :ref:`security reporting policy <reporting-security-issues>` -- we'll do everything necessary to fix it. This might mean breaking backwards compatibility; security trumps the compatibility guarantee. [e45ceebb]
- In general, everything covered in the documentation -- with the exception of anything in the :doc:`internals area </internals/index>` is considered stable. [a761a537]
- In this context, stable means: [58d16324]
- Security fixes -------------- [c0b242e8]

## Beyond the budget

3 more facts did not fit in the budget: [79739585] [93ffafe7] [d7835228]
