# Fact 1f1af83d

Store id: fd5fefab-94dd-4e7d-bb96-d30aeff40905

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
- posted_at: `2026-11-09T22:39:45.5653510+00:00`

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
  "id": "fd5fefab-94dd-4e7d-bb96-d30aeff40905",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.5653510+00:00"
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
  "subject_id": "9b6c66a7-7129-4417-8c6c-c1bd75aed6fc",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleLookupMixin.check_rhs_is_supported_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def check_rhs_is_supported_expression(self)"
}
```
