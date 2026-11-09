# docs/releases/1.3.5

- Subject: docs/releases/1.3.5 (id `78144692-1f9b-4831-9837-cbd3308a68d0`)
- Kind: subject
- Budget: 1200 tokens
- Used: 821 tokens
- Facts shown: 14 of 14
- Conflicts: 0
- Gaps: 0

## Facts

- * Hostnames must consist of characters ``[A-Za-z0-9]`` plus hyphen ('-') or dot ('.'). * IP addresses -- both IPv4 and IPv6 -- are permitted. * Port, if specified, is numeric. [20f87b64f4f87ff0]
- *December 10, 2012* [34880ef1208fd73e]
- 1. A new utility function, ``django.utils.http.is_safe_url``, is added; this function takes a URL and a hostname, and checks that the URL is either relative, or if absolute matches the supplied hostname. This function is intended for use whenever user-supplied redirect targets are accepted, to ensure that such redirects cannot lead to arbitrary third-party sites. [cff4451789772023]
- 2. All of Django's own built-in views -- primarily in the authentication system -- which allow user-supplied redirect targets now use ``is_safe_url`` to validate the supplied URL. [99aa3fdc461b4d75]
- ========================== Django 1.3.5 release notes ========================== [02d043ed]
- Also following up on a previous issue: in July of this year, we made changes to Django's HTTP redirect classes, performing additional validation of the scheme of the URL to redirect to (since, both within Django's own supplied applications and many third-party applications, accepting a user-supplied redirect target is a common pattern). [585908bbe0c54523]
- Any deviation from this will now be rejected, raising the exception :exc:`django.core.exceptions.SuspiciousOperation`. [8120332068d84d09]
- Django 1.3.5 addresses two security issues present in previous Django releases in the 1.3 series. [332ccd9b]
- Host header poisoning ===================== [327c5cfb06ab025c-2]
- In response to further input received and reports of continuing issues following the previous release, we're taking additional steps to tighten Host header validation. Rather than attempt to accommodate all features HTTP supports here, Django's Host header validation attempts to support a smaller, but far more common, subset: [76c32b2e1a1c1562]
- Please be aware that this security release is slightly different from previous ones. Both issues addressed here have been dealt with in prior security updates to Django. In one case, we have received ongoing reports of problems, and in the other we've chosen to take further steps to tighten up Django's code in response to independent discovery of potential problems from multiple sources. [62ed67856b9c7070]
- Redirect poisoning ================== [5483a8dae0ae966c]
- Several earlier Django security releases focused on the issue of poisoning the HTTP Host header, causing Django to generate URLs pointing to arbitrary, potentially-malicious domains. [53bbc1e0bee2777c]
- Since then, two independent audits of the code turned up further potential problems. So, similar to the Host-header issue, we are taking steps to provide tighter validation in response to reported problems (primarily with third-party applications, but to a certain extent also within Django itself). This comes in two parts: [5b47725549196b7a]
