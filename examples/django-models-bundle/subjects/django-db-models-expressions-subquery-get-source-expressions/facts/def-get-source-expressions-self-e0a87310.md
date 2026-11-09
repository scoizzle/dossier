# Fact e0a87310

Store id: dc2f3af4-634a-46b7-a0fa-fa83c59f2e9a

## Text

```text
def get_source_expressions(self)
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
- posted_at: `2026-11-09T23:44:49.6363500+00:00`

## Data

```json
{
  "end_line": 1836,
  "entity_kind": "method",
  "parent": "Subquery",
  "start_line": 1835,
  "symbol": "Subquery.get_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1835,"selector":"L1835-L1836","symbol":"Subquery.get_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Subquery.get_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1836,
    "entity_kind": "method",
    "parent": "Subquery",
    "start_line": 1835,
    "symbol": "Subquery.get_source_expressions"
  },
  "id": "dc2f3af4-634a-46b7-a0fa-fa83c59f2e9a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6363500+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1835,
        "selector": "L1835-L1836",
        "symbol": "Subquery.get_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "df261480-77c8-4008-a0b2-f9a2ca7caed1",
  "subject_name": "django/db/models/expressions::Subquery.get_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def get_source_expressions(self)"
}
```
