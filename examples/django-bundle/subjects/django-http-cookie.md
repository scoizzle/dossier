# django/http/cookie

- Subject: django/http/cookie (id `8218f969-98f8-42d9-9588-f60bd8427441`)
- Kind: subject
- Budget: 1200 tokens
- Used: 169 tokens
- Facts shown: 3 of 3
- Conflicts: 0
- Gaps: 0

## Facts

- # For backwards compatibility in Django 2.1. SimpleCookie = cookies.SimpleCookie [e5a525c8]
- def parse_cookie(cookie): """ Return a dictionary parsed from a `Cookie:` header string. """ cookiedict = {} for chunk in cookie.split(";"): if "=" in chunk: key, val = chunk.split("=", 1) else: # Assume an empty name per # https://bugzilla.mozilla.org/show_bug.cgi?id=169091 key, val = "", chunk key, val = key.strip(), val.strip() if key or val: # unquote using Python's algorithm. cookiedict[key] = cookies._unquote(val) return cookiedict [5b17ccae]
- from http import cookies [8e5158a5]
