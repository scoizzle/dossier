# Fact 1ded1851

Store id: 7e809d4b-d68a-4522-bf84-f7879071011e

## Text

```text
def set_source_expressions(self, exprs)
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
- posted_at: `2026-11-09T23:44:49.6374570+00:00`

## Data

```json
{
  "end_line": 1839,
  "entity_kind": "method",
  "parent": "Subquery",
  "start_line": 1838,
  "symbol": "Subquery.set_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1838,"selector":"L1838-L1839","symbol":"Subquery.set_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Subquery.set_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1839,
    "entity_kind": "method",
    "parent": "Subquery",
    "start_line": 1838,
    "symbol": "Subquery.set_source_expressions"
  },
  "id": "7e809d4b-d68a-4522-bf84-f7879071011e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6374570+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1838,
        "selector": "L1838-L1839",
        "symbol": "Subquery.set_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "43d0a075-f7bd-4d8c-a694-6df796fbf96d",
  "subject_name": "django/db/models/expressions::Subquery.set_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def set_source_expressions(self, exprs)"
}
```
