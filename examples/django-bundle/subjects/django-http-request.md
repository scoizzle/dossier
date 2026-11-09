# django/http/request

- Subject: django/http/request (id `61f3cfb9-9b69-455e-967a-0159c4c2e39e`)
- Kind: subject
- Budget: 1200 tokens
- Used: 898 tokens
- Facts shown: 18 of 117
- Conflicts: 0
- Gaps: 0

## Facts

- # Content-Length can be absent or understated (e.g. # `Transfer-Encoding: chunked` on ASGI), so for seekable # streams (e.g. SpooledTemporaryFile on ASGI), check the actual # buffered size before reading it all into memory. if self._stream.seekable(): stream_size = self._stream.seek(0, os.SEEK_END) self._check_data_too_big(stream_size) self._stream.seek(0) [cc6d29bb]
- # Make Content-Length fall back to 0 if malformed (e.g. ASGIRequest # comma-joins duplicate Content-Length headers). try: content_length = int(self.META.get("CONTENT_LENGTH") or 0) except (ValueError, TypeError): content_length = 0 # Limit the maximum request data size that will be handled # in-memory. Reject early when Content-Length is present and # already exceeds the limit, avoiding reading the body at all. self._check_data_too_big(content_length) [bbca2106]
- >>> q = QueryDict(mutable=True) >>> q['next'] = '/a&b/' >>> q.urlencode() 'next=%2Fa%26b%2F' >>> q.urlencode(safe='/') 'next=/a%26b/' """ output = [] if safe: safe = safe.encode(self.encoding) [9a42ea0c]
- def encode(k, v): return "%s=%s" % ((quote(k, safe), quote(v, safe))) [f22f8290]
- def encode(k, v): return urlencode({k: v}) [91cde3e5]
- try: self._body = self.read() except OSError as e: raise UnreadablePostError(*e.args) from e finally: self._stream.close() self._stream = BytesIO(self._body) return self._body [2cd118a6]
- # Allow variants of localhost if ALLOWED_HOSTS is empty and DEBUG=True. allowed_hosts = settings.ALLOWED_HOSTS if settings.DEBUG and not allowed_hosts: allowed_hosts = [".localhost", "127.0.0.1", "[::1]"] [f7d6b2fb]
- # Main types and sub types must be defined. if not all((*main_types, *sub_types)): return False [9af9ce41]
- # Main types must match or one be "*", same for sub types. for this_type, other_type in (main_types, sub_types): if this_type != other_type and this_type != "*" and other_type != "*": return False [baac5b6f]
- # Of the desired media types, select the one which is preferred. return min(desired_types, key=lambda t: self.accepted_types.index(t[0]))[1] [df7bd743]
- # Valid quality values must be between 0 and 1. if quality < 0 or quality > 1: return 1 [af54fce2]
- `safe` specifies characters which don't require quoting, for example:: [1ef9c1e6]
- desired_types = [ (accepted_type, media_type) for media_type in media_types if (accepted_type := self.accepted_type(media_type)) is not None ] [da4ef061]
- domain, port = split_domain_port(host) if domain and validate_host(domain, allowed_hosts): return host else: msg = "Invalid HTTP_HOST header: %r." % host if domain: msg += " You may need to add %r to ALLOWED_HOSTS." % domain else: msg += ( " The domain name provided is not valid according to RFC 1034/1035." ) raise DisallowedHost(msg) [2dcb82f9]
- else: [6ad07797f4838346-13]
- for k, list_ in self.lists(): output.extend( encode(k.encode(self.encoding), str(v).encode(self.encoding)) for v in list_ ) return "&".join(output) [6dc03a57]
- if not desired_types: return None [8bd0d6ea]
- if not isinstance(other, MediaType): other = MediaType(other) [c1e59aac]

## Beyond the budget

96 more facts did not fit in the budget: [b6336e72] [b6fb7447] [cc646f96] [20499d71] [7df51021] [a05a764a] [83517f28] [af640246] [13ae7253] [5c1ea467] [ac490f01] [767318c8] [95d68f51] [6875a96d] [490f6475] [8d864235] [5e4a2e7f] [a606631b] [1ad7315f] [d2d36bf3] [098a197f] [a697fdc5] [461a3a28] [85aa1e48] [b9d35e14] [01a9a3b6] [7a4bedf1] [c97a425f] [727338db] [a33d56eb] [f8032b81] [41addf4f] [fd9d85b8] [397413c9] [c91b9161] [a8c6f22f] [ec59817b] [cd822cd7] [4fd83a94] [d68fa3db] [a34aaedd] [191b2de5] [4c9ab5b4] [575c8e5b] [95541774] [a08a6e44] [81e9afb1] [0f8b063b] [2a1fcabf] [99751153] [09b16694] [515026ba] [6932acc3] [badc5137] [f7ff5afb] [0349701b] [ab7abf5c] [0ad692a3] [bee7ef92] [41aaff47] [9a8f7217] [e2993124] [d96929c5] [15e88c50] [14b908a3] [a96fe333] [6a8a38ee] [fe2c698d] [42bf3076] [34ed12d0] [087359dd] [b6a6a4bd] [251650f9] [ad9053ea] [b995afa6] [6dd0dff0] [78993061] [94103055] [d0d729c7] [0bfd7c82] [77ddfc50] [fee779cd] [34c15c4f] [7655780f0d17b825-51] [13c972bf] [d3211efc] [ddc3640f] [b273c461] [25f8e602] [bd9babe7] [7c1519d8] [47b43d74] [96f0c122] [64ff7eeb] [3ab0fa24] [82e4785f]
