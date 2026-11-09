# django/http/response

- Subject: django/http/response (id `19f67db3-8489-4eda-bf2a-941947ae6674`)
- Kind: subject
- Budget: 1200 tokens
- Used: 889 tokens
- Facts shown: 9 of 111
- Conflicts: 0
- Gaps: 0

## Facts

- # async iterator. Consume in async_to_sync and map back. async def to_list(_iterator): as_list = [] async for chunk in _iterator: as_list.append(chunk) return as_list [c9d5fa0d]
- async def awrapper(): async for part in _iterator: yield self.make_bytes(part) [5649ae91]
- if not 100 <= self.status_code <= 599: raise ValueError("HTTP status code must be an integer from 100 to 599.") self.reason_phrase = reason [9184a253]
- return awrapper() else: return map(self.make_bytes, self._iterator) [5838993e]
- return map(self.make_bytes, iter(async_to_sync(to_list)(self._iterator))) [a321fb62]
- # Handle string types -- we can't rely on force_bytes here because: # - Python attempts str conversion first # - when self._charset != 'utf-8' it re-encodes the content if isinstance(value, (bytes, memoryview)): return bytes(value) if isinstance(value, str): return bytes(value.encode(self.charset)) # Handle non-string types. return str(value).encode(self.charset) [636ae5db]
- ``expires`` can be: - a string in the correct format, - a naive ``datetime.datetime`` object in UTC, - an aware ``datetime.datetime`` object in any time zone. If it is a ``datetime.datetime`` object then calculate ``max_age``. [68578d20]
- ``max_age`` can be: - int/float specifying seconds, - ``datetime.timedelta`` object. """ self.cookies[key] = value if expires is not None: if isinstance(expires, datetime.datetime): if timezone.is_naive(expires): expires = timezone.make_aware(expires, datetime.UTC) delta = expires - datetime.datetime.now(tz=datetime.UTC) # Add one second so the date matches exactly (a fraction of # time gets lost between converting to a timedelta and # then the date string). delta += datetime.timedelta(seconds=1) # Just set max_age - the max_age logic will set expires. expires = None if max_age is not None: raise ValueError("'expires' and 'max_age' can't be used together.") max_age = max(0, delta.days * 86400 + delta.seconds) else: self.cookies[key]["expires"] = expires else: self.cookies[key]["expires"] = "" if max_age is not None: if isinstance(max_age, datetime.timedelta): max_age = max_age.total_seconds() self.cookies[key]["max-age"] = int(max_age) # IE requires expires, so set it if hasn't been already. if not expires: self.cookies[key]["expires"] = http_date(time.time() + max_age) if path is not None: self.cookies[key]["path"] = path if domain is not None: self.cookies[key]["domain"] = domain if secure: self.cookies[key]["secure"] = True if httponly: self.cookies[key]["httponly"] = True if samesite: if samesite.lower() not in ("lax", "none", "strict"): raise ValueError('samesite must be "lax", "none", or "strict".') self.cookies[key]["samesite"] = samesite [8f63d10c]
- filename = os.path.basename(self.filename or filename) if self._no_explicit_content_type: if filename: content_type, encoding = mimetypes.guess_type(filename) # Encoding isn't set to prevent browsers from automatically # uncompressing files. content_type = { "br": "application/x-brotli", "bzip2": "application/x-bzip", "compress": "application/x-compress", "gzip": "application/gzip", "xz": "application/x-xz", }.get(encoding, content_type) self.headers["Content-Type"] = ( content_type or "application/octet-stream" ) else: self.headers["Content-Type"] = "application/octet-stream" [0c33b3c7]

## Beyond the budget

101 more facts did not fit in the budget: [447db287] [97494c8d] [d372408b] [dffd38fa] [e1eb6561] [cada1755] [1d1f491f] [cba6c4da] [333bd6c6] [b415e761] [5c08aaf3] [d792b3d0] [60735670] [4f45d929] [91d52014] [ccf273ff] [f3e01404] [66e42ec2] [6ca3048f] [4a968e8e] [f5d939c1] [4d13c190] [0425153f] [f21fdbec] [a860517a] [b71605d2] [1729301a] [f00cf199] [bbc39638] [6f7dc119] [bace6e2b] [9c558a40] [ad056046] [403a524c] [7325dd80] [fb5c1b50] [78332590] [9f99c2f0] [5cffe041] [13ad6df7] [0772b6e1] [c5416404] [9ed5c6e6] [1b554659] [80dd9416] [2aa40cd3] [22a63097] [292f4d68] [3e2d9bb5] [9a45a85e] [c801e702] [0dbc7734] [48937fa8] [0852fc10] [671b15be] [56abfc55] [e914334d] [e8f7249d] [a10945d0] [251274c3] [d6083839] [afc2e13a] [3386e46f] [7c3d755c] [93919d3c] [803b6a9a] [23b116e9] [479fd210] [dc1c39c8] [66e61cd1] [ccadba4f] [09e7b8a4] [faf25e14] [d81ef6ac] [c37e5c8e] [1a9678c1] [9350e86d] [67f85210] [ed54500e] [bebd9b0d] [9413c3ae] [7d0750c8] [b9bb224d] [02f7c796] [fcec95d3] [72c699ac] [893634c5] [773ed0ce] [643300ef] [34fdf980] [39034025] [a66fa3e7] [ef3b1acc] [babdce40] [aeb4935a] [3bbfd5b0] [ae4184a5] [6a3cc8dd] [cf6bbf2daef2deb8-4] [5c49e75b] [b71e52d4]
