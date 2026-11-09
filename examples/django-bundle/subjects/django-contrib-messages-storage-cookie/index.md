# django/contrib/messages/storage/cookie

- Subject: django/contrib/messages/storage/cookie (id `48f46db9-9706-41fb-b0af-05911f19c0ef`)
- Kind: subject
- Budget: 1200 tokens
- Used: 889 tokens
- Facts shown: 13 of 30
- Conflicts: 0
- Gaps: 0

## Facts

- def compute_msg(some_serialized_msg): return self._encode_parts( [*some_serialized_msg, self.not_finished_json], encode_empty=True, ) [7bc942dd]
- def is_too_large_for_cookie(data): return data and len(cookie.value_encode(data)[1]) > self.max_cookie_size [a4d7ca14]
- if is_too_large_for_cookie(encoded_data): if remove_oldest: idx = bisect_keep_right( serialized_messages, fn=lambda m: is_too_large_for_cookie(compute_msg(m)), ) unstored_messages = messages[:idx] encoded_data = compute_msg(serialized_messages[idx:]) else: idx = bisect_keep_left( serialized_messages, fn=lambda m: is_too_large_for_cookie(compute_msg(m)), ) unstored_messages = messages[idx:] encoded_data = compute_msg(serialized_messages[:idx]) [2f686702]
- If the encoded data is larger than ``max_cookie_size``, remove messages until the data fits (these are the messages which are returned), and add the not_finished sentinel value to indicate as much. """ unstored_messages = [] serialized_messages = MessagePartSerializer().dumps(messages) encoded_data = self._encode_parts(serialized_messages) if self.max_cookie_size: # data is going to be stored eventually by SimpleCookie, which # adds its own overhead, which we must account for. cookie = SimpleCookie() # create outside the loop [cb0b03a6]
- If the encoded text stream contained an invalid hash or was in an invalid format, return None. """ if not data: return None try: return self.signer.unsign_object(data, serializer=MessageSerializer) except (signing.BadSignature, binascii.Error, json.JSONDecodeError): pass # Mark the data as used (so it gets removed) since something was wrong # with the data. self.used = True return None [13b56f6c]
- Proxies MessagePartSerializer.dumps and _encoded_parts. """ serialized_messages = MessagePartSerializer().dumps(messages) return self._encode_parts(serialized_messages, encode_empty=encode_empty) [7826cb98]
- Since the data will be retrieved from the client-side, the encoded data also contains a hash to ensure that the data was not tampered with. """ if messages or encode_empty: return self.signer.sign_object( messages, serializer=MessagePartGatherSerializer, compress=True ) [fb325b8c]
- self._update_cookie(encoded_data, response) return unstored_messages [6cf46008]
- cookie_name = "messages" # uwsgi's default configuration enforces a maximum size of 4kb for all the # HTTP headers. In order to leave some room for other cookies and headers, # restrict the session cookie to 1/2 of 4kb. See #18781. max_cookie_size = 2048 not_finished = "__messagesnotfinished__" not_finished_json = json.dumps("__messagesnotfinished__") key_salt = "django.contrib.messages" [d9a883d8]
- def __init__(self, *args, **kwargs): super().__init__(*args, **kwargs) self.signer = signing.get_cookie_signer(salt=self.key_salt) [13865f4b]
- def _decode(self, data): """ Safely decode an encoded text stream back into a list of messages. [448ede63]
- def _encode(self, messages, encode_empty=False): """ Return an encoded version of the messages list which can be stored as plain text. [11a07c5a]
- def decode(self, s, **kwargs): decoded = super().decode(s, **kwargs) return self.process_messages(decoded) [aeb2fa9f]

## Beyond the budget

15 more facts did not fit in the budget: [2a1fdff6] [b70d3555] [f828b030] [6c59482c] [4350993a] [00338299] [0e7b764a] [84b40ce7] [04b2e03f] [0cafcec4] [b4b7c6fd] [909e33ec] [f84384f5] [9ad6f8d0] [fe33723b]
