# Fact f5afee5e

Store id: 350abbaa-2e73-4629-858f-643ab7a7e40d

## Text

```text
def resolve_expression( self, query=None, allow_joins=True, reuse=None, summarize=False, for_save=False, )
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
- posted_at: `2026-11-09T23:44:49.5060370+00:00`

## Data

```json
{
  "end_line": 1050,
  "entity_kind": "method",
  "parent": "Sliced",
  "start_line": 1035,
  "symbol": "Sliced.resolve_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1035,"selector":"L1035-L1050","symbol":"Sliced.resolve_expression"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Sliced.resolve_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1050,
    "entity_kind": "method",
    "parent": "Sliced",
    "start_line": 1035,
    "symbol": "Sliced.resolve_expression"
  },
  "id": "350abbaa-2e73-4629-858f-643ab7a7e40d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5060370+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1035,
        "selector": "L1035-L1050",
        "symbol": "Sliced.resolve_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "0e6bb320-3c57-444e-9ff1-881a8a8c08db",
  "subject_name": "django/db/models/expressions::Sliced.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression( self, query=None, allow_joins=True, reuse=None, summarize=False, for_save=False, )"
}
```
