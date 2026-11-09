# Fact 7fe85181

Store id: aa69e349-dcf1-4ac8-a218-f850cbe7447b

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
- posted_at: `2026-11-09T22:39:40.0360190+00:00`

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
  "id": "aa69e349-dcf1-4ac8-a218-f850cbe7447b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.0360190+00:00"
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
  "subject_id": "59122511-987d-4954-bada-35abfbae03b6",
  "subject_name": "django/db/models/aggregates::Aggregate.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression( self, query=None, allow_joins=True, reuse=None, summarize=False, for_save=False )"
}
```
