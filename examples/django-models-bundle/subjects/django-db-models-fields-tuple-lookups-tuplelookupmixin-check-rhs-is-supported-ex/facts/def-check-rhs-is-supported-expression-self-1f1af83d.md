# Fact 1f1af83d

Store id: 65d2dd8a-5e43-4a0b-9cef-4dea2f9ac8c2

## Text

```text
def check_rhs_is_supported_expression(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:52.7121300+00:00`

## Data

```json
{
  "end_line": 84,
  "entity_kind": "method",
  "parent": "TupleLookupMixin",
  "start_line": 77,
  "symbol": "TupleLookupMixin.check_rhs_is_supported_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":77,"selector":"L77-L84","symbol":"TupleLookupMixin.check_rhs_is_supported_expression"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::TupleLookupMixin.check_rhs_is_supported_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 84,
    "entity_kind": "method",
    "parent": "TupleLookupMixin",
    "start_line": 77,
    "symbol": "TupleLookupMixin.check_rhs_is_supported_expression"
  },
  "id": "65d2dd8a-5e43-4a0b-9cef-4dea2f9ac8c2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.7121300+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 77,
        "selector": "L77-L84",
        "symbol": "TupleLookupMixin.check_rhs_is_supported_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "0eb6a383-5a5b-4e69-bea4-dca85a8fc545",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleLookupMixin.check_rhs_is_supported_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def check_rhs_is_supported_expression(self)"
}
```
