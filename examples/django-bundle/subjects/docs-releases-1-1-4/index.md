# docs/releases/1.1.4

- Subject: docs/releases/1.1.4 (id `da52e604-9b90-4ffd-a6af-85606ae079e4`)
- Kind: subject
- Budget: 1200 tokens
- Used: 898 tokens
- Facts shown: 18 of 18
- Conflicts: 0
- Gaps: 0

## Facts

- * Browsers have strict same-origin policies regarding XMLHttpRequest. [c4dfd23e18422715]
- * In the context of a browser, the only way that a custom header of this nature can be added is with XMLHttpRequest. [ef911ec26a0d0aaf]
- * Many AJAX toolkits add an X-Requested-With header when using XMLHttpRequest. [c1711033993a0635]
- ========================== Django 1.1.4 release notes ========================== [c4d2bb5e]
- Additionally, Django will now accept the CSRF token in the custom HTTP header X-CSRFTOKEN, as well as in the form submission itself, for ease of use with popular JavaScript toolkits which allow insertion of custom headers into all AJAX requests. [a6f4647cfbbc4d9b]
- Backwards incompatible changes ============================== [f2cb124aa97ba055-2]
- CSRF exception for AJAX requests -------------------------------- [f9f33cacdb1a4b91]
- Django includes a CSRF-protection mechanism, which makes use of a token inserted into outgoing forms. Middleware then checks for the token's presence on form submission, and validates it. [fb2a915651ca04f5]
- For full details on the new features, backwards incompatibilities, and deprecated features in the 1.1 branch, see the :doc:`/releases/1.1`. [c5816bb0ad26b431-3]
- Michael Koziarski of the Rails team brought this to our attention, and we were able to produce a proof-of-concept demonstrating the same vulnerability in Django's CSRF handling. [fff67cb57ab70001]
- Please see the :ref:`CSRF docs for example jQuery code <csrf-ajax>` that demonstrates this technique, ensuring that you are looking at the documentation for your version of Django, as the exact code necessary is different for some older versions of Django. [bdf74a1981fb2981]
- Prior to Django 1.2.5, our CSRF protection made an exception for AJAX requests, on the following basis: [cd2a9f85142eda54]
- Recently, engineers at Google made members of the Ruby on Rails development team aware of a combination of browser plugins and redirects which can allow an attacker to provide custom HTTP headers on a request to any website. This can allow a forged request to appear to be an AJAX request, thereby defeating CSRF protection which trusts the same-origin nature of AJAX requests. [b9f8ea76652b8240]
- Therefore, for ease of use, we did not apply CSRF checks to requests that appeared to be AJAX on the basis of the X-Requested-With header. The Ruby on Rails web framework had a similar exemption. [4089a6c9f535a706]
- This is the fourth "bugfix" release in the Django 1.1 series, improving the stability and performance of the Django 1.1 codebase. [4d712f6e]
- To remedy this, Django will now apply full CSRF validation to all requests, regardless of apparent AJAX origin. This is technically backwards-incompatible, but the security risks have been judged to outweigh the compatibility concerns in this case. [8370f126dc5e7c8e]
- Welcome to Django 1.1.4! [b341dea7]
- With one exception, Django 1.1.4 maintains backwards compatibility with Django 1.1.3. It also contains a number of fixes and other improvements. Django 1.1.4 is a recommended upgrade for any development or deployment currently using or targeting Django 1.1. [eb96fb34]
