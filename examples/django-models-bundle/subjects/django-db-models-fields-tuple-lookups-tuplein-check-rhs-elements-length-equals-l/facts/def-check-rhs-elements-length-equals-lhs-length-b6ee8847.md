# Fact b6ee8847

Store id: 9ecc8f0a-cd6b-4162-9ebd-9ff7cc35b00c

## Text

```text
def check_rhs_elements_length_equals_lhs_length(self)
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
- posted_at: `2026-11-09T23:44:52.7938310+00:00`

## Data

```json
{
  "end_line": 330,
  "entity_kind": "method",
  "parent": "TupleIn",
  "start_line": 323,
  "symbol": "TupleIn.check_rhs_elements_length_equals_lhs_length"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":323,"selector":"L323-L330","symbol":"TupleIn.check_rhs_elements_length_equals_lhs_length"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::TupleIn.check_rhs_elements_length_equals_lhs_length](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 330,
    "entity_kind": "method",
    "parent": "TupleIn",
    "start_line": 323,
    "symbol": "TupleIn.check_rhs_elements_length_equals_lhs_length"
  },
  "id": "9ecc8f0a-cd6b-4162-9ebd-9ff7cc35b00c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.7938310+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 323,
        "selector": "L323-L330",
        "symbol": "TupleIn.check_rhs_elements_length_equals_lhs_length"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "f54cc8a2-4bab-4a74-b772-f201afc89e95",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleIn.check_rhs_elements_length_equals_lhs_length",
  "tags": [
    "entity:method"
  ],
  "text": "def check_rhs_elements_length_equals_lhs_length(self)"
}
```
