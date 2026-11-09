# django/http/multipartparser

- Subject: django/http/multipartparser (id `abd5dcc6-0eae-41ef-a392-0911275a7caa`)
- Kind: subject
- Budget: 1200 tokens
- Used: 890 tokens
- Facts shown: 10 of 110
- Conflicts: 0
- Gaps: 0

## Facts

- try: chunk = base64.b64decode( stripped_chunk[:aligned_length], validate=True ) except Exception as exc: # Since this is only a chunk, any error is # an unfixable error. raise MultiPartParserError( "Could not decode base64 data." ) from exc [61d49ed9]
- for i, handler in enumerate(handlers): chunk_length = len(chunk) chunk = handler.receive_data_chunk(chunk, counters[i]) counters[i] += chunk_length if chunk is None: # Don't continue if the chunk received by # the handler is None. break [8d3dca87]
- base64_remainder = b"" for chunk in field_stream: if transfer_encoding == "base64": # We only special-case base64 transfer encoding # We should always decode base64 chunks by # multiple of 4, ignoring whitespace. Carry the # trailing 1-3 bytes over to the next chunk # rather than reading ahead, so that memory use # stays bounded by the chunk size. stripped_chunk = base64_remainder + b"".join( chunk.split() ) aligned_length = len(stripped_chunk) // 4 * 4 base64_remainder = stripped_chunk[aligned_length:] if not aligned_length: continue [8e598ff9]
- if base64_remainder: # Leftover bytes mean the base64 data is truncated. raise MultiPartParserError("Could not decode base64 data.") [98699fa7]
- # Add two here to make the check consistent with the # x-www-form-urlencoded check that includes '&='. num_bytes_read += len(field_name) + 2 if ( settings.DATA_UPLOAD_MAX_MEMORY_SIZE is not None and num_bytes_read > settings.DATA_UPLOAD_MAX_MEMORY_SIZE ): raise RequestDataTooBig( "Request body exceeded " "settings.DATA_UPLOAD_MAX_MEMORY_SIZE." ) [b29a7d58]
- # This is a post field, we can just set it in the post if transfer_encoding == "base64": raw_data = field_stream.read(size=read_size) num_bytes_read += len(raw_data) try: data = base64.b64decode(raw_data, validate=True) except binascii.Error: data = raw_data else: data = field_stream.read(size=read_size) num_bytes_read += len(data) [c84d3bdb]
- content_type, content_type_extra = meta_data.get( "content-type", ("", {}) ) content_type = content_type.strip() charset = content_type_extra.get("charset") [bbce3673]
- counters = [0] * len(handlers) uploaded_file = False try: for handler in handlers: try: handler.new_file( field_name, file_name, content_type, content_length, charset, content_type_extra, ) except StopFutureHandlers: break [1180ea9d]
- except SkipFile: self._close_files() # Just use up the rest of this file... exhaust(field_stream) else: # Handle file upload completions on next iteration. old_field_name = field_name else: # If this is neither a FIELD nor a FILE, exhaust the field # stream. Note: There could be an error here at some point, # but there will be at least two RAW types (before and # after the other boundaries). This branch is usually not # reached at all, because a missing content-disposition # header will skip the whole boundary. exhaust(field_stream) except StopUpload as e: self._close_files() if not e.connection_reset: exhaust(self._input_data) else: if not uploaded_file: for handler in handlers: handler.upload_interrupted() # Make sure that the request data is all fed exhaust(self._input_data) [d8df83a5]
- try: content_length = int(meta_data.get("content-length")[0]) except (IndexError, TypeError, ValueError): content_length = None [4df6e415]

## Beyond the budget

97 more facts did not fit in the budget: [32bfacef] [c30bed32] [1a1def74] [8738264d] [47f996bb] [a43f04da] [21f4bb63] [1133f3f3] [83e5eec8] [289fe767] [2dea007d] [d79848b2] [408a8023] [66ad2393] [0722305c] [f8feb3f5] [52bc40bb] [b20e9177] [5565d9a3] [6f97e37a] [5a4110be] [42bb95d6] [ae17d721] [5cd91b6f] [6c854b4d] [66d7eca4] [51e8af76] [30ef8721] [077fd67a] [2ac3c865] [acf27b5a] [3e4c0243] [50f1c3a8] [99ceda17] [1b00cb47] [469bdd52] [0dd466e1] [7643d70c] [d20179f2] [4c97c08e] [0ac79db6] [a0df691a] [07f74c99] [91ddf9c0] [a86a2a5d] [866d32ba] [63389727] [58095287] [4f1808f1] [21ab7d03] [aa9c3bde] [f670d7ea] [02a5a05a] [80f5215c] [5f684ea7] [d5ee33a5] [6b669c1a] [b3452f1b] [398b1af8] [99fd7f50] [49d638e1] [39fa939991912f8b-2] [3affb12c] [b90de6d4] [213d8a7a] [5a5b75fd] [edc7f716] [0cb9d418] [2ebc01b9] [15b8a34c] [abba8b9d] [11886fdb] [a778e661] [16a47d0e] [c2b3fa15] [072d4b82] [56d7c7b9] [91b85a2d] [c4cc997c] [7655780f0d17b825-50] [0ba325d6] [d2507139] [cf3f09b2] [05fd4fae] [1daed010] [c1891b15] [db48f932] [af6b99a7] [28c43e66] [7e5b2976] [b0e21664] [343de4d6] [edb7bab5] [6b634c03] [caa79d32] [29b68ffc] [ac759a63]
