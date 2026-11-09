# Fact 33098c87

Store id: 00afbfb7-e357-4ecf-a1f6-28efee786b07

## Text

```text
def __init__(self, *args, **kwargs)
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
- posted_at: `2026-11-09T22:39:49.7647810+00:00`

## Data

```json
{
  "end_line": 2407,
  "entity_kind": "method",
  "parent": "EmptyQuerySet",
  "start_line": 2406,
  "symbol": "EmptyQuerySet.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2406,"selector":"L2406-L2407","symbol":"EmptyQuerySet.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/query::EmptyQuerySet.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2407,
    "entity_kind": "method",
    "parent": "EmptyQuerySet",
    "start_line": 2406,
    "symbol": "EmptyQuerySet.__init__"
  },
  "id": "00afbfb7-e357-4ecf-a1f6-28efee786b07",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.7647810+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2406,
        "selector": "L2406-L2407",
        "symbol": "EmptyQuerySet.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "f00a838e-21d0-418f-b926-7afcf9751e95",
  "subject_name": "django/db/models/query::EmptyQuerySet.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, *args, **kwargs)"
}
```
