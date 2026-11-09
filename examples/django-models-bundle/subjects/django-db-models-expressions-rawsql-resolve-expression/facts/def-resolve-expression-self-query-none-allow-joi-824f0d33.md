# Fact 824f0d33

Store id: cdd6823f-9c8f-4d72-b698-7d18fb8e069a

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
- posted_at: `2026-11-09T23:31:55.8758880+00:00`

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
  "id": "cdd6823f-9c8f-4d72-b698-7d18fb8e069a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8758880+00:00"
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
  "subject_id": "30b636dd-666e-4baa-9ecc-65c638ac322d",
  "subject_name": "django/db/models/expressions::RawSQL.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression( self, query=None, allow_joins=True, reuse=None, summarize=False, for_save=False )"
}
```
