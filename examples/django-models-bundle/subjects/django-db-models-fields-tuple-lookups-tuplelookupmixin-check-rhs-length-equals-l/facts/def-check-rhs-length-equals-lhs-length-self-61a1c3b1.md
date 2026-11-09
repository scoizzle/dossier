# Fact 61a1c3b1

Store id: 3c94a492-9275-49fe-8395-11b82afe1d50

## Text

```text
def check_rhs_length_equals_lhs_length(self)
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
- posted_at: `2026-11-09T23:32:00.5451000+00:00`

## Data

```json
{
  "end_line": 75,
  "entity_kind": "method",
  "parent": "TupleLookupMixin",
  "start_line": 69,
  "symbol": "TupleLookupMixin.check_rhs_length_equals_lhs_length"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":69,"selector":"L69-L75","symbol":"TupleLookupMixin.check_rhs_length_equals_lhs_length"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::TupleLookupMixin.check_rhs_length_equals_lhs_length](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 75,
    "entity_kind": "method",
    "parent": "TupleLookupMixin",
    "start_line": 69,
    "symbol": "TupleLookupMixin.check_rhs_length_equals_lhs_length"
  },
  "id": "3c94a492-9275-49fe-8395-11b82afe1d50",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.5451000+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 69,
        "selector": "L69-L75",
        "symbol": "TupleLookupMixin.check_rhs_length_equals_lhs_length"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "531cd1d1-f1c8-495a-945c-395f7ceaf14f",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleLookupMixin.check_rhs_length_equals_lhs_length",
  "tags": [
    "entity:method"
  ],
  "text": "def check_rhs_length_equals_lhs_length(self)"
}
```
