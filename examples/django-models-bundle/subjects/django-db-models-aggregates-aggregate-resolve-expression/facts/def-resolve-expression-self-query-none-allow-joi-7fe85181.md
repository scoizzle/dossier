# Fact 7fe85181

Store id: e262263c-533f-4dea-a19a-0eb5857b0397

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
- posted_at: `2026-11-09T23:44:48.3962410+00:00`

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
  "id": "e262263c-533f-4dea-a19a-0eb5857b0397",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.3962410+00:00"
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
  "subject_id": "9a538af8-7e83-4f9a-ae8d-ebdbbf9d1674",
  "subject_name": "django/db/models/aggregates::Aggregate.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression( self, query=None, allow_joins=True, reuse=None, summarize=False, for_save=False )"
}
```
