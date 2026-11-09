# Fact 7fe85181

Store id: a36d575f-239c-4f38-a7b1-cc7edfd9e038

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
- posted_at: `2026-11-09T23:31:53.5330110+00:00`

## Data

```json
{
  "end_line": 160,
  "entity_kind": "method",
  "parent": "Aggregate",
  "start_line": 121,
  "symbol": "Aggregate.resolve_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":121,"selector":"L121-L160","symbol":"Aggregate.resolve_expression"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::Aggregate.resolve_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 160,
    "entity_kind": "method",
    "parent": "Aggregate",
    "start_line": 121,
    "symbol": "Aggregate.resolve_expression"
  },
  "id": "a36d575f-239c-4f38-a7b1-cc7edfd9e038",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.5330110+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 121,
        "selector": "L121-L160",
        "symbol": "Aggregate.resolve_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "b042e221-3dd6-4d2d-82f6-9631f2509e5d",
  "subject_name": "django/db/models/aggregates::Aggregate.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression( self, query=None, allow_joins=True, reuse=None, summarize=False, for_save=False )"
}
```
