# Fact 7d2a8fc7

Store id: c7bb0b20-0799-4551-b4f0-a09e130a6252

## Text

```text
def resolve_expression( self, query=None, allow_joins=True, reuse=None, summarize=False, for_save=False )
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
- posted_at: `2026-11-09T23:44:49.4778350+00:00`

## Data

```json
{
  "end_line": 908,
  "entity_kind": "method",
  "parent": "F",
  "start_line": 905,
  "symbol": "F.resolve_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":905,"selector":"L905-L908","symbol":"F.resolve_expression"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::F.resolve_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 908,
    "entity_kind": "method",
    "parent": "F",
    "start_line": 905,
    "symbol": "F.resolve_expression"
  },
  "id": "c7bb0b20-0799-4551-b4f0-a09e130a6252",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.4778350+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 905,
        "selector": "L905-L908",
        "symbol": "F.resolve_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "a718e230-89b9-4e42-a734-d1480a868b0c",
  "subject_name": "django/db/models/expressions::F.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression( self, query=None, allow_joins=True, reuse=None, summarize=False, for_save=False )"
}
```
