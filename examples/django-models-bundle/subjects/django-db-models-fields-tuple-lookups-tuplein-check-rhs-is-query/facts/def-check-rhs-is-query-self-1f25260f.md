# Fact 1f25260f

Store id: 5e6d94c2-9b2b-4739-995e-1413724eb6d7

## Text

```text
def check_rhs_is_query(self)
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
- posted_at: `2026-11-09T23:32:00.6338560+00:00`

## Data

```json
{
  "end_line": 339,
  "entity_kind": "method",
  "parent": "TupleIn",
  "start_line": 332,
  "symbol": "TupleIn.check_rhs_is_query"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":332,"selector":"L332-L339","symbol":"TupleIn.check_rhs_is_query"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::TupleIn.check_rhs_is_query](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 339,
    "entity_kind": "method",
    "parent": "TupleIn",
    "start_line": 332,
    "symbol": "TupleIn.check_rhs_is_query"
  },
  "id": "5e6d94c2-9b2b-4739-995e-1413724eb6d7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.6338560+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 332,
        "selector": "L332-L339",
        "symbol": "TupleIn.check_rhs_is_query"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "c0e48b4c-ce3a-4a53-8a93-0c32805aa28c",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleIn.check_rhs_is_query",
  "tags": [
    "entity:method"
  ],
  "text": "def check_rhs_is_query(self)"
}
```
