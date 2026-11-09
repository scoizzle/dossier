# Fact 0b75f668

Store id: 1fe9b2a9-1811-4f2a-a433-736af836e1ad

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
- posted_at: `2026-11-09T22:39:51.7342520+00:00`

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
  "id": "1fe9b2a9-1811-4f2a-a433-736af836e1ad",
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
    "posted_at": "2026-11-09T22:39:51.7342520+00:00"
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
  "subject_id": "becb2e45-cd09-4a96-9bb0-544d30f477a4",
  "subject_name": "django/db/models/sql/subqueries::UpdateQuery._setup_query",
  "tags": [
    "entity:method"
  ],
  "text": "def _setup_query(self)"
}
```
