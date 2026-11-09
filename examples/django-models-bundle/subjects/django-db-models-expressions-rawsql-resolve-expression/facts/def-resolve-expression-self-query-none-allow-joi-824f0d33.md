# Fact 824f0d33

Store id: 36baec3d-2a45-4ed0-b798-53a5f3cbe2ae

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
- posted_at: `2026-11-09T22:39:41.6106920+00:00`

## Data

```json
{
  "end_line": 1300,
  "entity_kind": "method",
  "parent": "RawSQL",
  "start_line": 1286,
  "symbol": "RawSQL.resolve_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1286,"selector":"L1286-L1300","symbol":"RawSQL.resolve_expression"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::RawSQL.resolve_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1300,
    "entity_kind": "method",
    "parent": "RawSQL",
    "start_line": 1286,
    "symbol": "RawSQL.resolve_expression"
  },
  "id": "36baec3d-2a45-4ed0-b798-53a5f3cbe2ae",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6106920+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1286,
        "selector": "L1286-L1300",
        "symbol": "RawSQL.resolve_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "5d7fe3f4-0922-49bd-8f10-26ee8f8435fc",
  "subject_name": "django/db/models/expressions::RawSQL.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression( self, query=None, allow_joins=True, reuse=None, summarize=False, for_save=False )"
}
```
