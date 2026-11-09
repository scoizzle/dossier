# Fact 5d76284a

Store id: de91288b-19bf-4ceb-a9ec-fa5254c9aebb

## Text

```text
def identity(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:49.4253360+00:00`

## Data

```json
{
  "end_line": 554,
  "entity_kind": "method",
  "parent": "Expression",
  "start_line": 540,
  "symbol": "Expression.identity"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":540,"selector":"L540-L554","symbol":"Expression.identity"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Expression.identity](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 554,
    "entity_kind": "method",
    "parent": "Expression",
    "start_line": 540,
    "symbol": "Expression.identity"
  },
  "id": "de91288b-19bf-4ceb-a9ec-fa5254c9aebb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.4253360+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 540,
        "selector": "L540-L554",
        "symbol": "Expression.identity"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "30eb68ac-5b07-47f8-bad4-db5d352150c1",
  "subject_name": "django/db/models/expressions::Expression.identity",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def identity(self)"
}
```
