# django/middleware/gzip

- Subject: django/middleware/gzip (id `de892de2-7885-426f-9938-fa3cf08fe758`)
- Kind: subject
- Budget: 1200 tokens
- Used: 638 tokens
- Facts shown: 11 of 11
- Conflicts: 0
- Gaps: 0

## Facts

- # Avoid gzipping if we've already got a content-encoding. if response.has_header("Content-Encoding"): return response [b1af824b]
- # If there is a strong ETag, make it weak to fulfill the requirements # of RFC 9110 Section 8.8.1 while also allowing conditional request # matches on ETags. etag = response.get("ETag") if etag and etag.startswith('"'): response.headers["ETag"] = "W/" + etag response.headers["Content-Encoding"] = "gzip" [8c293048]
- ae = request.META.get("HTTP_ACCEPT_ENCODING", "") if not re_accepts_gzip.search(ae): return response [80b94baa]
- if response.streaming: if response.is_async: response.streaming_content = acompress_sequence( response.streaming_content, max_random_bytes=self.max_random_bytes, ) else: response.streaming_content = compress_sequence( response.streaming_content, max_random_bytes=self.max_random_bytes, ) # Delete the `Content-Length` header for streaming content, because # we won't know the compressed size until we stream it. del response.headers["Content-Length"] else: # Return the compressed content only if it's actually shorter. compressed_content = compress_string( response.content, max_random_bytes=self.max_random_bytes, ) if len(compressed_content) >= len(response.content): return response response.content = compressed_content response.headers["Content-Length"] = str(len(response.content)) [9c2cbcbc]
- patch_vary_headers(response, ("Accept-Encoding",)) [0771918f]
- return response [8034aacd88b9c7ae-7]
- def process_response(self, request, response): # It's not worth attempting to compress really short responses. if not response.streaming and len(response.content) < 200: return response [234f5a16]
- max_random_bytes = 100 [965df204]
- class GZipMiddleware(MiddlewareMixin): """ Compress content if the browser allows gzip compression. Set the Vary header accordingly, so that caches will base their storage on the Accept-Encoding header. """ [39798359]
- from django.utils.cache import patch_vary_headers from django.utils.deprecation import MiddlewareMixin from django.utils.regex_helper import _lazy_re_compile from django.utils.text import acompress_sequence, compress_sequence, compress_string [a6d7791c]
- re_accepts_gzip = _lazy_re_compile(r"\bgzip\b") [b93748ca]
