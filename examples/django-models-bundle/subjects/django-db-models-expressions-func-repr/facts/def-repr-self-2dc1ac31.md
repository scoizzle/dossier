# Fact 2dc1ac31

Store id: 9374b1b7-1e67-4d28-b490-08c5b94365f3

## Text

```text
def __repr__(self)
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
- posted_at: `2026-11-09T22:39:41.5776660+00:00`

## Data

```json
{
  "end_line": 1085,
  "entity_kind": "method",
  "parent": "Func",
  "start_line": 1077,
  "symbol": "Func.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1077,"selector":"L1077-L1085","symbol":"Func.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Func.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1085,
    "entity_kind": "method",
    "parent": "Func",
    "start_line": 1077,
    "symbol": "Func.__repr__"
  },
  "id": "9374b1b7-1e67-4d28-b490-08c5b94365f3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5776660+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1077,
        "selector": "L1077-L1085",
        "symbol": "Func.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "68036f97-87b2-4ec1-a560-598612bae6f9",
  "subject_name": "django/db/models/expressions::Func.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
