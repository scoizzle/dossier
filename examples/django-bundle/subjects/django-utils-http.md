# django/utils/http

- Subject: django/utils/http (id `aaf0fc4c-dbbe-4f2e-b9e7-0de29395d516`)
- Kind: subject
- Budget: 1200 tokens
- Used: 879 tokens
- Facts shown: 11 of 42
- Conflicts: 0
- Gaps: 0

## Facts

- # Fast path for no params. if ";" not in line: return line.strip().lower(), {} [02b02ab7]
- Always return ``False`` on an empty url. [f2b156ab]
- Any pattern beginning with a period matches a domain and all of its subdomains. (e.g. ``.example.com`` matches ``example.com`` and ``foo.example.com``). Anything else is an exact string match. """ if not pattern: return False [f1098230]
- Any qualified value is discarded, so that qualified forms permitted by RFC 9111 (e.g. `private="Set-Cookie"`) reduce to their directive name ("private"). [409856f0]
- ETags values containing a comma are not supported, as the comma is used as list separator. """ if etag_str.strip() == "*": return ["*"] else: # Parse each ETag individually, and return any that are valid. etag_matches = (ETAG_MATCH.match(etag) for etag in split_header_value(etag_str)) return [match[1] for match in etag_matches if match] [6cb4fe92]
- If ``require_https`` is ``True``, only 'https' will be considered a valid scheme, as opposed to 'http' and 'https' with the default, ``False``. [0c8ed6f2]
- If `line` is longer than `max_length`, `ValueError` is raised. """ if not line: return "", {} [ddc4da64]
- Note: "True" doesn't entail that a URL is "safe". It may still be e.g. quoted incorrectly. Ensure to also use django.utils.encoding.iri_to_uri() on the path component of untrusted URLs. """ if url is not None: url = url.strip() if not url: return False if allowed_hosts is None: allowed_hosts = set() elif isinstance(allowed_hosts, str): allowed_hosts = {allowed_hosts} # Chrome treats \ completely as / in paths but it could be part of some # basic auth credentials so we need to check both URLs. return _url_has_allowed_host_and_scheme( url, allowed_hosts, require_https=require_https ) and _url_has_allowed_host_and_scheme( url.replace("\\", "/"), allowed_hosts, require_https=require_https ) [28ab3b14]
- Output a string in the format 'Wdy, DD Mon YYYY HH:MM:SS GMT'. """ return formatdate(epoch_seconds, usegmt=True) [03a5a377]
- Return an integer expressed in seconds since the epoch, in UTC. """ # email.utils.parsedate() does the job for RFC 1123 dates; unfortunately # RFC 9110 makes it mandatory to support RFC 850 dates too. So we roll # our own RFC-compliant parsing. for regex in RFC1123_DATE, RFC850_DATE, ASCTIME_DATE: m = regex.match(date) if m is not None: break else: raise ValueError("%r is not in a valid HTTP date format" % date) try: year = int(m["year"]) if year < 100: current_year = datetime.now(tz=UTC).year current_century = current_year - (current_year % 100) if year - (current_year % 100) > 50: # year that appears to be more than 50 years in the future are # interpreted as representing the past. year += current_century - 100 else: year += current_century month = MONTHS.index(m["mon"].lower()) + 1 day = int(m["day"]) hour = int(m["hour"]) min = int(m["min"]) sec = int(m["sec"]) result = datetime(year, month, day, hour, min, sec, tzinfo=UTC) return int(result.timestamp()) except Exception as exc: raise ValueError("%r is not a valid date" % date) from exc [bee40d88]
- The three formats allowed by the RFC are accepted, even if only the first one is still in widespread use. [9c8b4920]

## Beyond the budget

31 more facts did not fit in the budget: [1bde7049] [a5470746] [e7116c9c] [85145dbf] [61797dab] [f157fe0b] [568b00e1] [efb93310] [c2a7c44e] [795f24e6] [71e8afff] [235fea6c] [ed53a925] [3eae327b] [5e68335e] [e0e93ec1] [e7c39df9] [760f0904] [d6e564f4] [4c09db95] [e1f02e33] [30fd8deb] [307ba2bd] [1952ab21] [b0cbc7b2] [b8c41f84] [eecd4aa9] [5765e77e] [41e9bd19] [4fab26cb] [eb1a6991]
