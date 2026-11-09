# Fact 1f1af83d

Store id: 53341523-1e11-4cfa-98cb-633fc0dbb77c

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
- posted_at: `2026-11-09T23:32:00.5498680+00:00`

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
  "id": "53341523-1e11-4cfa-98cb-633fc0dbb77c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.5498680+00:00"
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
  "subject_id": "80807c89-9834-4c1d-8546-efb8aeccab48",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleLookupMixin.check_rhs_is_supported_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def check_rhs_is_supported_expression(self)"
}
```
