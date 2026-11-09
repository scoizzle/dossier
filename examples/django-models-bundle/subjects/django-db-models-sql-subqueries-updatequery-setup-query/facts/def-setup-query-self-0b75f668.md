# Fact 0b75f668

Store id: a45bafa5-9241-4286-8059-4e8e1451d18b

## Text

```text
def _setup_query(self)
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
- posted_at: `2026-11-09T23:32:07.3742400+00:00`

## Data

```json
{
  "end_line": 65,
  "entity_kind": "method",
  "parent": "UpdateQuery",
  "start_line": 58,
  "symbol": "UpdateQuery._setup_query"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/subqueries.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":58,"selector":"L58-L65","symbol":"UpdateQuery._setup_query"}`

## Items

```json
[
  {
    "text": "Run on initialization and at the end of chaining. Any attributes that would normally be set in __init__() should go here instead.",
    "locator": {
      "line": 59
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/subqueries::UpdateQuery._setup_query](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 65,
    "entity_kind": "method",
    "parent": "UpdateQuery",
    "start_line": 58,
    "symbol": "UpdateQuery._setup_query"
  },
  "id": "a45bafa5-9241-4286-8059-4e8e1451d18b",
  "items": [
    {
      "locator": {
        "line": 59
      },
      "text": "Run on initialization and at the end of chaining. Any attributes that would normally be set in __init__() should go here instead."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.3742400+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 58,
        "selector": "L58-L65",
        "symbol": "UpdateQuery._setup_query"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/subqueries.py"
    }
  ],
  "status": "live",
  "subject_id": "3331a7d0-2671-4899-bdc1-31c3ab8e6959",
  "subject_name": "django/db/models/sql/subqueries::UpdateQuery._setup_query",
  "tags": [
    "entity:method"
  ],
  "text": "def _setup_query(self)"
}
```
