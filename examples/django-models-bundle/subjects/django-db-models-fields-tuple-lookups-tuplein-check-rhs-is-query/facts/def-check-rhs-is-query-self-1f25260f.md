# Fact 1f25260f

Store id: 69f9bb72-114b-487e-a812-91ebeb7e2540

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
- posted_at: `2026-11-09T22:39:45.6388250+00:00`

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
  "id": "69f9bb72-114b-487e-a812-91ebeb7e2540",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.6388250+00:00"
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
  "subject_id": "21acfc60-44d0-470d-99fd-d9776a99ea5d",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleIn.check_rhs_is_query",
  "tags": [
    "entity:method"
  ],
  "text": "def check_rhs_is_query(self)"
}
```
