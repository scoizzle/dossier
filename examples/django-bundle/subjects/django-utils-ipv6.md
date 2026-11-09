# django/utils/ipv6

- Subject: django/utils/ipv6 (id `588a2141-2da8-4114-88bc-ee6132659f71`)
- Kind: subject
- Budget: 1200 tokens
- Used: 521 tokens
- Facts shown: 12 of 12
- Conflicts: 0
- Gaps: 0

## Facts

- Args: ip_str: A valid IPv6 address. unpack_ipv4: if an IPv4-mapped address is found, return the plain IPv4 address (default=False). error_message: An error message used in the ValidationError. [390eea74]
- Raise ValidationError if the address is invalid. [7f5ab7b4]
- Replace the longest continuous zero-sequence with "::", remove leading zeroes, and make sure all hextets are lowercase. [ef969d7a]
- Return a compressed IPv6 address or the same value. """ try: addr = _ipv6_address_from_str(ip_str, max_length) except ValueError: raise ValidationError( error_message, code="invalid", params={"protocol": _("IPv6")} ) [c7149d7f]
- if unpack_ipv4 and addr.ipv4_mapped: return str(addr.ipv4_mapped) elif addr.ipv4_mapped: return "::ffff:%s" % str(addr.ipv4_mapped) [32addd09]
- return str(addr) [d47adc39]
- MAX_IPV6_ADDRESS_LENGTH = 39 [1db3412b]
- def _ipv6_address_from_str(ip_str, max_length=MAX_IPV6_ADDRESS_LENGTH): if len(ip_str) > max_length: raise ValueError( f"Unable to convert {ip_str} to an IPv6 address (value too long)." ) return ipaddress.IPv6Address(int(ipaddress.IPv6Address(ip_str))) [08573412]
- def clean_ipv6_address( ip_str, unpack_ipv4=False, error_message=_("This is not a valid IPv6 address."), max_length=MAX_IPV6_ADDRESS_LENGTH, ): """ Clean an IPv6 address string. [2e04d891]
- def is_valid_ipv6_address(ip_addr): """ Return whether the `ip_addr` object is a valid IPv6 address. """ if isinstance(ip_addr, ipaddress.IPv6Address): return True try: _ipv6_address_from_str(ip_addr) except (TypeError, ValueError): return False return True [38d642d7]
- from django.core.exceptions import ValidationError from django.utils.translation import gettext_lazy as _ [039f023e]
- import ipaddress [801c0e4c]
